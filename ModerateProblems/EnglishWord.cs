using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModerateProblems
{
    public class EnglishWord
    {
        private Dictionary<int, string> set;

        public EnglishWord()
        {
            set = new Dictionary<int, string>();
            set.Add(1, "One");
            set.Add(2, "Two");
            set.Add(3, "Three");
            set.Add(4, "Four");
            set.Add(5, "Five");
            set.Add(6, "Six");
            set.Add(7, "Seven"); 
            set.Add(8, "Eight");
            set.Add(9, "Nine");
            set.Add(10, "Ten");
            set.Add(11, "Eleven");
            set.Add(12, "Twelve");
            set.Add(13, "Thirteen");
            set.Add(14, "Fourteen");
            set.Add(15, "Fifteen");
            set.Add(16, "Sixteen");
            set.Add(17, "Seventeen");
            set.Add(18, "Eighteen");
            set.Add(19, "Nineteen");
            set.Add(20, "Twenty");
            set.Add(30, "Thirty");
            set.Add(40, "Fourty");
            set.Add(50, "Fifty");
            set.Add(60, "Sixty");
            set.Add(70, "Seventy");
            set.Add(80, "Eighty");
            set.Add(90, "Ninty");
            set.Add(100, "Hundred");
            set.Add(1000, "Thousand");
        }

        private string Zecimals(int nr)
        {
            if (nr == 0)
                return string.Empty;
            if (nr < 20)
                return set[nr];
         
            int zecimal = (nr/10)*10;
            int rest = nr%10;

            string returnValue = set[zecimal];
            if (rest != 0)
                returnValue += set[rest];
            return returnValue;

        }

        private string Hundreds(int nr)
        {
            if (nr == 0)
                return String.Empty;
            if (nr < 100)
                return Zecimals(nr);
            if (nr%100 == 0)
                return set[nr/100] + " Hundred";
            int hundreds = nr/100;
            string rest = Zecimals(nr%100);

            return set[hundreds] + " Hundreds and " + rest;
        }

        private string Thousands(int nr)
        {
            if (nr/1000 == 0)
                return Hundreds(nr);
            int thousands = nr/1000;
            if (thousands < 100)
                return set[thousands] + " Thousands" + Hundreds(nr%1000);
            return Hundreds(thousands) + " Thousands" + Hundreds(nr%1000);
        }


        public void GetRepresentation(int nr)
        {
            Console.WriteLine(Thousands(nr));
        }
    }
}
