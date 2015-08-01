using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{
    public class Ford: carCompany {

        public Ford()
        {
            base.manufacturerName = "Ford";
        }
	    
        public override List<carModel> getCarModels()
        {
            List<carModel> models = new List<carModel>();

            models.Add(new FordModel("Taurus"));
            models.Add(new FordModel("C-MAX Hybrid", EngineTypes.Hybrid));
            models.Add(new FordModel("C-MAX Energi", EngineTypes.Electric));
            return models;
        }
        
    }


    
}
