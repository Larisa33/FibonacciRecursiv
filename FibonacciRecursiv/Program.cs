namespace FibonacciRecursiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Scrieti numarul de elemente ale sirului Fibonnaci: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Sirul este: ");
            Fibonacci.Generate(n);
        }
    }
}