using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_Test.Models
{
    public class Circle: IFigure
    {
        public double Radius { get;}

        public Circle(double radius)
        {
            Radius = Math.Abs(radius);    
        }

        public Circle()
        {
            Radius = default(int);
        }


        public double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
