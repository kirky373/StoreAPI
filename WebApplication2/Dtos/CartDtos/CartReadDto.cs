﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.CartDtos
{
    public class CartReadDto
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
