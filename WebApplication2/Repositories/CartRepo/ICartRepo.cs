using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.CartRepo
{
    public interface ICartRepo
    {
        bool SaveChanges();
        IEnumerable<Cart> GetAllItems();
    }
}
