using System;

namespace VirusAtTheDisco
{
    class Program
    {
        static void Main()
        {
            int peopleAttendingDisco = 50;
            int hours = 0;

            InfectionAtDisco infectedDisco = new InfectionAtDisco(peopleAttendingDisco);

            ConsoleKeyInfo keyInfo;

            Console.WindowHeight = 16;

            bool runLoop = true;

            while (runLoop)
            {
                if (hours == 0)
                {
                    //Console.SetCursorPosition(0, 1);
                    Console.WriteLine("\n" + peopleAttendingDisco + " people are at a disco.");
                    Console.WriteLine("One person at the disco has a contagious virus...");

                }

                Console.WriteLine("\nEvery hour the virus will spread from one person with the virus to one other person without the infection.");
                Console.WriteLine("After five houers the infected person will become imune and stop spreading the virus.");

                Console.SetCursorPosition(0, Console.WindowHeight - 2);
                Console.WriteLine("Press \"N\" to go forward one hour. Press \"Q\" to quit the program.");

                keyInfo = Console.ReadKey();

                if (keyInfo.KeyChar == 'n')
                {
                    Console.Clear();
                    infectedDisco.NextHour();
                    hours++;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("Hours since the spread of infection started: " + hours);
                    Console.WriteLine("Persons Infected at the disco: " + infectedDisco.AllPersonsInfected);
                }
                else if (keyInfo.KeyChar == 'q')
                {
                    runLoop = false;
                }
            }
        }
    }
}