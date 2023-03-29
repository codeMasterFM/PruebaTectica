using Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceCrud : IServiceCrud
    {
        private readonly BitmexContext _context;
        public ServiceCrud(BitmexContext context)
        {
            _context = context;
        }
        public async Task<object> GetAll()
        {
            return await _context.instruments.ToListAsync();
            
        }

        public async Task<object> GetbySimbol(string symbol)
        {
            return await _context.instruments.Where(x => x.symbol == symbol).ToListAsync();
        }

        public async Task<object> GetDataOrde()
        {
            return await _context.instruments.OrderByDescending(x => x.publishTime).ToListAsync();

        }

  
    }
}
