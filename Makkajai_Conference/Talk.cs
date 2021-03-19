namespace Makkajai_Conference
{
    public class Talk
    {
        private readonly string title;
        private readonly int duration;

        internal Talk(string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }

        internal string getTitle()
        {
            return title;
        }

        internal int getDuration()
        {
            return duration;
        }
    }
}