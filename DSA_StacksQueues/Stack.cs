using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_StacksQueues
{
    internal class Stack
    {
        public Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine(node.id + " Added to stack\n");
        }
        public void display()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = this.top;
                Console.WriteLine("Stack Sequence:");
                while (temp != null)
                {
                    Console.WriteLine(temp.id);
                    temp = temp.next;
                }
            }
        }
    }
}