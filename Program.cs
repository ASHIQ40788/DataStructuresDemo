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
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            //foreach(int n in list)
            //{
            //    Console.WriteLine(n);
            //}

            //UC1
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.InsertLast(56);
            customLinkedList.InsertLast(30);
            customLinkedList.InsertLast(70);


            Console.ReadLine();

        }
    }
}
