﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.InventoryItemsDtos
{
    public class InventoryItemsReadDto { 
            public int Id { get; set; }
            public string ItemName { get; set; }
            public double Price { get; set; }
    }
}
