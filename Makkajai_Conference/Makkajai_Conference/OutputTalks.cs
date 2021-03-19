using System;
using System.Collections.Generic;

namespace Makkajai_Conference
{
    public class OutputTalks
    {
        public static void printTalks(List<Talk> talks)
        {
            foreach (Talk talk in talks)
            {
                Console.WriteLine(talk.getTitle() + " " + talk.getDuration());
            }
        }

        public static void printSchedule(List<List<Schedule>> schedules)
        {
            for (int i = 0; i < schedules.Count; i++)
            {
                Console.WriteLine("Track" + (i + 1) + ":");
                foreach (Schedule schedule in schedules[i])
                {
                    Console.WriteLine(schedule.getStartTime()
                        + " " + schedule.getTitle()
                        + " " + schedule.getDuration());
                }
            }
        }
    }
}
