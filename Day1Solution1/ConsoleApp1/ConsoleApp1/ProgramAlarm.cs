
using System;
using System.IO;
namespace ConsoleApp1 {
    public class ProgramAlarm {

        public void ProgramAlarmTest() {
            var ints = GetNumArray();
            /*
            int[] test1 = {1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50};
            int[] test2 = {1, 0, 0, 0, 99};
            int[] test3 = {2, 3, 0, 3, 99};
            int[] test4 = {2, 4, 4, 5, 99, 0};
            int[] test5 = {1, 1, 1, 4, 99, 5, 6, 0, 99};
            int[][] tests = {test1, test2, test3, test4, test5};

            foreach (var test in tests) {
                IntCodeReader(test);    
            }

            IntCodeReader(ints);
            */
            FindVerbNoun(ints);

        }

        private static void FindVerbNoun(int[] ints) {

            var result = 0;

            for (int verb = 0; verb < 100; verb++) {
                for (int noun = 0; noun < 100; noun++) {
                    int[] codeProgram = (int[]) ints.Clone();
                    VerbNounChanger(verb, noun, codeProgram);
                    IntCodeReader(codeProgram);
                    if (codeProgram[0] == 19690720) {
                       Console.WriteLine(codeProgram[0] +" Verb = " + verb + " Noun = " + noun); 
                      Console.WriteLine(100 * noun + verb); 
                    }
                }
            } 
        }

        private static void VerbNounChanger(in int verb, in int noun, int[] codeProgram) {
            codeProgram[1] = noun;
            codeProgram[2] = verb;
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
                    ints[ints[position + 3]] = Addition(ints, position);
                }
                
                if (instruction == 2) {
                    var tmpAdd = ints[ints[position + 1]];
                    tmpAdd *= ints[ints[position + 2]];
                    ints[ints[position + 3]] = tmpAdd;
                }
                
                
                position += step;
                
            }

            // foreach (var i in ints) {
            //    Console.Write(i + " "); 
            // }
            // Console.WriteLine();
            // Console.WriteLine(ints[0]);
            

        }

        private static int Addition(int[] ints, int position) {
            var tmpAdd = ints[ints[position + 1]];
            tmpAdd += ints[ints[position + 2]];
            return tmpAdd;
        }

        private static int[] GetNumArray() {
            const string textFile = @"c:\Tmp\input2.txt";
                return Array.ConvertAll(File.ReadAllText(textFile).Split(','), int.Parse);
            
        }
    }
}