using Microsoft.AspNetCore.Mvc;
using WebApiSapBo.Models;

namespace WebApiSapBo.Controllers
{
    [ApiController]
    [Route("api/sociedad")]
    public class SociedadController:ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using(var context = new DevpafisaContext())
            {
                return context.Users.ToList();
            }
        }
    }
}
