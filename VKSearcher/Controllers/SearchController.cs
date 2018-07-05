using System;
using System.Web.Http;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VKSearcher.Models;

namespace VKSearcher.Controllers
{
    [RoutePrefix("api/search")]
    public class SearchController : ApiController
    {
        [HttpGet, Route("")]
        public VKUserModel Get()
        {
            var api = new VkApi();
            api.Authorize(new ApiAuthParams
            {
                AccessToken = "905e7fc0875abc172a2b01a0b8eb058df9423a146bc12476b7d86a93c57852886372c69680a125ee1a646"
            });
            var res = api.Groups.Get(new GroupsGetParams());

            Console.WriteLine(res.TotalCount);

            Console.ReadLine();
            return new VKUserModel();
        }
    }
}