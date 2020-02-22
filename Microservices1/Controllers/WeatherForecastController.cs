using Microservices1.DataObjects;
using Microsoft.AspNetCore.Mvc;

namespace Microservices1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        IElement _myCourse;

        public WeatherForecastController(IElement element)
        {
            _myCourse = element;
        }

        [HttpPost]
        public string Post([FromBody] DataObjects.oCourse course)
        {
            return _myCourse.Save();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_myCourse.GetCourses());
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return new OkObjectResult(_myCourse.GetCourseByID(id));
        }

    }
}
