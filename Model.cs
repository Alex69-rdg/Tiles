using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_Na_Plo4ki_MVC
{
    public class Model
    {
        private int n;
        public int N
        {
            get { return n; }
            set { n = value; }
        }

        private double w;
        public double W 
        {
            get { return w; }
            set { w = value; }
        }

        private double l;
        public double L
        {
            get { return l; }
            set { l = value; }
        }

        private int m;
        public int M
        {
            get { return m; }
            set { m = value; }
        }

        private int o;
        public int O
        {
            get { return o; }
            set { o = value; }
        }


        private double tile;
        public double Tile { get; set; }

        public double CalculateTile()
        {
            int area = N * N;
            int benchArea = M * O;
            int areaToCover = area - benchArea;
            double tilearea = W * L;
            Tile=areaToCover / tilearea;
            return Tile;

        }
        private double time;
        public double Time { get; set; }
        public double CalculateTime()
        {
            Time=Tile * 0.2;
            return Time;
        }

        public Model() : this(0, 0)
        {

        }
        public Model(double tile,double time)
        {
            this.Tile = tile;
            this.Time = time;
        }









    }
}
