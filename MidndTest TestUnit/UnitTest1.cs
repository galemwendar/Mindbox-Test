

using Mindbox_Test.Models;

namespace MidndTest_TestUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CircleSquareaWIthValues( )
        {
            var correct = Math.PI * Math.Pow(2.86, 2);
            Circle circle = new Circle(2.86);
            double square = circle.Square();
            Assert.AreEqual(correct, square);

        }

        [Test]
        public void CircleSquareWIthoutValues()
        {
            
            Circle circle = new Circle();
            double square = circle.Square();
            Assert.AreEqual(0, square);

        }
        [Test]
        public void TriangleSquareWIthValues()
        {
            
            Triangle triangle = new Triangle(3,4,5);
            var correct = (6);
            double square = triangle.Square();
            Assert.AreEqual(correct, square);

        }

        [Test]
        public void TriangleSquareWIthoutValues()
        {

            Circle circle = new Circle();
            double square = circle.Square();
            Assert.AreEqual(0, square);

        }

        [Test]
        public void TriangleIsRectangle()
        {

            Triangle triangle = new Triangle(3, 4, 5);
            var correct = true;
            var square = triangle.IsRectAngular;
            Assert.AreEqual(correct, square);

        }

        [Test]
        public void TriangleIsNotRectangle()
        {

            Triangle triangle = new Triangle(2, 4, 5);
            var correct = false;
            var square = triangle.IsRectAngular;
            Assert.AreEqual(correct, square);

        }

    }
}