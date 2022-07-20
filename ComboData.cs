using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterLevelData
{
    public partial class ComboData
    {
        public string Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }

        public ComboData(string r, string n)
        {
            Id = r;
            Name = n;
        }
    }
}
