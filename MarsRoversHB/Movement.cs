using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoversHB
{
    public enum Directions { N, S, E, W }

    public class Movement
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public Movement()
        {
            X = Y = 0;
            Direction = Directions.N;
        }

        private void RotateLeft()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.W;
                    break;
                case Directions.S:
                    this.Direction = Directions.E;
                    break;
                case Directions.E:
                    this.Direction = Directions.N;
                    break;
                case Directions.W:
                    this.Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }

        private void RotateRight()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Direction = Directions.E;
                    break;
                case Directions.S:
                    this.Direction = Directions.W;
                    break;
                case Directions.E:
                    this.Direction = Directions.S;
                    break;
                case Directions.W:
                    this.Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }

        private void Move()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void StartMoving(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.Move();
                        break;
                    case 'L':
                        this.RotateLeft();
                        break;
                    case 'R':
                        this.RotateRight();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (this.X < 0 || this.Y < 0 || this.X > maxPoints[0]  || this.Y > maxPoints[1])
                {
                    throw new Exception($"Point is out of range, Range = (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
        }
    }
}

