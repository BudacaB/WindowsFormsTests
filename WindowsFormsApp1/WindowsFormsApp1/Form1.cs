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

        List<Car> cars = new List<Car>();
        Car car = null;

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            
            var brand = txtCarBrand.Text.ToUpper();

            switch (brand)
            {
                case ModelsInStock.BMW:
                    car = new Bemvew(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value), modelType.Text.ToUpperInvariant());
                    lblResult.Text = JsonConvert.SerializeObject(car);
                    break;
                case ModelsInStock.AUDI:
                    car = new Audi(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value), modelType.Text.ToUpperInvariant());
                    lblResult.Text = JsonConvert.SerializeObject(car);
                    break;
                case ModelsInStock.LANCIA:
                    car = new Lancia(Convert.ToInt32(numYear.Value), txtColor.Text.ToUpperInvariant(), Convert.ToInt32(numCylinder.Value), modelType.Text.ToUpperInvariant());
                    lblResult.Text = JsonConvert.SerializeObject(car);     
                    break;
                case null:
                case "":
                    lblResult.Text = "Please insert car brand";
                    break;
                default:
                    lblResult.Text = $"car {txtCarBrand.Text} is not in stock";
                    break;
            }

            lblArrayResult.Text = string.Empty;
            cars.Add(car);
            foreach (var auto in cars)
            {
                lblArrayResult.Text += " " + auto.ShowBrand();
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

    private void numCylinder_ValueChanged(object sender, EventArgs e)
    {

    }
    }
}
