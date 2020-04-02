using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.WireCrossing {
    public class IntersectionCalculator {
        public IntersectionCalculator(string[] wires) {
            var wire1 = new Wire(wires[0]).GetAllCoordinates();
            var wire2 = new Wire(wires[1]).GetAllCoordinates();
            var wire3 = new List<Point>();
            int tmp = 10000000;
            foreach (var taken in wire1) {
                foreach (var point in wire2) {
                    if (taken.X == point.X && taken.Y == point.Y) {
                        Console.WriteLine($"Hit at {point.X}, {point.Y}");
                        // var distance = CalculateDistance(point.X, point.Y);
                        // if (distance != 0 && distance < tmp ) {
                        //     wire3.Add(point);
                        //     tmp = distance;
                        // }
                    }
                }
            }
            Console.WriteLine(tmp);


            // var grid = new Grid();
            // grid.SetOccupideCoordinates(wire1);
            // var occupide = grid.GetCoordinates();
            //
            // foreach (var coordinate in occupide) {
            //     Console.WriteLine();
            //     Console.WriteLine($"X is: {coordinate.GetX()}");
            //     foreach (var i in coordinate.GetY()) {
            //         Console.Write($"Y is {i} ");
            //     }
            //     Console.WriteLine();
            // }
            // todo Get all the set coordinates from raw data. Then pupulate with second wire and return all intersectio

            //todo but 0,0.
        }

        private int CalculateDistance(in int pointX, in int pointY) {
            int tmpX = pointX;
            int tmpY = pointY;
            if (tmpX < 0) {
                tmpX = tmpX * -1;
            }

            if (tmpY < 0) {
                tmpY = tmpY * -1;
            }

            return tmpX + tmpY;
        }
    }
}