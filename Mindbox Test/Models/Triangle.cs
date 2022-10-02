using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_Test.Models
{
    public class Triangle: IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public bool IsRectAngular { get; set; }
        public double Square()
        {
            var semiPerimeter = (SideA + SideB + SideC) / 2;

            var aCoefficient = semiPerimeter - SideA;
            var bCoefficient = semiPerimeter - SideB;
            var cCoefficient = semiPerimeter - SideC;

            return Math.Sqrt(semiPerimeter * aCoefficient * bCoefficient * cCoefficient);
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = Math.Abs(sideA);
            SideB = Math.Abs(sideB);
            SideC = Math.Abs(sideC);
            IsRectAngular = CheckRectangular(SideA, SideB, SideC);
        }

        public Triangle()
        {
            SideA = default(int);
            SideB = default(int);
            SideC = default(int);
            IsRectAngular = default(bool);
        }



        private bool CheckRectangular(double sideA, double sideB, double sideC)
        {
            var maxSide = new[] { sideA, sideB, sideC }.Max();
            return 2 * Math.Pow(maxSide, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
        }




    }
}
