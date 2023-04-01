using stackandqueue;

namespace LinkedListAsmnt
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack Problem");
            linkliststack linkedListStack = new linkliststack();
            linkedListStack.Push(56);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.Display();
            linkedListStack.Peek();

        }
    }
}
