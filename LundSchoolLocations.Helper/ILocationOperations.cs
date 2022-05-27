using LundSchoolLocations.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LundSchoolLocations.Helper
{
    public interface ILocationOperations
    {
        void InsertLocation(Location location);
    }
}
