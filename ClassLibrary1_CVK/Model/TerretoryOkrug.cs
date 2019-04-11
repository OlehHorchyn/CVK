using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK.Model
{
    public class TerretoryOkrug
    {
        public string Id { set; get; }
        public int Total { set; get; }
        public int Processed { set; get; }
        public string Description { set; get; }
        public List<Department> departments { set; get; }
        public int OkrugHashCode { set; get; }

        public TerretoryOkrug()
        {
        }

        public TerretoryOkrug(string id, int total, int processed, string description)
        {
            Id = id;
            Total = total;
            Processed = processed;
            Description = description;
        }
        public TerretoryOkrug(string id, int total, int processed, string description, List<Department> d)
        {
            Id = id;
            Total = total;
            Processed = processed;
            Description = description;
            departments = d;
            OkrugHashCode = GetHashCode();
        }

        public override int GetHashCode()
        {
            var hashCode = 484993053;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + Total.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            foreach(Department dep in departments)
            {
                hashCode += dep.DepHashCode;
            }
            return hashCode;
        }
    }
}
