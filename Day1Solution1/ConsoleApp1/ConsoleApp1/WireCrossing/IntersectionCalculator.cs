using System;
using System.Collections.Generic;

namespace ConsoleApp1.WireCrossing {
    public class IntersectionCalculator {
        public IntersectionCalculator(string[] wires) {
            var wire1 = new Wire(wires[0]).GetAllCoordinates();
            var wire2 = new Wire(wires[1]).GetAllCoordinates();
            var coordlist = new List<Point>();
            int tmp = 10000000;
            int tmp2 = 10000000;
            foreach (var taken in wire1) {
                foreach (var point in wire2) {
                    if (taken.X == point.X && taken.Y == point.Y) {
                        var steps = taken.Steps + point.Steps;
                        Console.WriteLine($"Hit at {point.X}, {point.Y} ");
                        var distance = CalculateDistance(point.X, point.Y);
                        if (distance != 0 && distance < tmp ) {
                            tmp = distance;
                            coordlist.Add(point);
                        }

                        if (steps > 0 && steps < tmp2) {
                            tmp2 = steps;
                        }
                        
                    }
                }
            }
            Console.WriteLine(tmp);
            Console.WriteLine(tmp2);
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