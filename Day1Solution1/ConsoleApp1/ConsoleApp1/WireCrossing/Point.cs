using System;

namespace ConsoleApp1.WireCrossing {
    public class Point {
       public int X { get; }
       public int Y { get; }
       public int Z = 12;
       public bool IsSet = false;
      

       public Point(int x, int y) {
           X = x;
           Y = y;
       }

       public void PrintPoint() {
           Console.WriteLine("X = " + X);
           Console.WriteLine("Y = " + Y);
       }
       
    }
}