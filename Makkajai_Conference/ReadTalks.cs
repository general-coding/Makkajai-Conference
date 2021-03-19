using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Makkajai_Conference
{
    public class ReadTalks
    {
        public static List<Talk> GetTalks(string fileName)
        {
            List<Talk> talks = new List<Talk>();

            try
            {
                using (StreamReader streamReader = new StreamReader(fileName))
                {

                    string line;
                    int duration;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            line = line.Trim();
                            string title = line.Substring(0, line.LastIndexOf(" ")).Trim().Trim('-').Trim();
                            string minuteString = line.Substring(line.LastIndexOf(" ") + 1).Trim();
                            string minutes = Regex.Replace(minuteString, @"[a-zA-Z]+", "");

                            if (ConferenceConfig.TALK_TYPE_LIGHTNING.Equals(minuteString))
                            {
                                duration = ConferenceConfig.TALK_TYPE_LIGHTNING_DURATION;
                            }
                            else
                            {
                                bool isSuccess = int.TryParse(minutes, out duration);

                                if (!isSuccess)
                                {
                                    Console.WriteLine("Line parse error.");
                                }
                            }

                            Talk talk = new Talk(title, duration);
                            talks.Add(talk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
            }

            return talks;
        }
    }
}
