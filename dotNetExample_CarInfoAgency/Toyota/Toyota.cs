using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{
    public class Toyota: carCompany {

        public Toyota()
        {
            base.manufacturerName = "Toyota";
        }
	    
        public override List<carModel> getCarModels()
        {
            List<carModel> models = new List<carModel>();

            models.Add(new ToyotaModel("Corolla"));
            models.Add(new ToyotaModel("Camry"));
            models.Add(new ToyotaModel("Prius"));

            return models;
        }
        
    }


    
}
