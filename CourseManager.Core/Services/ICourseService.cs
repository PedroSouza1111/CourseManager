using CourseManager.Core.Models;
using System.Collections.Generic;

namespace CourseManager.Core.Services
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        void Create(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}