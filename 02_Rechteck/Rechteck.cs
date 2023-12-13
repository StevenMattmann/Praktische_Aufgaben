using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUFGABE.BLJ
{
    internal class Rechteck
    {

        public double Height {  get; set; }
        public double Width { get; set; }


        public double GetArea() 
        {
            double area = Height * Width;

            return area;
        }
    }
}
