using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DWAssignment2PROG2070;

/*
 * DAVID WAGNER
 * ASSIGNMENT 2
 * Unit tests for Triangle solver 
 * 
 * CREATED: 2/13/2017 1:30PM 
 * 
 * 
 * 
 * */
namespace DWAssignment2PROG2070.Tests
{


    [TestFixture]
    public class TriangleTest
    {
        //expected outcomes for string assert 
        string notTriangle = "These integers do not form a triangle!";
        string equilateral = "Your triangle is an equilateral triangle";
        string isosceles = "Your triangle is an isosceles triangle";
        string scalene = "Your triangle is a scalene triangle";

        //0,0,0 - not triangle
        [Test]
        public void EnterZerosShouldNotCreateTriangle()
        {
            //Arrange
            int a = 0;
            int b = 0;
            int c = 0;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(notTriangle, message);
        }

        //1,2,3 - Not Triangle
        [Test]
        public void Enter123ShouldNotCreateTriangle()
        {

            //Arrange
            int a = 1;
            int b = 2;
            int c = 3;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(notTriangle, message);
        }

        //2, 2, 2 - Equilateral
        [Test]
        public void Enter222ShouldReturnEquilateral()
        {
            //Arrange
            int a = 2;
            int b = 2;
            int c = 2;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(equilateral, message);
        }


        //4, 4, 7 - Isosceles 
        [Test]
        public void Enter448ShouldReturnIsosceles()
        {
            //Arrange
            int a = 4;
            int b = 4;
            int c = 7;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(isosceles, message);
        }

        //4, 7, 9 - Scalene 
        [Test]
        public void Enter479ShouldReturnScalene()
        {
            //Arrange
            int a = 4;
            int b = 7;
            int c = 9;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(scalene, message);
        }

        //4, 5, 9 - Not Triangle 
        [Test]
        public void Enter459ShouldNotCreateTriangle()
        {
            //Arrange
            int a = 4;
            int b = 5;
            int c = 9;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(notTriangle, message);
        }

        [Test]
        //-2, -2, -2 - Not Triangle
        public void EnterNegative222ShouldNotCreateTriangle()
        {
            //Arrange
            int a = -2;
            int b = -2;
            int c = -2;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(notTriangle, message);
        }

        [Test]
        //-0,-0,-0 Not Triangle
        public void EnterNegative000ShouldNotCreateTriangle()
        {
            //Arrange
            int a = -0;
            int b = -0;
            int c = -0;

            //Act
            string message = TriangleSolver.Analyze(a, b, c);

            //Assert
            StringAssert.Contains(notTriangle, message);
        }




    }
}
