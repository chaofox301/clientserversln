using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using WestWindSystem.Entities;
using WestWindSystem.DAL;
using System.Reflection.Metadata.Ecma335;
#endregion

namespace WestWindSystem.BLL
{
    public class RegionServices
    {
        private readonly WestWindContext _context;

        //When we instantiate this class we need the context to be provided so we know where the DB is. A service cannot do anything unless it knows where the data is.

        public RegionServices(WestWindContext context)
        {
            _context = context;
        }

        //code the services

        public Region? LookupRegionByID(int regionID)
        {
            return _context.Regions.Where(R=>R.RegionId==regionID).FirstOrDefault();
            //returning a region object, or null if it doesnt find it
        }
    }
}

