using API.Models;
using API.Repositories;
using API.Repositories.InventoryItemsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class SqlInventoryRepo : IInventoryRepo
    {
        private readonly Context _context;

        public SqlInventoryRepo(Context context)
        {
            _context = context;
        }

        public void CreateItem(InventoryItems item)
        {
            if(item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            _context.Items.Add(item);
        }

        public void DeleteItem(InventoryItems item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Items.Remove(item);
        }

        public IEnumerable<InventoryItems> GetAllItems()
        {
            return _context.Items.ToList();
        }

        public InventoryItems GetItemById(int id)
        {
            return _context.Items.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateItem(InventoryItems item)
        {
        }
    }
}
