using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Core.AuthHelper.OverWrite;
using Blog.Core.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Core.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("Token2")]
        public JsonResult GetJWTStr(long id=1,string sub = "Admin")
        {
            TokenModelJwt tokenModelJwt = new TokenModelJwt();
            tokenModelJwt.Uid = id;
            tokenModelJwt.Role = sub;
            string jwtStr = JwtHelper.IssueJWT(tokenModelJwt);
            return Json(jwtStr);
        }
    }
}
