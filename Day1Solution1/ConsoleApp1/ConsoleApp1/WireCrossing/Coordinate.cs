using System.Collections.Generic;

namespace ConsoleApp1.WireCrossing {
    public class Coordinate {
        private int X { get; }
        private List<int> _y = new List<int>(); 

        public Coordinate(int x, int y) {
            X = x;
            _y.Add(y);
        }

        public int GetX() {
            return X;
        }

        public void SetY(int y) {
            if (!_y.Exists(yCoord => yCoord == y)) {
                _y.Add(y);
            } 
        }

        public List<int> GetY() {
            return _y;
        }
        
        
        
        
    }
}