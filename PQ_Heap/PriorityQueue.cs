using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ_Heap
{
    class PriorityQueue
    {
        public  int heapsize ;
       // public static List<Element> A ;
        public Element[] array ;

        public PriorityQueue()
        { }

        public PriorityQueue(int size)
        {
            heapsize = size;
            array = new Element[100];
        }


        public void Enqueue(int data, int priority, int index)
        {
            heapsize++;
            array[index] = new Element(data, priority,index);
            heapsort(array);
        }

        public Element Dequeue()
        {
            Element deleted = array[heapsize -1];
            heapsize--;
            heapsort(array);
            return deleted;

        }

        
        public  void maxheap(Element[] A, int index)
        {
            int left = 2 * index + 1;
            int right = 2 * index + 2;
            int largest;
            if (left < heapsize && A.ElementAt(left).priority > A.ElementAt(index).priority)
            {
                largest = left;
            }
            else { largest = index; }

            if (right < heapsize && A.ElementAt(right).priority > A.ElementAt(largest).priority)
            {
                largest = right;
            }
            if (left < heapsize && A.ElementAt(left).priority == A.ElementAt(index).priority && A.ElementAt(left).i < A.ElementAt(index).i)
            {
                largest = left;
            }
            if (right < heapsize && A.ElementAt(right).priority == A.ElementAt(largest).priority && A.ElementAt(right).i < A.ElementAt(largest).i)
            {
                largest = right;
            }

            if (largest != index)
            {
                swap(index, largest, A);
                maxheap(A, largest);
            }

        }

        public  void bulid_maxheap(Element[] A)
        {
            for (int i = heapsize / 2; i >= 0; i--)
            {
                maxheap(A, i);
            }
        }


        public void heapsort(Element[] A)
        {

            bulid_maxheap(A);
            int temp = heapsize;
            for (int i = heapsize - 1; i >= 1; i--)
            {
                swap(0, i, A);
                heapsize--;
                maxheap(A, 0);
            }
            heapsize = temp;
        }

        public  void swap(int index, int largest, Element[] A)
        {

            Element temp = A.ElementAt(largest);
            A[largest] = A[index];
            A[index] = temp;

        }

        

    }
}
