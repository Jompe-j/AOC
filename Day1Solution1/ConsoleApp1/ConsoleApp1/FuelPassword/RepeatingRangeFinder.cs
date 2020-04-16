using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.FuelPassword {
    public class RepeatingRangeFinder {
        private List<int> _low = new List<int>();
        private List<List<int>> _possible = new List<List<int>>();
        private List<int> _upper  = new List<int>();

        public RepeatingRangeFinder(string lower, string upper) {
            _low = SetLow(lower);
            _possible.Add(_low);
            
            _upper = SetHigh(upper);

            foreach (var i in _low) {
                Console.Write(i);
            }
            Console.WriteLine();

            foreach (var i in _upper) {
               Console.Write(i); 
            } 
            
        }
        

        private List<int> SetHigh(string upper) {
            var highList = upper.Select(c => Convert.ToInt32(char.GetNumericValue(c))).ToList();
             return SetNeverDecreasingHigh(highList);
            
        }

        private List<int> SetNeverDecreasingHigh(List<int> highList) {
            for (var i = 1; i < highList.Count; i++) {
                if (highList[i - 1] > highList[i] ) {
                    highList[i - 1] = highList[i - 1] - 1;
                    highList[i] = 9;
                }
            }

            return highList;
        }

        private static List<int> SetLow(string low) {
            var lowList = low.Select(c => Convert.ToInt32(char.GetNumericValue(c))).ToList();

            lowList = SetNeverDecreasing(lowList);
            
            return lowList;
        }

        private static List<int> SetNeverDecreasing(List<int> lowList) {
            for (var i = 1; i < lowList.Count; i++) {
                if (lowList[i - 1] > lowList[i]) {
                    lowList[i] = lowList[i - 1];
                }
            }

            return lowList;
        }
    }
}