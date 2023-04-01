using stackandqueue;

namespace LinkedListAsmnt
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack Problem");
            linkliststack linkedListStack = new linkliststack();
            linkedListStack.Push(6);
            linkedListStack.Push(60);
            linkedListStack.Push(90);
            linkedListStack.Display();
        }
    }
}
