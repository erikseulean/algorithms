using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardProblems
{
    public class MatrixElement{
        public int Index { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
    }
    public class BlackAndWhite
    {
        private int[,] matrix;

        public BlackAndWhite(int [,] matrix)
        {
            this.matrix = matrix;
        }

        public void StoreMatrix(int n)
        {
            List<MatrixElement> lines = new List<MatrixElement>(n);
            List<MatrixElement> rows =  new List<MatrixElement>(n);
            for (int i = 0; i < n; i++)
            {
                lines.AddRange(SetLines(i, n));
                rows.AddRange(SetRows(i, n));
            }

            foreach (var item in lines)
            {
                var oposite = lines.Where(s => s.Start >= item.Start && s.Length + s.Start < item.Length && s.Index >= item.Index && s.Index != item.Index);
                foreach (var elem in oposite)
                {
                    var row = rows.Where(s => s.Start >= item.Start && s.Length == item.Index - elem.Index);
                }
            }
        }

        public List<MatrixElement> GetOposites(int start, int currentLine, int length,int n,List<List<MatrixElement>> lines)
        {
            List<MatrixElement> elements = new List<MatrixElement>();
            for (int i = currentLine + 1; i < n; i++)
            {
                //elements.AddRange(lines[i].Where(s => s.Start >= start && s.Length + s.Start <= length));
            }
            return elements;
        }
        
        public List<MatrixElement> SetLines(int line, int n)
        {
            List<MatrixElement> lines = new List<MatrixElement>();
            int start = -1;
            int length = 0;
            for (int i = 0; i < n; i++)
            {
                if(matrix[line,i] == 1)
                {
                    length++;
                    if (start == -1)
                        start = i;
                }
                else
                {
                    if(start != -1)
                        lines.Add(new MatrixElement() { Start = start, Length = length, Index=line });
                    length = 0;
                    start = -1;
                }
            }
            if (start != -1)
                lines.Add(new MatrixElement() { Start = start, Length = length,Index = line });

            return lines;
        }

        public List<MatrixElement> SetRows(int row, int n)
        {
            List<MatrixElement> rows = new List<MatrixElement>();
            int start = -1;
            int length = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, row] == 1)
                {
                    length++;
                    if (start == -1)
                        start = i;
                }
                else
                {
                    if(start != -1)
                        rows.Add(new MatrixElement() { Start = start, Length = length, Index=row });
                    length = 0;
                    start = -1;
                }
            }

            if (start != -1)
                rows.Add(new MatrixElement() { Start = start, Length = length, Index=row });

            return rows;
        }
    }
}
