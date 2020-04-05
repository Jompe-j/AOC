using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.WireCrossing {
    public class Wire {
        private readonly List<Point> _wireCoordinates = new List<Point> {new Point(0, 0, 0)};

        public Wire(string wireInput) {
            // SetCoordinates(wireInput);
            SetAllCoordinates(wireInput);
        }

        public List<Point> GetAllCoordinates() {
            return _wireCoordinates;
        }

        private void SetAllCoordinates(string wireInput) {
            var relativePosition = wireInput.Split(",");
            foreach (var position in relativePosition) {
                var direction = position[0];
                int.TryParse(position.Substring(1), out var amount);
                Point lastPoint;
                if (Equals(direction, 'U')) {
                    for (int i = 1; i <= amount; i++) {
                        lastPoint = _wireCoordinates.LastOrDefault();
                        var currentPoint = new Point(lastPoint.X, lastPoint.Y + 1, lastPoint.Steps + 1 );
                        _wireCoordinates.Add(currentPoint);
                    }
                }

                if (Equals(direction, 'D')) {
                    for (int i = 1; i <= amount; i++) {
                        lastPoint = _wireCoordinates.LastOrDefault();
                        var currentPoint = new Point(lastPoint.X, lastPoint.Y - 1, lastPoint.Steps + 1 );
                        _wireCoordinates.Add(currentPoint);
                    }
                }

                if (Equals(direction, 'L')) {
                    for (int i = 1; i <= amount; i++) {
                        lastPoint = _wireCoordinates.LastOrDefault();
                        var currentPoint = new Point(lastPoint.X - 1, lastPoint.Y, lastPoint.Steps + 1);
                        _wireCoordinates.Add(currentPoint);
                    }
                }

                if (Equals(direction, 'R')) {
                    for (int i = 1; i <= amount; i++) {
                        lastPoint = _wireCoordinates.LastOrDefault();
                        var currentPoint = new Point(lastPoint.X + 1, lastPoint.Y, lastPoint.Steps + 1);
                        _wireCoordinates.Add(currentPoint);
                    }
                }
            }
        }

        // private void SetCoordinates(string wireInput) {
        //     var relativePosition = wireInput.Split(",");
        //     foreach (var position in relativePosition) {
        //         var direction = position[0];
        //         int.TryParse(position.Substring(1), out var amount);
        //         var lastPoint = _wireCoordinates.LastOrDefault();
        //         if (Equals(direction, 'U')) {
        //             var currentPoint = new Point(lastPoint.X, lastPoint.Y + amount);
        //             _wireCoordinates.Add(currentPoint);
        //         }
        //
        //         if (Equals(direction, 'D')) {
        //             var currentPoint = new Point(lastPoint.X, lastPoint.Y - amount);
        //             _wireCoordinates.Add(currentPoint);
        //         }
        //
        //         if (Equals(direction, 'L')) {
        //             var currentPoint = new Point(lastPoint.X - amount, lastPoint.Y);
        //             _wireCoordinates.Add(currentPoint);
        //         }
        //
        //         if (Equals(direction, 'R')) {
        //             var currentPoint = new Point(lastPoint.X + amount, lastPoint.Y);
        //             _wireCoordinates.Add(currentPoint);
        //         }
        //     }
        // }
    }
}