using System;
using System.Diagnostics.CodeAnalysis;

namespace WiredBrainCoffee
{
    public class Program
    {

        static void Main(string[] args)
        {
            StackDoubles();
            StackString();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            stack.push(1.2);
            stack.push(2.8);
            stack.push(3.0);
            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.pop();
                Console.WriteLine($"Item : {item}");
                sum = +item;
            }
            Console.WriteLine($"Sum : {sum}");
        }
        private static void StackString()
        {
            var stack = new SimpleStack<string>();
            stack.push("Wired Coffee");
            stack.push("Kuldeep");
            stack.push("Aman");
            while(stack.Count > 0)
            {
                Console.WriteLine(stack.pop() );
            }
        }
    }
}