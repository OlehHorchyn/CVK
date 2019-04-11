using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class CVK
    {
        public int CVKHashCode { set; get; }
        public List<Region> Regions { set; get; }

        
        public CVK(List<Region> regions)
        {
            Regions = regions;
            CVKHashCode = GetHashCode();
        }

        
        public override int GetHashCode()
        {
            int hashCode = -531129542;
            foreach(Region region in Regions)
            {
                hashCode += region.RegionHashCode;
            }
            return hashCode;
        }
    }
}
