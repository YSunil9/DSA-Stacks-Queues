namespace DSA_StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To StackAndQueue Operation!\n");
            //Stack obj = new Stack();
            //obj.Push(70);
            //obj.Push(30);
            //obj.Push(56);        
            //obj.display();
            //obj.Peak();
            //obj.Pop();
            //obj.display();
            //obj.Peak();
            //obj.Pop();
            //obj.display();
            //obj.Peak();
            //obj.Pop();
            //obj.display();
            
            Queue obj = new Queue();
            obj.Enqueue(56);
            obj.Enqueue(30);
            obj.Enqueue(70);
            Console.WriteLine("\nThe Elements Are Present In The Queue");
            obj.Display();
        }
    }
}