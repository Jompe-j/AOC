using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.FuelPassword {
    public class FuelPasswordCalculator {
        private List<List<int>> PossiblePasswords = new List<List<int>>();

        public void FindAllPossible(string low, string high) {
            var firstPossibility = SetLowRules(low);
            
            PossiblePasswords.Add(new List<int>(firstPossibility));

            while (LowerThanMax(PossiblePasswords.LastOrDefault())) {
                FindNextPw(firstPossibility);
            }

            HasRepeating(PossiblePasswords.FirstOrDefault());

            Console.WriteLine(PossiblePasswords.Count);
            
            foreach (var i in PossiblePasswords.LastOrDefault()) {
                Console.Write(i);        
            }
        }

        private bool LowerThanMax(List<int> lastOrDefault) {
            int result = 0;
            foreach (var i in lastOrDefault) {
                result = 10 * result + i;
            }

            if (result < 599999) {
                return true;
            }

            return false;
        }

        private void FindNextPw(List<int> previous) {
            var increase = 1;
            for (int i = 5; i >= 0; i--) {
                if (previous[i] >= 9) {
                    previous[i] = 0;
                }
                else {
                    previous[i] += increase;
                    increase = 0;
                }
            }

            if (HasRepeating(SetNeverDecreasing(previous))) {
                Console.WriteLine("test");
                PossiblePasswords.Add(new List<int>(previous));
            }
        }


        private List<int> SetLowRules(string low) {
            var lowList = new List<int>();
            foreach (var c in low) {
                lowList.Add(Convert.ToInt32(char.GetNumericValue(c)));
            }

            SetNeverDecreasing(lowList);
            // foreach (var i in lowList) {
            //     Console.WriteLine(i);
            // }

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

        private static bool HasRepeating(List<int> setNeverDecreasing) {
            for (int i = 0; i < 5; i++) {
                for (int j = i + 1; j < 6; j++) {
                    // Console.WriteLine($"Compare position {i} against {j}");
                    if (setNeverDecreasing[i] == setNeverDecreasing[j]) {
                        return true;
                    }
                }
            }

            // foreach (var i in setNeverDecreasing) {
            //     Console.Write(i);
            // }
            // Console.WriteLine();
            return false;
        }

        private static bool HasOnlyDoubleRepeating(List<int> numbersList) {
            var pairs = new List<List<int>>();

            for (int i = 1; i < 10; i++) {
                var pair = new List<int>();
                for (int j = 0; j < 6; j++) {
                    if (numbersList[j] == i) {
                       pair.Add(i); 
                    } 
                }
                pairs.Add(pair);
            }

            foreach (var pair in pairs) {
                if (pair.Count == 2) {
                    return true; 
                }
            }

            foreach (var i in numbersList) {
               Console.Write(i); 
            }
            Console.WriteLine();
            return false;

        }

        // It is a six-digit number.
        // The value is within the range 145810 - 612564.
        // Two adjacent digits are the same (like 22 in 122345).
        // Going from left to right, the digits never decrease; they only ever increase or stay the same (like 111123 or 135679).
    }
}