using System;
using System.IO;

namespace ConsoleApp1 {
    public class FuleCalculator {
        public void SimplePrintFuel(string[] lines) {
            var sum = 0.0d;
            foreach (var line in lines) {
                if (int.TryParse(line, out var number)) {
                    sum += (Math.Floor((double) (number / 3)) - 2);
                }
            }
            Console.WriteLine(sum);
        }

        public void PrintTotalFuel(string[] lines) {
            var sum = 0.0d;
            foreach (var line in lines) {
                if (int.TryParse(line, out var number)) {
                    sum += CalcModuleFule((double) number);
                    
                }
            }
            Console.WriteLine(sum);
        }
        private double CalcModuleFule(double input) {
        Console.WriteLine("Calc module");
        var sum = 0.0d;
        var tmp = input;
        do {
            tmp = (Math.Floor(tmp / 3 - 2));
            if (tmp > 0) {
                sum += tmp;
            } 
        } while (tmp > 0);        
        return sum;
        }

    }
}