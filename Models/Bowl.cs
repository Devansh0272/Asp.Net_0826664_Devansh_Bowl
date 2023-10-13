using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UniqueBowl.Models
{
    public class Bowl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string design { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
    }
}
