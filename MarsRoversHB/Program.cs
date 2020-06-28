using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRoversHB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lastPoint = new List<int>();

            while (lastPoint.Count() != 2)
            {
                lastPoint = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
                if (lastPoint.Count() != 2)
                {
                    Console.WriteLine("Upper-right coordinates is missing or incorrect, please try again");
                    lastPoint.Clear();
                }
            }

            while (!(Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                string[] firstPoint = null;
                while (firstPoint == null || firstPoint.Length != 3)
                {
                    firstPoint = Console.ReadLine().Trim().Split(' ');
                    if (firstPoint.Count() != 3)
                    {
                        Console.WriteLine("Initial coordinates is missing or incorrect, please try again");
                        firstPoint = null;
                    }
                }
                Movement move = new Movement();
                move.X = Convert.ToInt32(firstPoint[0]);
                move.Y = Convert.ToInt32(firstPoint[1]);
                move.Direction = (Directions)Enum.Parse(typeof(Directions), firstPoint[2]);
                string movementKeys = " ";
                movementKeys = Console.ReadLine().ToUpper();
                try
                {
                    move.StartMoving(lastPoint, movementKeys);
                    Console.WriteLine($"{move.X} {move.Y} {move.Direction}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
                
        }
    }
}
