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
        public Node prev_node;
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

        //UC3
        public void Append(int new_data)
        {
            InsertFront(new_data);
        }
        /// <summary>
        /// UC4
        /// </summary>
        /// <param name="new_data"></param>
        internal void InsertAfter(int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node Cannot be null");
                return;
            }
            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;
            prev_node.next = new_node;
        }


        /// <summary>
        /// UC 5 Delete first node from linked list
        /// </summary>
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;
        }

        /// <summary>
        /// UC6 Delete last node
        /// </summary>
   
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }

            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lastDeletedNode = newNode.next.data;
            newNode.next = null;
            return lastDeletedNode;
        }

        /// <summary>
        /// UC 7 search for particular node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public int Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\nNode is present ");
                    return value;
                }
                temp = temp.next;
            }
            return value;
        }

        /// <summary>
        /// Display values in Nodes.
        /// </summary>
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

