using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{
    public abstract class carCompany {
	    public string manufacturerName{get; set;}
        public abstract List<carModel> getCarModels();
        //public abstract List<carSales> getCarSales(String year, String modelName = null);
    }
}
