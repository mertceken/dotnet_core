using BlazorDapperTutorial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDapperTutorial.IService
{
    public interface ITeacherService
    {
        List<Teacher> GetTeachers();

        Teacher GetById(int id);

        Teacher SaveOrUpdate(Teacher oTeacher);

        string Delete(int id);
    }
}
