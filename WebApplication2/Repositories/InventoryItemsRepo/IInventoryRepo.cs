using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.InventoryItemsRepo
{
    public interface IInventoryRepo
    {
        bool SaveChanges();

        IEnumerable<InventoryItems> GetAllItems();
        InventoryItems GetItemById(int id);
        void CreateItem(InventoryItems item);
        void UpdateItem(InventoryItems item);
        void DeleteItem(InventoryItems item);
    }
}
