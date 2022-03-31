using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonUsingOOPs
{
     class CalculateLength
    {
        public int x1 = 1, x2 =1;
        public int y1 = 1, y2 =1;

        public void length()
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1)
                    * (y2 - y1));

            Console.WriteLine("Distance between two points :" + distance);


        }
       

        

      
    }
}
