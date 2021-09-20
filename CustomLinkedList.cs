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

        //UC4---->Insert Middle of the Linked list
        public void InsertMiddle(int new_data)
        {
            Node position = head;
            int length = 0;
            Node new_node = new Node(new_data);
            

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
        /// UC8-Insert a Node after Node
        /// </summary>
        /// <param name="exist_node"></param>
        /// <param name="new_data"></param>
        public void InsertAfter(int new_data, Node present_node)
        {
            if (present_node == null)
            {
                Console.WriteLine(" node not present");
                return;
            }
            //creating a new_node in the Linked List
            Node new_node = new Node(new_data);
            new_node.next = present_node.next;
            present_node.next = new_node;
        }


        /// <summary>
        /// UC9-delete node (40) from the Linked List sequence
        /// </summary>
        /// <param name="value"></param>
        public void DeleteRequiredNode(int val)
        {
            //In temp,Head node is stored
            Node previous = null;
            Node temp = head;


            //check for whether the  head node is holding the value or not.
            if (temp != null && temp.data == val)
            {
                head = temp.next;
            }
            //search for value to delete,also update previous node as temp.next
            while (temp != null && temp.data != val)
            {
                previous = temp;
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("node is not present which I was given");
            }
            //deleting the node. 
            previous.next = temp.next;
        }

        //finding size of the list
        public int SizeofList()
        {
            //pointing temp to the Head Node.
            Node temp = head;
            int c = 0;
            while (temp != null)
            {
                c++;
                temp = temp.next;
            }
            return c;
        }

        /// <summary>
        /// UC10- create Ordered Linked List in ascending order
        /// </summary>
        public void SortValue()
        {
            Node initialValue = null;
            Node temp = head;
            int Value = 0;

            //checking whether the temp isequalto null or not
            while (temp != null)
            {
                initialValue = temp.next;
                //checking whether the intialValue isequalto null or not
                while (initialValue != null)
                {

                    if (temp.data > initialValue.data)
                    {
                        Value = initialValue.data;
                        initialValue.data = temp.data;
                        temp.data = Value;
                    }
                    initialValue  = initialValue.next;
                    temp = temp.next;
                }
                Console.WriteLine("Sorted list");
            }
           
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
