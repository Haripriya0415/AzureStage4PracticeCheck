using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using AzureAssessment.Models;
using AzureAssessment;

namespace AzureAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AnonymousUserController : Controller
    {
        // GET: api/AnonymousUser
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItemOperations.GetConnection();
        }
    }
}
