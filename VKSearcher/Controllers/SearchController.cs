using System.Web.Http;
using VKSearcher.Models;

namespace VKSearcher.Controllers
{
    public class SearchController : ApiController
    {
        public SearchController()
        {
            
        }

        [HttpGet]
        public VKUserModel Get()
        {
            return new VKUserModel();
        }
    }
}