namespace Owin.Docker
{
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    public class HelloController : ApiController
    {
        [HttpGet]
        public async Task<HttpResponseMessage> Get()
        {
            HttpResponseMessage response = Request.CreateResponse<string>(HttpStatusCode.OK, "Hello Sogeti!");
            return response;
        }
    }
}