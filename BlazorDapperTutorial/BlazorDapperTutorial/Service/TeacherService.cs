using BlazorDapperTutorial.Data;
using BlazorDapperTutorial.IService;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperTutorial.Service
{
    public class TeacherService : ITeacherService
    {
        List<Teacher> _oTeachers = new List<Teacher>();
        Teacher _oTeacher = new Teacher();


        public IConfiguration _Configuration { get; }
        public string _connectionString = "";

        public TeacherService(IConfiguration configuration)
        {
            _Configuration = configuration;
            _connectionString = _Configuration.GetConnectionString("StudentDB");
        }

        public string Delete(int id)
        {
            string message = "Failed";

            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                _oTeacher = new Teacher()
                {
                    ID = id
                };
                if (conn.State == ConnectionState.Closed) conn.Open();
                var oTeachers = conn.Query<Teacher>("SP_Teacher",
                    this.SetParameters(_oTeacher, (int)OperationType.Delete),
                    commandType: CommandType.StoredProcedure);

                message = "Deleted";
            }
            return message;
        }

        public List<Teacher> GetTeachers()
        {
            _oTeachers = new List<Teacher>();
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                var oTeacher = conn.Query<Teacher>("Select * from Teacher").ToList();
                if (oTeacher != null && oTeacher.Count > 0)
                {
                    _oTeachers = oTeacher;
                }
            }
            return _oTeachers;
        }

        public Teacher GetById(int id)
        {
            _oTeacher = new Teacher();

            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();               
                var oTeachers = conn.Query<Teacher>("Select * from Teacher WHERE ID=" + id);
                if (oTeachers != null && oTeachers.Count() > 0)
                {
                    _oTeacher = oTeachers.FirstOrDefault();
                }
            }

            return _oTeacher;
        }

        public Teacher SaveOrUpdate(Teacher oTeacher)
        {
            _oTeacher = new Teacher();

            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                int operationType = Convert.ToInt32(_oTeacher.ID == 0 ? OperationType.Insert : OperationType.Update);
                var oTeachers = conn.Query<Teacher>("SP_Teacher", this.SetParameters(oTeacher, operationType), commandType: CommandType.StoredProcedure);
                if (oTeachers != null && oTeachers.Count() > 0)
                {
                    _oTeacher =oTeachers.FirstOrDefault();
                }
            }

            return _oTeacher;
        }

        private DynamicParameters SetParameters(Teacher oTeacher, int nOperationType)
        {
            DynamicParameters obj = new DynamicParameters();
            obj.Add("@ID", oTeacher.ID);
            obj.Add("@TeacherName", oTeacher.TeacherName);
            obj.Add("@Branch", oTeacher.Branch);
            obj.Add("@OperationType", nOperationType);

            return obj;

        }
    }
}
