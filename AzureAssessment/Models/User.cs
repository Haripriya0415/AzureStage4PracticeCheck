using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureAssessment.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string password { get; set; }
    }
}

