using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carInfoAgencyExample
{
    public abstract class carSales {
	    public carModel model {get; set;}
	    public int salesYear  {get; set;}
	    public int numberOfCarsSold  {get; set;}
    }
}
