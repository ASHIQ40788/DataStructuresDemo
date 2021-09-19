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
            Node new_node = new Node(new_data);//created object
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
            //When we want to add any node at the front we want  a head to point to it.
            new_node.next = this.head;
            //the previous head node is now the second node of Linked List because the new node is added at the front.
            this.head = new_node;
            Console.WriteLine("Inserted into List " + new_node.data);
        }

        //UC3
        // Append--->used to add or append a string value of an object to the end 
        public void Append(int new_data)
        {
            InsertFront(new_data);
        }
        /// <summary>
        /// UC4 Insert Middle in Linked List
        /// </summary>
        /// <param name="new_data"></param>
        //internal Node InsertAtParticularPosition(int position, int data)
        //{
        //    if (position < 1)
        //    {
        //        Console.WriteLine("Invalid Position");
        //    }
        //    if (position == 1)
        //    {
        //        var newNode = new Node(data);
        //        newNode.next = this.head;
        //        head = newNode;
        //    }
        //    else
        //    {
        //        while (position-- != 0)
        //        {
        //            if (position == 1)
        //            {
        //                Node node = new Node(data);
        //                node.next = this.head;
        //                head.next = node;
        //                break;
        //            }
        //            head = head.next;
        //        }
        //        if (position != 1)
        //            Console.WriteLine("Position out of range");
        //    }
        //    return head;

        //}
        
        // UC4-Insert Middle in the LinkedList
        public void InsertMid(int new_data)
        {
            Node new_node = new Node(new_data);
            Node position = head;
            int length = 0;

            //calculate length of the linked list
            while (position != null)
            {
                length++;
                position = position.next;

            }

            //finding the mid position in the linked list
            int count = ((length % 2) == 0) ? (length / 2) : (length + 1) / 2;
            position = head;

            //position is the pointer to the node after which the new_node to be inserted in the linked list.
            while (count-- > 1)
            {
                position = position.next;
            }
            new_node.next = position.next;
            position.next = new_node;
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
                this.head = this.head.next;  //this head must move next(means reference of next node) before delete
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
                if (temp == null)

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
