using System;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        private static void Main(string[] args) {
            const string textFile = @"c:\Tmp\input1.txt";
            var sum = 0.0d;
            if (File.Exists(textFile)) {
                var lines = File.ReadAllLines(textFile);

                foreach (var line in lines) {
                    if (int.TryParse(line, out var number)) {
                        sum += (Math.Floor(d: (double) (number / 3)) - 2);
                        Console.WriteLine(sum);
                    }
                }
            }
        }
    }
}