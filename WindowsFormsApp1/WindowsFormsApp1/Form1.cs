using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCarBrand.Text))
            {
                lblResult.Text = "Please insert car brand";
                return;
            }
            var bmw = new Car(txtCarBrand.Text.ToUpperInvariant(), Convert.ToInt32(numYear.Value));
            var serializedCar = JsonConvert.SerializeObject(bmw);
            lblResult.Text = serializedCar;
        }

        private void txtCarBrand_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numYear.Maximum = DateTime.Now.Year;
            var manager = new AWSManager();
        }
    }
}
