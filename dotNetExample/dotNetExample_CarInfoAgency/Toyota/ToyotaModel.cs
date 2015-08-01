using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{
    public class ToyotaModel : carModel
    {
        public ToyotaModel(String pName)
        {
            base.name = pName;
        }

        public override bool isHybrid()
        {
            if (this.name.ToLower() == "prius")
            {
                return true;
            }
            return false;
        }
    }
}
