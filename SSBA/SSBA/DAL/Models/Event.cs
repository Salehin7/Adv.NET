using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Event
    {
        [Key]
        public int EventId {  get; set; }
        [Required]
        [StringLength(50)]
        public string EventName { get; set; }
        [Required]
        [StringLength(20)]
        public string EventType{ get; set; }
        [Required]
        public int EventTicket { get; set; }
        [Required]
        public int EventRev { get; set; }
        [Required]
        public int EventTime { get; set; }
    }
}
