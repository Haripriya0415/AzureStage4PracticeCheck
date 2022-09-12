using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AzureAssessment.Models; 

namespace AzureAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id, string password)
        {
            List<User> list = MenuItemOperations.UserList();
            bool user = list.Any(p => p.userId == id && p.password == password);
            if (user == true)
                return "true";
            return "falseSubmission";
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            MenuItemOperations.Insert(user);
            return Ok();
        }

    }
}
