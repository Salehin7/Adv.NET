using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Time { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
    }
}
