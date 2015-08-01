using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{
    public abstract class carModel {
            public string name {get; set;}

            public string Hybrid
            {
                get { return isHybrid().ToString(); }
                
            }

            public abstract Boolean isHybrid();
        }
}
