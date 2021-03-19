using System.Collections.Generic;

namespace Makkajai_Conference
{
    internal class TalkComparator : IComparer<Talk>
    {
        public int Compare(Talk x, Talk y)
        {
            if (x.getDuration() < y.getDuration())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}