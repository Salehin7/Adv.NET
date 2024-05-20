using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Notice
    {
        [Key]
        public int NId { get; set; }
        [Required]
        [StringLength(50)]
        public string NTitle { get; set; }
        [Required]
        [StringLength(50)]
        public string NDescription { get; set; }
    }
}
