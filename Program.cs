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
            customLinkedList.InsertLast(40); //40 requires for UC9,UC10
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
            //customLinkedList.InsertLast(56);
            //customLinkedList.InsertLast(70);
            //Console.WriteLine("before insertion:");
            //customLinkedList.InsertMiddle(30);
            //Console.WriteLine("after insertion:");
            //customLinkedList.Display();
            //Console.ReadLine();

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


            //UC8- Insert After in the linked list
            //Console.WriteLine("Linkedlist before insertion:");
            //customLinkedList.Display();
            //Console.WriteLine("\nInsert node:" + customLinkedList.InsertAfter(30));
            //customLinkedList.Display();
            //Console.ReadLine();

            //UC9-Deleting the Required Node from the Linked List.
            //Console.WriteLine("list before deletion:");
            //customLinkedList.Display();
            //customLinkedList.DeleteRequiredNode(40);
            //Console.WriteLine("list after deletion:");
            //Console.WriteLine("The size of the Linked List:" + customLinkedList.SizeofList());
            //customLinkedList.Display();
            //Console.ReadLine();

            //UC10- Ordered Linked List in ascending order
            customLinkedList.SortValue();
            customLinkedList.Display();
            Console.ReadLine();

        }
    }
}
