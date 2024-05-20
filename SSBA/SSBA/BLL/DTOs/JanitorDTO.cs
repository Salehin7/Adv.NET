using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class JanitorDTO
    {
        public int JId { get; set; }
        [Required]
        public string JName { get; set; }
        [Required]
        public string Task { get; set; }
    }
}
