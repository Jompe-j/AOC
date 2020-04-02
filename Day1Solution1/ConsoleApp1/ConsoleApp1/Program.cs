using System.IO;
using ConsoleApp1.WireCrossing;

namespace ConsoleApp1 {
    class Program {
        private static void Main(string[] args) {
            // FuelHandler();
            //  ProgramAlarmHandler();
            WireHandler();
        }

        private static void WireHandler() {
             const string inputWires = @"c:\Tmp\input3.txt";
             var wires = File.ReadAllLines(inputWires);
            var test = new string[] {"R5,U4,L3,D2", "U4,R2,D1"};
            var test0 = new string[] {"R8,U5,L5,D3", "U7,R6,D4,L4"}; // 6 hit at 3, 3 and 6,5
            var test1 = new string[] {"R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62,R66,U55,R34,D71,R55,D58,R83"}; // 159
            var test2 = new string[]
                {"R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7"}; //135
            var intersectionCalculator = new IntersectionCalculator(wires);
             
            
            
            
            
            
            
            
            
        }

        private static void FuelHandler() {
            var totalFuel = new FuleCalculator();

            const string textFile = @"c:\Tmp\input1.txt";
            if (!File.Exists(textFile)) return;
            var lines = File.ReadAllLines(textFile);
            totalFuel.SimplePrintFuel(lines);
            totalFuel.PrintTotalFuel(lines);
        }


        private static void ProgramAlarmHandler() {
            var programAlarm = new ProgramAlarm();
            programAlarm.ProgramAlarmTest();
        }
    }
}