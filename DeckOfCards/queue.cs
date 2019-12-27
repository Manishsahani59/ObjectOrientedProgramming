using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming.DeckOfCards
{
    class Queue
    {
        Queue front;
        Queue rear;
        Queue next;
        string data;
        int length =0;

        public int Length()
        {
            return length;
        }
        public bool isEmpty()
        {
            return length == 0;
        }
        public void Enequeue(string data)
        {
            Queue NewData = new Queue();
            NewData.data = data;
            if (isEmpty())
            {
                front = NewData;
            }
            else {
                rear.next = NewData;
            }rear = NewData;
            length++;
            
        }
      
        public string Dequeue()
        {
            Queue current = front;
            if (isEmpty())
            {
                return null;
            }
            else
            {
                string data = current.data;
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }
                length--;
                return data;
            }
        }


        public void sort()
        {
            string temp;
            Queue current = front;
            Queue currenttonext;
            while (current.next != null)
            {
                currenttonext = current.next;
                while (currenttonext != null)
                {
                 

                    if ((current.data).CompareTo(currenttonext.data) > 0)
                    {
                        temp= current.data;
                        current.data = currenttonext.data;
                        currenttonext.data = temp;
                    }
                    currenttonext = currenttonext.next;
                }
                current = current.next;
            }
        }


        public void Display()
        {
            Queue current = front;
            while (current != null)
            {
                Console.Write(current.data +"\t");
                current = current.next;
            }
        }

    }
}
