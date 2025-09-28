using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Rectangle
    {
        // Private fields
        private int l;
        private int w;

        // Public properties
        public int L
        {
            get { return l; }
            set { l = value; }
        }

        public int W
        {
            get { return w; }
            set { w = value; }
        }

        // Constructor
        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }
        
        public void S()
        {
            Console.WriteLine($"The area of the rectangle is{l*w}" );
        }
    }
}
