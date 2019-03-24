using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Bemvew: Car
    {
        public Bemvew(int paramYear, string paramColor, int paramCylinderNum)
            : base ("BMW", paramYear, paramColor, paramCylinderNum)
        {
           
        }

        public override string ShowBrand()
        {
            return "The brand is a furious BMW";
        }
    }
}
