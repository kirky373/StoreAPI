﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Cart
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string ItemName { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
