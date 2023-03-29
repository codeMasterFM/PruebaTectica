using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IServiceCrud
    {
        public Task<object> GetAll();
        public Task<object> GetDataOrde();
        public Task<object> GetbySimbol(string Symbol);
    }
}
