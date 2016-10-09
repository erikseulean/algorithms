using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewBit
{
    public class Books
    {
        public int Check(int[] array, int nrStudents)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            int left = 0;
            int right = sum;
            int max = 0;
            while (left <= right)
            {
                int mid = (left + right) >> 1;
                if (Possible(array, nrStudents, mid))
                {
                    right = mid - 1;
                    max = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return max;
        }

        public bool Possible(int[] array, int nrStudents, int sum)
        {
            int currSum = 0;
            int currentStudents = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > sum) return false;
                if (currSum + array[i] > sum)
                {
                    currentStudents++;
                    currSum = array[i];
                    if (currentStudents > nrStudents) return false;
                }
                else currSum += array[i];
            }

            return true;
        }
    }
}
