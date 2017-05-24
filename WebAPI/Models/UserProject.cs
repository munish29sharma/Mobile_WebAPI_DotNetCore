using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class UserProject
    {
        [Key]
        public int UserId { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public string Project_Name { get; set; }

    }
}
