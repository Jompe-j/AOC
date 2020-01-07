using System;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        private static void Main(string[] args) {
            const string textFile = @"c:\Tmp\input1.txt";

            if (File.Exists(textFile)) {
                var lines = File.ReadAllLines(textFile);

                foreach (var line in lines) {
                   Console.WriteLine(line); 
                }
                
                
            }
            Console.WriteLine("Hello World!");
        }
    }
}