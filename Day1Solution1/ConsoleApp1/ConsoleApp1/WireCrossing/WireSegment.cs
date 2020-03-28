namespace ConsoleApp1.WireCrossing {
    public class WireSegment {
        private Point Start { get; set; }
        private Point End { get; set; }
        
        public WireSegment(Point start, Point end) {
            Start = start;
            End = end;
        }

    }
}