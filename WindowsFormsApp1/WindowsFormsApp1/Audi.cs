using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Audi : Car
    {
        public Audi(int paramYear, string paramColor, int paramCylinderNum, string paramModelType)
            : base ("AUDI", paramYear, paramColor, paramCylinderNum, paramModelType)
        {

        }

        public override string ShowBrand()
        {
            return base.Brand;
        }
    }
}
