using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.WireCrossing {
    public class Grid {
        List<Coordinate> occupideCoordinates = new List<Coordinate>();

        public void SetOccupideCoordinates(List<Point> wireCoordinates) {

            foreach (var point in wireCoordinates) {
                if (occupideCoordinates.Exists(coordinate => coordinate.GetX() == point.X)) {
                    occupideCoordinates.Find(coordinate => coordinate.GetX() == point.X).SetY(point.Y);

                }
                else {
                    occupideCoordinates.Add(new Coordinate(point.X, point.Y));
                }

            }
        }

        public List<Coordinate> GetCoordinates() {
            return occupideCoordinates;
        }
    }
}