using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.CartRepo
{
    public class SqlCartRepo : ICartRepo
    {

        private readonly Context _context;

        public SqlCartRepo(Context context)
        {
            _context = context;
        }
        public IEnumerable<Cart> GetAllItems()
        {
            return _context.Cart.ToList();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
