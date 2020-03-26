using System;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        private static void Main(string[] args) {
        
            var totalFuel = new FuleCalculator();
            const string textFile = @"c:\Tmp\input1.txt";
            if (File.Exists(textFile)) {
                var lines = File.ReadAllLines(textFile);
                totalFuel.SimplePrintFuel(lines);
                totalFuel.PrintTotalFuel(lines);            
            }

       
        }
    }
}