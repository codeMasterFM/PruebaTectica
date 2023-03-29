

using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class BitmexContext:DbContext
    {
       public BitmexContext(DbContextOptions<BitmexContext>opcion):base(opcion) 
        {}
        public DbSet<Instrument> instruments { get; set; }
    }
}
