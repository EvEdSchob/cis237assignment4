using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Queue<T>
    { 
        //Make node class
        protected class Node
        {
            public T Data { get; set; }

            public Node Next { get; set; }
        }

        //A couple of pointers to the head and the tail
        //of the linked list, as well as the size
        protected Node _head;
        protected Node _tail;
        protected int _size;

        public bool IsEmpty
        {
            get
            {
                //If head is null then there is nothing in the list.
                return _head == null;
            }
        }

        public int Size
        {
            get
            {
                return _size;
            }
        }

        public void AddToBack(T Data)
        {
            //Make a pointer to the tail called old tail
            Node oldTail = _tail;
            //Make a new node and assign it to the tail
            _tail = new Node();
            //Assign the data and set the next pointer
            _tail.Data = Data;
            _tail.Next = null;

            //Check to see if the list is empty. If so, make the head
            //point to the same location as the new tail
            if (IsEmpty)
            {
                _head = _tail;
            }
            //We need to to take the oldTail and make it's next
            //property point ot the tail that we just created
            else
            {
                oldTail.Next = _tail;
            }
        }

        public T RemoveFromFront()
        {
            //If it's empty throw an error
            if (IsEmpty)
            {
                throw new Exception("List is empty");
            }
            //Get the data to return
            T returnData = _head.Data;
            //Move the head pointer to the next node in the list
            _head = _head.Next;
            //Decrement the size of the list
            _size--;
            //Check to see if the list is now empty
            if (IsEmpty)
            {
                //If so set the tail to null
                _tail = null;
            }
            return returnData;
        }


        public void Display()
        {
            Console.WriteLine("The list is: ");
            //Setup a currentNode to walk the list
            //start it at the head node
            Node currentNode = _head;
            //Loop through the nodes until we hit null
            //which will signify the end of the list
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                //Move to next node
                currentNode = currentNode.Next;
            }
        }
    }
}
