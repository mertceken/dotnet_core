using BlazorDapperTutorial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperTutorial.IService
{
    public interface IStudentService
    {
        List<Student> GetStudents();

        Student GetById(int id);

        Student SaveOrUpdate(Student oStudent);

        string Delete(int id);

    }
}
