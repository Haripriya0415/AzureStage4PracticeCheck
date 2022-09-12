using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using AzureAssessment;
using AzureAssessment.Models;
//using Microsoft.AspNetCore.Authentication.JwtBearer;


namespace AzureAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class AdminController : Controller
    {

        // GET: api/Admin
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItemOperations.GetConnection();
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MenuItem menu)
        {
            MenuItemOperations.Update(id, menu);
            return Ok();
        }

    }
}
