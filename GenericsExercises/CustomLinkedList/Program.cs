using System;

namespace CustomLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.AddFirst("meow");
            list.AddLast("whole new perosn");
            list.AddLast("erg");
            Console.WriteLine(list.RemoveLast());
            Console.WriteLine(list.RemoveFirst());
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(string.Join(", " , list.ToArray()));
        }
    }
}
