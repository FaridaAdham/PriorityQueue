using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ_Heap
{
    class Element
    {
        public int data;
        public int i;
        public int priority;

        public Element(int data, int priority,int index)
        {
            this.data = data;
            this.priority = priority;
            this.i = index;
        }

        public Element() { } 
    }
}
