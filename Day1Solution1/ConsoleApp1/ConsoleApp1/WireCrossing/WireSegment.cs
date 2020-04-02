using System;

namespace ConsoleApp1.WireCrossing {
    public class WireSegment {
        private Point Start { get; set; }
        private Point End { get; set; }
        

        public WireSegment(Point start, Point end) {
            Start = start;
            End = end;
        }

        public void PrintSegment() {
            Console.WriteLine($"Start point: {Start.X}" +
                              $"End point: {End.X}");
        }

    }
}