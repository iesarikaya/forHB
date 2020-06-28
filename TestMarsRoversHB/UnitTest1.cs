using MarsRoversHB;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestMarsRoversHB
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Movement move = new Movement();
            move.X = 1;
            move.Y = 2;
            move.Direction = Directions.N;

            var lastPoint = new List<int>() { 5, 5 };
            var movementKeys = "LMLMLMLMM";

            move.StartMoving(lastPoint, movementKeys);

            var actualOutput = $"{move.X} {move.Y} {move.Direction}";
            var expectedOutput = "1 3 N";

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Test2()
        {
            Movement move = new Movement();
            move.X = 3;
            move.Y = 3;
            move.Direction = Directions.E;

            var lastPoint = new List<int>() { 5, 5 };
            var movementKeys = "MMRMMRMRRM";

            move.StartMoving(lastPoint, movementKeys);

            var actualOutput = $"{move.X} {move.Y} {move.Direction}";
            var expectedOutput = "5 1 E";

            Assert.Equal(expectedOutput, actualOutput);
        }


    }
}
