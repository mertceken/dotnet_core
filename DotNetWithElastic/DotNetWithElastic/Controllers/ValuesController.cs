using DotNetWithElastic.Context;
using DotNetWithElastic.Models;
using Elasticsearch.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DotNetWithElastic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class ValuesController : ControllerBase
    {
        AppDbContext _context = new();
        [HttpGet("[action]")]
        public async Task<IActionResult> CreateData(CancellationToken cancellationToken)
        {
            IList<Vacation> vacations = new List<Vacation>();
            var random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                var title = new String(Enumerable.Repeat("abcdefgğhıijklmnoöprsştuüvyz", 5).Select(x => x[random.Next(x.Length)]).ToArray());

                var descriptionWords = new List<string>();

                for (int j = 0; j < 500; j++)
                {
                    descriptionWords.Add(new String(Enumerable.Repeat("abcdefgğhıijklmnoöprsştuüvyz", 5).Select(x => x[random.Next(x.Length)]).ToArray()));
                }

                var description = string.Join("", descriptionWords);

                var vacay = new Vacation()
                {
                    Title = title,
                    Description = description,
                };
                vacations.Add(vacay);
                await _context.Set<Vacation>().AddRangeAsync(vacations, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
            }

            return Ok();
        }
        [HttpGet("[action]/{description}")]
        public async Task<IActionResult> GetVacationDataList(string description)
        {
            IList<Vacation> vacations = await _context.Set<Vacation>().Where(x => x.Description.Contains(description)).AsNoTracking().ToListAsync();


            return Ok(vacations);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> ElasticConfiguration()
        {
            var settings = new ConnectionConfiguration(new Uri("http://localhost:9200"));

            var client = new ElasticLowLevelClient(settings);

            List<Vacation> vacayList = await _context.Vacations.ToListAsync();

            var taskList = new List<Task>();

            foreach (var item in vacayList)
            {
                taskList.Add(client.IndexAsync<StringResponse>("vacayList", item.Id.ToString(), PostData.Serializable(new
                {
                    item.Id,
                    item.Title,
                    item.Description
                })));
            }
            await Task.WhenAll(taskList);
            return Ok();
        }

        [HttpGet("[action]/{value}")]
        public async Task<IActionResult> GetVacationListFromElasticSearch(string value)
        {
             var settings = new ConnectionConfiguration(new Uri("http://localhost:9200"));

            var client = new ElasticLowLevelClient(settings);

            var response = await client.SearchAsync<StringResponse>("vacayList", PostData.Serializable(new
            {
                query = new
                {
                  wildcard = new
                  {
                      Description = new { value = $"*{value}"}
                  }
                }
            }));
            var result = JObject.Parse(response.Body);

            var hits = result["hits"]["hits"].ToObject<List<JObject>>();
            List<Vacation> vacations = new();

            foreach (var item in hits)
            {
                vacations.Add(item["_source"].ToObject<Vacation>());
            }
            return Ok();
        }


    }
}
