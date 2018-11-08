using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.IServices;
using Blog.Core.Model.Models;
using Blog.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Core.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    //[Authorize(Policy = "Admin")]
    public class BlogController : Controller
    {
        // GET: api/values
        [HttpGet()]
        public int Get(int i,int j)
        {
            IAdvertisementServices advertisementServices = new AdvertisementServices();
            return advertisementServices.Sum(i, j);
        }

        // GET api/values/5
        [HttpGet("{id}",Name ="Get")]
        public List<Advertisement> Get(int id)
        {
            IAdvertisementServices advertisementServices = new AdvertisementServices();
            return advertisementServices.Query(d => d.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
