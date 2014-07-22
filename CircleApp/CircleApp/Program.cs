using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CircleUI());

            Console.WriteLine("Circle Calculator");
            Console.Write("Enter Redius: ");
            
            string radius = Console.ReadLine();

            Console.Write("Write: dia, peri or area: ");
            string calType = Console.ReadLine();

            Circle aCircle = new Circle();
            if (calType.ToLower() == "dia")
            {
                string result = aCircle.GetDiameter(radius);
                Console.WriteLine(result);
            }
            else if (calType.ToLower() == "peri")
            {
                string result = aCircle.GetPerimeter(radius);
                Console.WriteLine(result);
            }
            else if (calType.ToLower() == "area")
            {
                string result = aCircle.GetArea(radius);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid command!");
            }
            Console.ReadKey();
        }
    }
}
