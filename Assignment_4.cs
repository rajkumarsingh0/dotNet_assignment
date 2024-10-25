using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Generic Storage Class");
                Console.WriteLine("2. Generic Pair Class");
                Console.WriteLine("3. Generic Calculator Class");
                Console.WriteLine("4. Generic Stack");
                Console.WriteLine("5. Generic Queue");
                Console.WriteLine("0. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GenericStorageClass();
                        break;
                    case "2":
                        GenericPairClass();
                        break;
                    case "3":
                        GenericCalculatorClass();
                        break;
                    case "4":
                        GenericStack();
                        break;
                    case "5":
                        GenericQueue();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        // 1. Generic Storage Class
        static void GenericStorageClass()
        {
            var intStorage = new Storage<int> { Item = 42 };
            Console.WriteLine($"Stored integer: {intStorage.Item}");

            var stringStorage = new Storage<string> { Item = "Hello, Generics!" };
            Console.WriteLine($"Stored string: {stringStorage.Item}");

            var doubleStorage = new Storage<double> { Item = 3.14 };
            Console.WriteLine($"Stored double: {doubleStorage.Item}");
        }

        // 2. Generic Pair Class
        static void GenericPairClass()
        {
            var pair1 = new Pair<int, string>(1, "One");
            pair1.PrintPair();

            var pair2 = new Pair<string, double>("Pi", 3.14159);
            pair2.PrintPair();
        }

        // 3. Generic Calculator Class
        static void GenericCalculatorClass()
        {
            var intCalculator = new Calculator<int>();
            Console.WriteLine($"Int Add: {intCalculator.Add(10, 5)}");
            Console.WriteLine($"Int Subtract: {intCalculator.Subtract(10, 5)}");
            Console.WriteLine($"Int Multiply: {intCalculator.Multiply(10, 5)}");
            Console.WriteLine($"Int Divide: {intCalculator.Divide(10, 5)}");

            var doubleCalculator = new Calculator<double>();
            Console.WriteLine($"Double Add: {doubleCalculator.Add(5.5, 3.3)}");
            Console.WriteLine($"Double Subtract: {doubleCalculator.Subtract(5.5, 3.3)}");
            Console.WriteLine($"Double Multiply: {doubleCalculator.Multiply(5.5, 3.3)}");
            Console.WriteLine($"Double Divide: {doubleCalculator.Divide(5.5, 3.3)}");
        }

        // 4. Generic Stack
        static void GenericStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Popped from stack: {stack.Pop()}");
            Console.WriteLine($"Top item in stack after pop: {stack.Peek()}");

            Console.WriteLine("All items in stack:");
            for (int i = 0; i < stack.Count; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }

        // 5. Generic Queue
        static void GenericQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            Console.WriteLine($"Dequeued from queue: {queue.Dequeue()}");
            Console.WriteLine($"Front item in queue after dequeue: {queue.Peek()}");

            Console.WriteLine("All items in queue:");
            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
    }

    //Class
    public class Storage<T>
    {
        public T Item { get; set; }
    }

    // Pair Class
    public class Pair<T1, T2>
    {
        public T1 First { get; }
        public T2 Second { get; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void PrintPair()
        {
            Console.WriteLine($"First: {First}, Second: {Second}");
        }
    }

    // 3. Calculator Class
    public class Calculator<T> where T : struct
    {
        public T Add(T a, T b) => (dynamic)a + (dynamic)b;
        public T Subtract(T a, T b) => (dynamic)a - (dynamic)b;
        public T Multiply(T a, T b) => (dynamic)a * (dynamic)b;
        public T Divide(T a, T b) => (dynamic)a / (dynamic)b;
    }

    // 4. Stack Class
    public class Stack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item) => _items.Add(item);
        public T Pop()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            var item = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }
        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            return _items[_items.Count - 1];
        }
        public int Count => _items.Count;

        public T this[int index] => _items[index];
    }

    // 5. Queue Class
    public class Queue<T>
    {
        private List<T> _items = new List<T>();

        public void Enqueue(T item) => _items.Add(item);
        public T Dequeue()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            var item = _items[0];
            _items.RemoveAt(0);
            return item;
        }
        public T Peek()
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return _items[0];
        }
        public int Count => _items.Count;

        public T this[int index] => _items[index];
    }




}
