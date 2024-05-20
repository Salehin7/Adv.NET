﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public string UId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [Required]
        public string  UType { get; set; }
    }
}