using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CoreAPI.Entities
{
    public class ApiDB :DbContext
    {

        public ApiDB(DbContextOptions<ApiDB> options) : base(options) {
            Database.Migrate();
        }


        //ADD DbSets HERE
        public DbSet<object1> object1 { get; set; }



    }
}
