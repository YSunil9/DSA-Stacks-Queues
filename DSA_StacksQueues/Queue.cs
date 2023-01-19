using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_StacksQueues
{
    internal class Queue
    {
        Node first;
        Node last;
        public Queue()
        {
            this.first = this.last = null;
        }
        internal void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (this.last == null)
            {
                this.first = this.last = newNode;
            }
            else
            {
                this.last.next = newNode;
                this.last = newNode;
            }
            Console.WriteLine("{0} is inserted into Queue", data);
        }
        public void Display()
        {
            Node temp = this.first;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.id + "\n");
                temp = temp.next;
            }
        }
    }
}
