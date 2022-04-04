using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntexFinal.Models
{
    public class crash_severity
    {
        [Key]
        [Required]
        public int crash_severity_id { get; set; }
        public string crash_severity_description { get; set; }
    }
}
