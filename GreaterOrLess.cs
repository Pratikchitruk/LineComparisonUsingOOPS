using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUsingOOPs
{
   class GreaterOrLess
    {
        public int x1=1, x2=1;
        public int y1=1, y2=1;

        public void Compare()
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)
                    * (y2 - y1));

            Console.WriteLine("Distance between two points :" + distance);



            string s1 = distance.ToString();
            string s2 = distance.ToString();

            Console.WriteLine(s1.Equals(s2));

            Console.WriteLine(s1.CompareTo(s2));

        }
    }
}
