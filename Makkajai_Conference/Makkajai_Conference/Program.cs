using System;
using System.Collections.Generic;

namespace Makkajai_Conference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Talk> talks = ReadTalks.GetTalks(ConferenceConfig.TALKS_FILE);

            OutputTalks.printTalks(talks);
            Console.WriteLine("--- End of list ---");

            List<List<Schedule>> schedules = ProcessTalks.scheduler(talks);
            Console.WriteLine("--- Processed talks ---");

            OutputTalks.printSchedule(schedules);

            Console.ReadKey();
        }
    }
}
