using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.FuelPassword {
    public class Password {
        private readonly List<int> _numbers;

        public Password(string input) {
            _numbers = input.Select(c => Convert.ToInt32(char.GetNumericValue(c))).ToList();
        }

        public List<int> GetNext(List<int> current) {
            SetNeverDecreasing(current);


            return nextPwd;
        }

        private void SetNeverDecreasing(List<int> current) {
            for (var i = 1; i < current.Count; i++) {
                if (current[i - 1] > current[1]) { }
            }
        }


        public void PrintPassword() {
            foreach (var i in _numbers) {
                Console.Write(i);
            }
        }
    }
}