using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LundSchoolLocations.Models
{
    public class SchoolContext: DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().ToTable("Location");            
        }
    }

    [Table("Location")]
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
        public string Latitude { get; set; }
    }
}
