using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo058
{
    class Program
    {
        static void Main(string[] args)
        {

            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(70);
            //list.AddFirst(30);
            //list.AddFirst(56);

            //foreach (int n in list)
            //{
            //    Console.WriteLine(n);
            //}

            //UC1
            CustomLinkedList customLinkedList = new CustomLinkedList();
            //customLinkedList.InsertLast(56);
            //customLinkedList.InsertLast(30);
            //customLinkedList.InsertLast(70);

            //UC2 Insert Front
            //customLinkedList.InsertFront(70);
            //customLinkedList.InsertFront(30);
            //customLinkedList.InsertFront(56);

            //UC3 append
            //customLinkedList.Append(56);
            //customLinkedList.Append(30);
            //customLinkedList.Append(70);

            customLinkedList.InsertAfter(70);
            customLinkedList.InsertAfter(30);
            customLinkedList.InsertAfter(56);
            customLinkedList.Display();
            Console.ReadLine();

        }
    }
}
