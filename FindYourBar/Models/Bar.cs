using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourBar.Models
{
    public class Bar
    {
        public string Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(15)]
        [MaxLength(255)]
        public string Address { get; set; }
    }
}
