using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TT_DataAccess.Repository;
using TT_DataAccess.Model;

namespace TT_API_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForemanController : Controller
    {
        /// <summary>
        /// Calls repository for foremans to get all foremans
        /// </summary>
        /// <returns>A list of foremans</returns>
        // GET: ForemanController
        [HttpGet(Name = "GetForeman")]
        public IEnumerable<Foreman> GetForeman()
        {
            
            ForemanRepository foremanRepo = new ForemanRepository();
            //return View();
            return foremanRepo.GetAllForeman();
            //return "Foreman";
        }

    }
}
