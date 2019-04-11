using ClassLibrary1_CVK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_CVK
{
    interface DAOSetting
    {
        void upsert(CVK cvk);
    }
}
