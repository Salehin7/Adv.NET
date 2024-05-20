using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Revenue
    {
        [Key]
        public int RevId { get; set; }

        public int EventRev { get; set; }
        public int SponsorRev { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
        [ForeignKey("Sponsor")]
        public int SponsorId { get; set; }

        
        public virtual Event Event { get; set; }

       
        public virtual Sponsor Sponsor { get; set; }
    }
}
