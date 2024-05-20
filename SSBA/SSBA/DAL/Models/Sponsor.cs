using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Sponsor
    {
        [Key]
        public int SponsorId { get; set; }
        [Required]
        [StringLength(50)]
        public string SponsorName { get; set; }
        [Required]
        public string SponsorTerms { get; set; }
        [Required]
        public int SponsorRev { get; set; }
    }
}
