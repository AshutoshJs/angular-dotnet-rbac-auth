using JwtRoledBasedAuth.CommonHeper.PaginationAndFilter;
using JwtRoledBasedAuth.DbConnection;
using JwtRoledBasedAuth.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtRoledBasedAuth.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class HumanResourcesController : ControllerBase
    {
        private MasterDbContext _masterDbContext;
        public HumanResourcesController(MasterDbContext masterDbContext) { 
        _masterDbContext = masterDbContext;
        }

        [HttpGet(Name = "/EmployeeWithPagination")]
        public async Task<IActionResult> GetEmpWithPagination([FromQuery] PageParameters pageParameters)
        {
            using (var context = new MasterDbContext())
            {

                var query = context.Employee.AsQueryable();

                if (!string.IsNullOrEmpty(pageParameters.FilterParam))
                {

                }
                var pagedUsers = await PagedList<Employee>.CreateAsync(
                        query,
                        pageParameters.PageNumber,
                        pageParameters.PageSize
                    );
                return Ok(pagedUsers);
            }
        }
    }
}
