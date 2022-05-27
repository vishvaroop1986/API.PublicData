using LundSchoolLocations.Models;
using LundSchoolLocations.Models.Model;

namespace LundSchoolLocations.Helper
{
    public class LocationOperations : ILocationOperations
    {
        SchoolContext _schoolContext;
        public LocationOperations(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public void InsertLocation(Location location)
        {
            _schoolContext.Locations.Add(location);
            _schoolContext.SaveChanges();
        }
    }
}