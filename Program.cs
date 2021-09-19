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
            customLinkedList.InsertLast(56);
            customLinkedList.InsertLast(30);
            customLinkedList.InsertLast(70);

            //UC2 Insert Front
            //customLinkedList.InsertFront(70);
            //customLinkedList.InsertFront(30);
            //customLinkedList.InsertFront(56);

            //UC3 append
            //customLinkedList.Append(56);
            //customLinkedList.Append(30);
            //customLinkedList.Append(70);

            //UC4 Insert Middle
            //customLinkedList.Display();
            customLinkedList.InsertMid(56);
            customLinkedList.InsertMid(30);
            customLinkedList.InsertMid(70);
            customLinkedList.Display();
            Console.ReadLine();

            //UC5 delete 1st node

            //customLinkedList.Display();
            //Console.WriteLine("\nDeleted node:" + customLinkedList.DeleteFirstNode());
            //customLinkedList.Display();
            //Console.ReadLine();

            //UC6 Delete last node
            //customLinkedList.Display();
            //Console.WriteLine("\nDeleted node:" + customLinkedList.DeleteLastNode());
            //customLinkedList.Display();
            //Console.ReadLine();

            //UC7 Search for a Node
            //customLinkedList.Display();
            //Console.WriteLine(customLinkedList.Search(30));
            //Console.ReadLine();


           
            Console.WriteLine("Linkedlist before insertion:");
            customLinkedList.Display();
            Console.WriteLine("\nInsert node:" + customLinkedList.InsertAfter(30));
            customLinkedList.Display();
            Console.ReadLine();







        }
    }
}
