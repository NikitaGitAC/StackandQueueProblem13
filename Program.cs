using stackandqueue;

namespace LinkedListAsmnt
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stack Problem");
            linllistqueue obj = new linllistqueue();
            obj.Enqueue(56);
            obj.Enqueue(30);
            obj.Enqueue(70);
            Console.WriteLine("Element stored in queue is:-");
            obj.Display();
            Console.WriteLine("After Dequeue operation:");
            obj.Dequeue();
            Console.WriteLine("Element stored in queue is:-");
            obj.Display(); 

        }
    }
}
