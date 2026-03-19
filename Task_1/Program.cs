namespace ConsoleApp1
{
    // Завдання 1
    // Вивести на екран усі числа від нуля до введеного користувачем числа.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число: ");
            int a = int.Parse(Console.ReadLine());

            int i = 0;

            for (i = 1; i <=a; i++)
                {
                Console.WriteLine(i);
            }

        }
    }
}
