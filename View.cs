using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_Na_Plo4ki_MVC
{
    public class View
    {

        public int N {  get; set; }
        public double W {  get; set; }
        public double L {  get; set; }

        public int M { get; set; }
        public int O { get; set; }

        public double Tile { get; set; }
        public double Time { get; set; }

        public void InputInfoSize()
        {
            Console.Write("Enter N= ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Enter W= ");
            W = double.Parse(Console.ReadLine());
            Console.Write("Enter L= ");
            L = double.Parse(Console.ReadLine());
            Console.Write("Enter M= ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Enter O= ");
            O = int.Parse(Console.ReadLine());
        }

        public void OutputInfoTotal()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Tiles needed: {Tile} br.");
            Console.WriteLine($"Time needed: {Time} min.");
        }
    }
}
