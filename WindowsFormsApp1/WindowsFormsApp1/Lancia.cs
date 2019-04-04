using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Lancia : Car
    {
        public Lancia(int paramYear, string paramColor, int paramCylinderNum) : 
            base("Lancia", paramYear, paramColor, paramCylinderNum)
        {

        }

        public override string ShowBrand()
        {
            return base.Brand;
        }
    }
}
