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
    public class StudentService : IStudentService
    {
        List<Student> _oStudents = new List<Student>();
        Student _oStudent = new Student();
        public IConfiguration _Configuration { get; }
        public string _connectionString = "";

        public StudentService(IConfiguration configuration)
        {
            _Configuration = configuration;
            _connectionString = _Configuration.GetConnectionString("StudentDB");
        }
        public string Delete(int id)
        {
            string message = "Failed";

            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                _oStudent = new Student()
                {
                    Id = id
                };
                if (conn.State == ConnectionState.Closed) conn.Open();
                var oStudents = conn.Query<Student>("SP_Student",
                    this.SetParameters(_oStudent, (int)OperationType.Delete), 
                    commandType: CommandType.StoredProcedure);

                message = "Deleted";
            }
            return message;
        }

        public Student GetById(int id)
        {
            _oStudent = new Student();
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                var oStudents = conn.Query<Student>("Select * from Student WHERE Id="+ id);
                if (oStudents != null && oStudents.Count() > 0)
                {
                    _oStudent = oStudents.FirstOrDefault();
                }
            }
            return _oStudent;
        }

        public List<Student> GetStudents()
        {
            _oStudents = new List<Student>();
            using(IDbConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                var oStudents = conn.Query<Student>("Select * from Student").ToList();
                if (oStudents!=null && oStudents.Count>0)
                {
                    _oStudents = oStudents;
                }
            }
            return _oStudents;
        }

        public Student SaveOrUpdate(Student oStudent)
        {
            _oStudent = new Student();
            using (IDbConnection conn = new SqlConnection(_connectionString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                int operationType = Convert.ToInt32(oStudent.Id == 0 ? OperationType.Insert : OperationType.Update);
                var oStudents = conn.Query<Student>("SP_Student",this.SetParameters(oStudent,operationType), commandType: CommandType.StoredProcedure);
                if (oStudents != null && oStudents.Count() > 0)
                {
                    _oStudent = oStudents.FirstOrDefault();
                }
            }
            return _oStudent;
        }

        private DynamicParameters SetParameters(Student oStudent,int nOperationType)
        {
            DynamicParameters obj = new DynamicParameters();
            obj.Add("@Id", oStudent.Id);
            obj.Add("@Name", oStudent.Name);
            obj.Add("@Roll", oStudent.Roll);
            obj.Add("@OperationType", nOperationType);

            return obj;

        }
    }
}
