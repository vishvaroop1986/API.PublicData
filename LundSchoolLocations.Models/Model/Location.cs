using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LundSchoolLocations.Models.Model
{
    [Table("Location")]
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Name { get; set; }
        public string Locality { get; set; }
        public string LocationId { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string Operation { get; set; }
        public string Latitude { get; set; }
        public string Url { get; set; }
        public string Longitude { get; set; }
    }
}
