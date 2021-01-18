using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiDbEntityFramework.Models
{
    public class CarContext: DbContext
    {

        public CarContext(DbContextOptions<CarContext> options): base(options)
        {
            
        }

        public DbSet<CarModel> Cars { get; set; }
    }
}
