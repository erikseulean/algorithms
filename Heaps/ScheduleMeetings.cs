using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    public class Meeting
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Meeting(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
    public class ScheduleMeetings
    {
        public int MeetingsRoomCount(List<Meeting> meetings)
        {
            List<int> rooms = new List<int>();
            int nrRooms = 1;
            meetings.Sort(new Comparator());
            rooms.Add(meetings[0].End);
            int max = 0;
            bool found = false;
            for (int i = 1; i < meetings.Count; i++)
            {
                for (int j = 0; j < rooms.Count; j++)
                    if (rooms[j] <= meetings[i].Start)
                    {
                        if(rooms[j] <= rooms[max])
                            max = j;
                        found = true;
                    }
                if (found) rooms[max] = meetings[i].End;
                else rooms.Add(meetings[i].End);
                found = false;
                max = 0;
            }

            return nrRooms;
        }

    }

    public class Comparator : IComparer<Meeting>
    {

        public int Compare(Meeting m1, Meeting m2)
        {
            if (m1.Start > m2.Start)
                return 1;
            if (m1.Start < m2.Start)
                return -1;
            return 0;
        }
    }

    public class HeapRemade
    {
        int[] array;
        int index = 1;
        public HeapRemade(int nrMeetings)
        {
            array = new int[nrMeetings+1];
        }

        public void Add(int nr)
        {
            array[index] = nr;
            int parent = index/2;
            int old = index;
            index++;
            while (parent != 0 && array[parent] > array[old])
            {
                int aux = array[parent];
                array[parent] = array[old];
                array[old] = aux;

                old = parent;
                parent = parent / 2;
            }
        }

        public int Peek()
        {
            return array[1];
        }

        public void ModifyHeapRoot(int nr)
        {
            array[1] = nr;
            int location = 1;
            while (
                (location * 2 < array.Length && array[location] > array[location * 2] && array[location * 2] != 0) || 
                (location * 2 + 1 < array.Length && array[location] > array[location * 2 + 1] && array[location * 2 + 1] != 0))
            {
                if (array[location * 2] > array[location * 2 + 1] && array[location * 2 +1] != 0)
                {
                    int aux = array[location * 2 + 1];
                    array[location * 2 + 1] = array[location];
                    array[location] = aux;
                    location = location * 2 + 1;
                }
                else
                {
                    int aux = array[location * 2];
                    array[location * 2] = array[location];
                    array[location] = aux;
                    location = location * 2;
                }
            }
        }
    }
}
