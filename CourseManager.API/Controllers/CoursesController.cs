using CourseManager.Core.Models;
using CourseManager.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CourseManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _service;

        public CoursesController(ICourseService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Course>> Get() => Ok(_service.GetAll());

        [HttpPost]
        public ActionResult Create(Course course)
        {
            _service.Create(course);
            return CreatedAtAction(nameof(Get), new { id = course.Id }, course);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, Course course)
        {
            if (id != course.Id) return BadRequest();
            _service.Update(course);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var course = _service.GetById(id);
            if (course == null) return NotFound();
            _service.Delete(id);
            return NoContent();
        }
    }
}