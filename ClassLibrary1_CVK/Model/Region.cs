using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class Region
    {
        public string RegionName { set; get; }

        public int Count { set; get; }
        public List<TerretoryOkrug> okrugs { set; get; }
        public int RegionHashCode { set; get; }

        public Region()
        {
        }

        public Region(string regionName, int count)
        {
            RegionName = regionName;
            Count = count;
        }

        public Region(string regionName, int count, List<TerretoryOkrug> o)
        {
            RegionName = regionName;
            Count = count;
            okrugs = o;
            RegionHashCode = GetHashCode();
        }


        public override int GetHashCode()
        {
            var hashCode = -1705680190;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RegionName);
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            foreach(TerretoryOkrug t in okrugs)
            {
                hashCode += t.OkrugHashCode;
            }
            return hashCode;
        }
    }
}
