using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Meeting> meetings = new List<Meeting>();
            meetings.Add(new Meeting(1, 2));
            meetings.Add(new Meeting(3, 4));
            meetings.Add(new Meeting(4, 10));
            meetings.Add(new Meeting(5, 7));
            meetings.Add(new Meeting(2, 5));
            ScheduleMeetings sm = new ScheduleMeetings();
            sm.MeetingsRoomCount(meetings);
            
            Console.ReadLine();
        }
    }
}
