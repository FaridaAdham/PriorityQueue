using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ_Heap
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of elements you want : ");
            int size = Convert.ToInt16(Console.ReadLine());
            
            PriorityQueue q = new PriorityQueue(size);
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the value of element no " + i + 1);
                int data = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the priority of element no " + i + 1);
                int priority = Convert.ToInt16(Console.ReadLine());
                q.array[i] = new Element(data, priority, i);
                index = i;
                Console.WriteLine("index " + index);

            }
            q.heapsort(q.array);
            Console.WriteLine("1- Enqueue                 2-Dequeue");
            Console.WriteLine("Your choice : ");
            int choice = Convert.ToInt16(Console.ReadLine());
            if (choice == 1)
            {
                index++;
                Console.WriteLine("Enter the value of element no " + (index + 1));
                int data = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the priority of element no " + (index + 1));
                int priority = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("enqueuing at " + index);
                q.Enqueue(data, priority, index);
            }
            
            else if (choice == 2)
            {
                q.Dequeue();

            }
            else { }
            for (int i = 0; i < q.heapsize; i++)
            {
                Console.WriteLine("Priority : " + q.array.ElementAt(i).priority + " ,Value : " + q.array.ElementAt(i).data);

            }
            
            Console.ReadLine();
        }
    }
}
