using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        private double radius;

        public string GetDiameter(string r)
        {
            string result = ParseRadius(r);
            if (result != "") { return result; }

            return "Diameter is: " + (radius*2);
        }

        public string GetPerimeter(string r)
        {
            string result = ParseRadius(r);
            if (result != "") { return result; }

            return "Perimeter is: " + (2 * Math.PI * radius);
        }

        public string GetArea(string r)
        {
            string result = ParseRadius(r);
            if (result != "") { return result; }

            return "Area is: " + (Math.PI * Math.Pow(radius, 2));
        }

        private string ParseRadius(string rad)
        {
            try
            {
                radius = Convert.ToDouble(rad);
                return "";
            }
            catch (Exception)
            {

                return "Radiuis is not a number";
            }
        }
    }
}
