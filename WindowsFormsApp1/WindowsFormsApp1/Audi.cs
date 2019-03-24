using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Audi : Car
    {
        public Audi(int paramYear, string paramColor, int paramCylinderNum)
            : base ("AUDI", paramYear, paramColor, paramCylinderNum)
        {

        }

        public override string ShowBrand()
        {
            return "The brand is a fast Audi";
        }
    }
}
