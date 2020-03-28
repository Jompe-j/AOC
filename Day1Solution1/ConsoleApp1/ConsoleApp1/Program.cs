using System.IO;

namespace ConsoleApp1 {
    class Program {
        private static void Main(string[] args) {
            FuelHandler();
            ProgramAlarmHandler();
            WireHandler();
        }

        private static void WireHandler() {
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