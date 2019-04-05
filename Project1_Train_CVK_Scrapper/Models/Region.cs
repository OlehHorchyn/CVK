using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Train_CVK_Scrapper.Models
{
    class Region
    {
        public string RegionName { set; get; }

        public int Count { set; get; }
        public List<TerretoryOkrug> okrugs = new List<TerretoryOkrug>();

        public Region(string regionName, int count)
        {
            RegionName = regionName;
            Count = count;
        }
    }
}
