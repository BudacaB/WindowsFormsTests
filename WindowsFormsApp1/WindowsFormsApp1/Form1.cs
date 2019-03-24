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
            Car car = null;
            var brand = txtCarBrand.Text.ToUpper();
            List<Car> cars = new List<Car>();

            //if (string.IsNullOrEmpty(txtCarBrand.Text))
            //{
            //    lblResult.Text = "Please insert car brand";
            //    return;
            //}

            //if (txtCarBrand.Text.ToUpper() == "BMW")
            //{
            //    car = new Bemvew(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value));
            //}

            //if (txtCarBrand.Text.ToUpper() == "AUDI")
            //{
            //    car = new Audi(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value));
            //}

            //if (txtCarBrand.Text.ToUpper() != "BMW" && txtCarBrand.Text.ToUpper() != "AUDI")
            //{
            //    lblResult.Text = $"car {txtCarBrand.Text} is not in stock";
            //    return;
            //}

            switch (brand)
            {
                case ModelsInStock.BMW:
                    car = new Bemvew(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value));
                    lblResult.Text = JsonConvert.SerializeObject(car);
                    cars.Add(car);
                    break;
                case ModelsInStock.AUDI:
                    car = new Audi(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value));
                    lblResult.Text = JsonConvert.SerializeObject(car);
                    cars.Add(car);
                    break;
                case ModelsInStock.LANCIA:
                    car = new Lancia(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value));
                    lblResult.Text = JsonConvert.SerializeObject(car);
                    cars.Add(car);
                    break;
                case null:
                case "":
                    lblResult.Text = "Please insert car brand";
                    break;
                default:
                    lblResult.Text = $"car {txtCarBrand.Text} is not in stock";
                    break;
            }

            //var serializedCar = JsonConvert.SerializeObject(car);
            //lblResult.Text = serializedCar;

            foreach (var auto in cars)
            {
                lblArrayResult.Text = auto.ShowBrand();
            }

        }

        private void txtCarBrand_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numYear.Maximum = DateTime.Now.Year;

            // graceful error handling
            try
            {
                var manager = new AWSManager();
            }
            catch (Exception exc)
            {
                lblResult.Text = exc.InnerException.Message;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
