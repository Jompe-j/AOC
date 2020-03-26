
using System;
using System.IO;
namespace ConsoleApp1 {
    public class ProgramAlarm {

        public void ProgramAlarmTest() {
            // var ints = GetNumArray();
            int[] test = {1, 4, 5, 2, 1, 3, 3, 3, 99};

            IntCodeReader(test);
            
        }

        private static void IntCodeReader(int[] ints) {
            var position = 0;
            // var moves = 0;
            const int step = 4;
            var instruction = 0;
            // var program = ints.Clone();
            // TODO Do not modify array but create new.
            
            
            while (instruction != 99) {
                instruction = ints[position];

                if (instruction == 1) {
                    var tmpAdd = ints[position + 1];
                    tmpAdd += ints[position + 2];
                    ints[ints[position + 3]] = tmpAdd;
                }
                
                position += step;
                
            }

            foreach (var i in ints) {
               Console.WriteLine(i); 
            }
            

        }

        private static int[] GetNumArray() {
            const string textFile = @"c:\Tmp\input2.txt";
                return Array.ConvertAll(File.ReadAllText(textFile).Split(','), int.Parse);
            
        }
    }
}