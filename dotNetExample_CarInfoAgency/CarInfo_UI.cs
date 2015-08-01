using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carInfoAgencyExample
{
    public partial class CarInfo_UI : Form
    {
        public CarInfo_UI()
        {
            InitializeComponent();
        }

        private void lblToyota_Click(object sender, EventArgs e)
        {
            showCompanysCarModels(new Toyota());
        }

        private void lblFord_Click(object sender, EventArgs e)
        {
            showCompanysCarModels(new Ford());
        }

        private void showCompanysCarModels(carCompany theCarCompany)
        {
            List<carModel> models = theCarCompany.getCarModels();
            gvCarCompanyModels.DataSource = models;
        }

       

    }
}
