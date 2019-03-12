using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Car
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int CylinderNum { get; set; }

        public Car(string paramBrand, int paramYear, string paramColor, int paramCylinderNum)
        {
            this.Brand = paramBrand;
            this.Year = paramYear;
            this.Color = paramColor;
            this.CylinderNum = paramCylinderNum;
        }
    }
}
