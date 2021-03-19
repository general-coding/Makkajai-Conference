using System;
using System.Collections.Generic;

namespace Makkajai_Conference
{
    public class ProcessTalks
    {
        public static List<List<Schedule>> scheduler(List<Talk> talks)
        {
            List<Schedule> schedules = new List<Schedule>();
            List<List<Schedule>> days = new List<List<Schedule>>();

            talks.Sort((a, b) => a.getDuration().CompareTo(b.getDuration()));

            DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                , ConferenceConfig.MORNING_START_TIME, 0, 0);
            int time = 0;

            List<int> sessions = new List<int>
            {
                ConferenceConfig.MORNING_SESSION_DURATION,
                ConferenceConfig.AFTERNOON_SESSION_DURATION
            };

            List<string> breaks = new List<string>()
            {
                ConferenceConfig.LUNCH,
                ConferenceConfig.NETWORKING
            };

            int i = 0;

            foreach (Talk talk in talks)
            {
                if (i > 1 || talk == null)
                {
                    dateTime = dateTime.AddMinutes(sessions[i] - time);
                    schedules.Add(new Schedule(breaks[1], dateTime, 60));
                    dateTime = dateTime.AddMinutes(60);
                    days.Add(schedules);
                }
                else if (time <= sessions[i] && remainingTime(sessions[i], time, talk.getDuration()))
                {
                    schedules.Add(new Schedule(talk.getTitle(), dateTime, talk.getDuration()));
                    dateTime = dateTime.AddMinutes(talk.getDuration());
                    time = time + talk.getDuration();
                }
                else
                {
                    dateTime = dateTime.AddMinutes(sessions[i] - time);
                    schedules.Add(new Schedule(breaks[i], dateTime, 60));
                    dateTime = dateTime.AddMinutes(60);
                    i++;

                    if (breaks[i - 1] == ConferenceConfig.NETWORKING)
                    {
                        days.Add(schedules);
                        i = 0;
                        schedules = new List<Schedule>();
                        dateTime = dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                                    , ConferenceConfig.MORNING_START_TIME, 0, 0);
                    }

                    time = 0;
                }
            }

            return days;
        }

        private static List<Schedule> clearSchedules(List<Schedule> schedules)
        {
            schedules.Clear();

            return schedules;
        }

        private static bool remainingTime(int totalTime, int processTimed, int talkDuration)
        {
            bool hasTime = false;

            if (talkDuration <= (totalTime - processTimed))
            {
                hasTime = true;
            }

            return hasTime;
        }
    }
}
