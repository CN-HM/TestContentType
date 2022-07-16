using System.Net.Mime;
using System.Text;
using Furion.RemoteRequest.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task Get()
        {
            await "http://www.baidu.com".SetContentEncoding(Encoding.UTF8)
                /*.SetContentType("multipart/form-data")
                .SetContentType("application/json")*/
               .SetContentType("application/octet-stream")
               .PutAsync();
        }
    }
}