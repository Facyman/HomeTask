using Microsoft.VisualStudio.TestTools.UnitTesting;
using testtask1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtask1.Tests
{
    [TestClass()]
    public class AreaOfShapesTests
    {

        [TestMethod]
        public void CircleArea()
        {
            //arrange

            int r = 5;
            var correctArea = Math.PI * Math.Pow(r, 2);
            //act
            var area = AreaOfShapes.Operation("Circle", r);

            //assert
            Assert.AreEqual(correctArea, area);
        }

        
        [TestMethod]
        public void TriangleArea()
        {
            //arrange
            double a = 4;
            double b = 5;
            double c = 8;
            double p = (a + b + c) / 2;
            double correctArea = p * (p - a) * (p - b) * (p - c);

            //act
            double area = AreaOfShapes.Operation("Triangle",a,b,c);

            //assert
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void IsTriangeRight()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;

            //act
            bool isRight = AreaOfShapes.IsTriangleRight(a,b,c);

            //assert
            Assert.IsTrue(isRight);
        }
        [TestMethod]
        public void AddFigure()
        {
            //arrange
            double b = 3;
            double correctArea = b*b;

            //act
            AreaOfShapes.AddFigure("Square", new Func<double, double>((a) => a * a));
            double area = AreaOfShapes.Operation("Square", b);


            //assert
            Assert.AreEqual(correctArea, area);
        }
    }
}