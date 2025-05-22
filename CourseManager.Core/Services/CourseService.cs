using CourseManager.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CourseManager.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly CourseManagerDbContext _context;

        public CourseService(CourseManagerDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAll() => _context.Courses.ToList();
        public Course GetById(int id) => _context.Courses.Find(id);
        public void Create(Course course) { _context.Courses.Add(course); _context.SaveChanges(); }
        public void Update(Course course) { _context.Courses.Update(course); _context.SaveChanges(); }
        public void Delete(int id)
        {
            var course = GetById(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}