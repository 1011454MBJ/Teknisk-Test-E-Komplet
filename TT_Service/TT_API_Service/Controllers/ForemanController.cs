using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TT_DataAccess.Repository;

namespace TT_API_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForemanController : Controller
    {
        // GET: ForemanController
        [HttpGet(Name = "GetForeman")]
        public string GetForeman()
        {
            ForemanRepository foremanRepo = new ForemanRepository();
            //return View();
            //return foremanRepo.GetForeman();
            return "Foreman";
        }

    }
}
