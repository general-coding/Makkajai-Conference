namespace Makkajai_Conference
{
    public class ConferenceConfig
    {
        public static readonly string TALKS_FILE = @"C:\\talks.txt";

        public static readonly int MORNING_START_TIME = 9;
        //public static readonly int MORNING_END_TIME = 12;
        public static readonly int LUNCH_START_TIME = 12;
        //public static readonly int LUNCH_END_TIME = 13;
        public static readonly int AFTERNOON_START_TIME = 13;
        //public static readonly int AFTERNOON_END_TIME = 17;
        public static readonly int NETWORKING_START_TIME = 17;

        public static readonly string TALK_TYPE_LIGHTNING = "lightning";

        //IN MINUTES
        public static readonly int MORNING_SESSION_DURATION = 180;
        public static readonly int AFTERNOON_SESSION_DURATION = 240;
        public static readonly int TALK_TYPE_LIGHTNING_DURATION = 5;
        public static readonly int LUNCH_DURATION = 60;
        public static readonly int NETWORKING_DURATION = 60;

        public static readonly string LUNCH = "lunch";
        public static readonly string NETWORKING = "Networking event";
    }
}
