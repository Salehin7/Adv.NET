﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SponsorDTO
    {
        [Key]
        public int SponsorId { get; set; }
        [Required]
        [StringLength(50)]
        public string SponsorName { get; set; }
        [Required]
        public string SponsorTerms { get; set; }
    }
}
