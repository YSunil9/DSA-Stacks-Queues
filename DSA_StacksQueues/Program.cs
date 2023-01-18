namespace DSA_StacksQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To StackAndQueue Operation!\n");
            Stack obj = new Stack();
            obj.Push(70);
            obj.Push(30);
            obj.Push(56);
            obj.display();
        }
    }
}