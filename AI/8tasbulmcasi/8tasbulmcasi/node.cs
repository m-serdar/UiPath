using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8tasbulmcasi
{
    class node
    {
        public List<node> childrenList = new List<node>();
        public int[] nodeState = new int[9];
        public int f, g, h;
        public node parent;

        public node(int[] _nodeState) //constructor
        {
            nodeState = _nodeState;
            parent = null;
        }

        public void hValue(int[] finalState) 
        {          
            h = 0;
            for (int i = 0; i < 9; i++)
            {
                int sonucIndex = Array.IndexOf(finalState, nodeState[i]);     /* h(n) = | x - p | + | y - q | where x and y are cell co-ordinates in the current state p and q are cell co-ordinates in the final state */
                int x = Math.Abs((i % 3) - (sonucIndex % 3));
                int y = Math.Abs((i / 3) - (sonucIndex / 3));
                h += x + y;
            }
            fValue();
        }

        public void fValue() // f(n) = g(n) + h(n)  g(n)=cost
        {
            f = g + h;
        }
    }
}
