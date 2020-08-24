using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.InventoryItemsDtos
{
        public class InventoryItemsCreateDto
        {
            public string ItemName { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
        }
}
