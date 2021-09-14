using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo058
{
    class CustomLinkedList
    {
        public Node head;
        public void InsertLast(int new_data)
        {
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted into List " + new_node.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }


        //UC 2
        public void InsertFront(int new_data)
        {
            //we will create a new node .The next of the new node will point to the head of the Linked List.
            Node new_node = new Node(new_data);
            //When we want to add any node at the frontt we want rge ahead to point to it.
            new_node.next  = this.head;
            //the previos head node is now the second node of Linked List because the new node is added at the front.
            this.head = new_node;
            Console.WriteLine("Inserted into List " + new_node.data);
        }

        public void Append(int new_data)
        {
            InsertFront(new_data);
        }

        public void Display()
        {
            Console.WriteLine("Displaying nodes");
            Node temp = this.head;
            if(temp == null)

                {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + "");
                    temp = temp.next;
                }
                
                //Console.Write(" " + temp.data);
            }
        }
    }
}

