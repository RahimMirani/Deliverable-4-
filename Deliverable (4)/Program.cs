namespace Deliverable__4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 0; i < fibonacci.Length; i++)
            {
                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
                }
            }

            foreach(int number in fibonacci)
            {
                Console.WriteLine(number);
            }
        }
    }
}