using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class Numbers
    {
        public int Small { get; set; }
        public int Big { get; set; }
        public bool Overlapped { get; set; }
    }
    public class Overlapping
    {
        public List<Numbers> Check(List<Numbers> first, List<Numbers> second)
        {
            bool done;
            List<Numbers> final = new List<Numbers>();
            for(int i=0;i<first.Count;i++){
                for (int j = 0; j < second.Count; j++)
                {
                    if(second[i].Overlapped == false && CheckOverlap(first[i],second[j]))
                    {
                        second[i].Overlapped = true;
                        first[i].Overlapped = true;
                        Numbers nr = new Numbers();
                        nr.Small = Math.Min(first[i].Small, second[i].Small);
                        nr.Big = Math.Max(second[i].Big, first[i].Big);
                        final.Add(nr);
                    }
                   
                }
                if (!first[i].Overlapped) final.Add(first[i]);
            }

            for (int i = 0; i < second.Count; i++)
            {
                if (!second[i].Overlapped) final.Add(second[i]);
            }

            return final;
        }

        public List<Numbers> Check(List<Numbers> numbers, Numbers number)
        {
            Numbers initial = new Numbers() { Small = number.Small, Big = number.Big };
            List<Numbers> final = new List<Numbers>();
            foreach (var item in numbers)
            {
                if (CheckOverlap(item, number))
                {
                    number.Small = Math.Min(item.Small, number.Small);
                    number.Big = Math.Max(item.Big, number.Big);
                }
                else
                {
                    if((number.Small != initial.Small) && number.Big != initial.Big )
                    {
                        final.Add(new Numbers() { Small = number.Small, Big = number.Big });
                        number.Small = initial.Small;
                        number.Big = initial.Big;
                    }
                    final.Add(item);
                }
            }

            return final;
        }

        public bool CheckOverlap(Numbers first, Numbers second)
        {
            if ((first.Big > second.Small && first.Big < second.Big) || (second.Big > first.Small && second.Big < first.Big))
                return true;
            return false;
        }
    }
}
