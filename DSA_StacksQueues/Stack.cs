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
            Console.WriteLine(node.id + " Added to stack");
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
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine(" Deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is deleted from stack", top.id);
            top = top.next;
        }
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is on the top of the stack", top.id);
        }
    }
}