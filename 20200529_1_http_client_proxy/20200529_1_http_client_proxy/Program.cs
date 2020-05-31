using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace _20200529_1_http_client_proxy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // .net core http client ile proxy kullanımı örneği


            const string ProxyUrl = "http://localhost:5001";
            const string ProxyUsername = "";
            const string ProxyPassword = "";
            const string RequestUrl = "https://google.com";

            var proxy = new WebProxy
            {
                Address = new Uri(ProxyUrl),
                Credentials = new NetworkCredential(ProxyUsername, ProxyPassword)
            };

            // web proxy sınıfı ile proxy adresi proxy adresine ait kullanıcı adı şifre tanımlamaları

            var httpClientHandler = new HttpClientHandler
            {
                Proxy = proxy,
                UseProxy = true
            };

            // oluşturulan proxy nesnesini HttpClientHandler nesnesinin proxy özeeliğine atarız


            using (var client = new HttpClient(httpClientHandler))
            {
                var response = await client.GetAsync(RequestUrl);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseString);
                }
            }

            //HttpClient tipinin nesne örneğini oluştururken constructora HttpClientHandler tipindeki nesne örneğini veririz
    }
}
