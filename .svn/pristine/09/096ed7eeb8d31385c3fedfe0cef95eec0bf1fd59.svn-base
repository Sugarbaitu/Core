using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net5ByDocker.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<string> userInfo = new();

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return userInfo;
        }
        [HttpPost]
        public List<string> Post([FromBody] string value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                userInfo.Add(value);
            }
            return userInfo;
        }

        [HttpDelete("{id}")]
        public List<string> Delete(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                userInfo.Remove(id);
            }
            return userInfo;
        }

    }
}
