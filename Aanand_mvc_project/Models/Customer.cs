using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aanand_mvc_project.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public Location location { get; set; }


    }
}
