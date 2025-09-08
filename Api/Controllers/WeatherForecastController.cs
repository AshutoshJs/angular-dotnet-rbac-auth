using JwtRoledBasedAuth.CommonHeper.PaginationAndFilter;
using JwtRoledBasedAuth.DbConnection;
using JwtRoledBasedAuth.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtRoledBasedAuth.Controllers
{
    [Authorize]
    [ApiController]
    // [Route("[controller]")] Giving swaggger error when added method GetEmpWithPagination
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Employee> Get()
        {
            using (var context = new MasterDbContext())
            {

                return context.Employee.ToList();
            }

            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
        
        [HttpGet(Name = "/EmployeeWithPagination")]
        public async  Task<IActionResult> GetEmpWithPagination([FromQuery] PageParameters pageParameters)
        {
            using (var context = new MasterDbContext())
            {
                
                var query = context.Employee.AsQueryable();

                if (!string.IsNullOrEmpty(pageParameters.FilterParam)) { 
                
                }
                var pagedUsers = await PagedList<Employee>.CreateAsync(
                        query,
                        pageParameters.PageNumber,
                        pageParameters.PageSize
                    );
                return Ok(pagedUsers);
            }
        }


        /*[HttpGet(Name = "/EmployeeWithFilter")]
        public async Task<IActionResult> GetEmpFiter([FromQuery] FilterModel filterParameters)
        {
            using (var context = new MasterDbContext())
            {
                var query = context.Employee.AsQueryable();

                PageParameters
                var pagedUsers = await PagedList<Employee>.CreateAsync(
                        query,
                        pageParameters.PageNumber,
                        pageParameters.PageSize
                    );
                return Ok(pagedUsers);
            }
        }*/
    }
}
