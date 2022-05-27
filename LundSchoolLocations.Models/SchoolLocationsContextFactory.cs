using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LundSchoolLocations.Models
{
    internal class SchoolLocationsContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            var conn = "Server=localhost\\SQLEXPRESS;Database=SchoolData;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(conn);

            return new SchoolContext(optionsBuilder.Options);
        }
    }
}
