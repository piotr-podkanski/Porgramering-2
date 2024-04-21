using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_11._1

{

    internal class Ellipser
    {
        private double x;
        private double y;
        private double lenght;
        private double width;
        private double pi = 3.1416;
        public List<int> color;

        public Ellipser()
        {
            Random rnd = new Random();
            color = new List<int>{rnd.Next(256), rnd.Next(256), rnd.Next(256)};

        }

        

        
    }
}
