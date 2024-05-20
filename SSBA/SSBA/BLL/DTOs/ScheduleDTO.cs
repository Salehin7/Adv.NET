using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ScheduleDTO
    {
        public int Id { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Location { get; set; }
    }
}
