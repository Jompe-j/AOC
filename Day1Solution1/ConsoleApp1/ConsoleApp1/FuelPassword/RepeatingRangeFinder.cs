using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.FuelPassword {
    public class RepeatingRangeFinder {
        private List<int> _low;
        private int upper;
        public RepeatingRangeFinder(string lower, string upper) {
            _low = SetLow(lower);

        }

        private static List<int> SetLow(string low) {
            var lowList = low.Select(c => Convert.ToInt32(char.GetNumericValue(c))).ToList();
            lowList = SetNeverDecreasing(lowList);
            
            return lowList;
        }
        
        private static List<int> SetNeverDecreasing(List<int> lowList) {
            for (int i = 1; i < lowList.Count; i++) {
                if (lowList[i - 1] > lowList[i]) {
                    lowList[i] = lowList[i - 1];
                }
            }

            return lowList;
        }
    }
}