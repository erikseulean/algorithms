using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestCommonAncestor
{
    public class TopDownApproach
    {
        private MyNode Head;
        #region constructor

        public TopDownApproach()
        {
            Head = new MyNode()
            {
                Value = 5,
                Left = new MyNode()
                {
                    Value = 3,
                    Left = new MyNode()
                    {
                        Value = 2,
                        Left = new MyNode()
                        {
                            Value = 1
                        }
                    },
                    Right = new MyNode()
                    {
                        Value = 4
                    }
                },
                Right = new MyNode()
                {
                    Value = 9,
                    Left = new MyNode()
                    {
                        Value = 8,
                        Left = new MyNode()
                        {
                            Value = 7
                        },
                        Right = new MyNode()
                        {
                            Value = 8
                        }
                    },
                    Right = new MyNode()
                    {
                        Value = 10,
                        Right = new MyNode()
                        {
                            Value = 11
                        }
                    }
                }
            };
        }

        public int GetNode(int first, int second)
        {
            return LCA(first, second, Head);
        }
        #endregion
        public int LCA(int first, int second, MyNode head)
        {
            if (first == head.Value || second == head.Value)
                return head.Value;
            bool left = check(head.Left, first);
            bool right = check(head.Right, second);
            if ((left && right) || (left == false && right == false))
                return head.Value;
            if (left  && right == false)
                return LCA(first, second, head.Left);
            if (left == false && right)
                return LCA(first, second, head.Right);
            else return -1;
        }

        public bool check(MyNode head, int value)
        {
            if (head == null) return false;
            if (head.Value == value) return true;
            return check(head.Right,value) || check(head.Left,value);
        }
 
    }
}
