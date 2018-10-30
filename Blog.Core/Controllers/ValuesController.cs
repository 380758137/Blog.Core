using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Core.Controllers
{
    /// <summary>
    /// value Api
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy ="Admin")]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// 获取所有value值
        /// </summary>
        /// <returns>The get.</returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        /// <summary>
        /// Post
        /// </summary>
        /// <param name="love">model实体参数类</param>
        [HttpPost]
        public void Posts(Love love)
        {

        }
    }
}
