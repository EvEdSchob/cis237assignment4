using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Stack<T>
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

        public void AddToFront(T Data)
        {
            //Make a new variable to also reference the head of the list
            Node oldHead = _head;
            //Make a new node and assign it to the head variable
            _head = new Node();
            //Set the data on the new node
            _head.Data = Data;
            //Make the next property of the new node oint to the old head
            _head.Next = oldHead;
            //Increment the size of the list
            _size++;
            //Ensure that if we are adding an item to an empty list
            //that the tail will be 
            if (_size == 1)
            {
                _tail = _head;
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
