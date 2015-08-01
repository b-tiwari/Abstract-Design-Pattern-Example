using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{

    public class FordModel : carModel
    {
        private EngineTypes engineType { get; set; }
        public FordModel(String pName, EngineTypes pEngineType = EngineTypes.Gas) //default Engine type = Gas
        {
            base.name = pName;
            this.engineType = pEngineType;
            
        }

        public override bool isHybrid()
        {
            if (this.engineType.ToString().ToLower() == "hybrid")
            {
                return true;
            }

            return false;
        }
    }
}
