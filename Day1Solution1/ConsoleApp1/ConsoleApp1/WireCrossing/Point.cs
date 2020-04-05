using System;

namespace ConsoleApp1.WireCrossing {
    public class Point {
       public int X { get; }
       public int Y { get; }
       public int Steps ;
      

       public Point(int x, int y, int steps) {
           X = x;
           Y = y;
           Steps = steps;
       }

       public void PrintPoint() {
           Console.WriteLine("X = " + X);
           Console.WriteLine("Y = " + Y);
       }
       
    }
}