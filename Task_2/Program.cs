namespace Task_5
{
    // Завдання 5
    // Написати програму, яка виводить на екран таблицю множення на k де k – номер варіанта
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.Write($"{a} * {i} + = {a * i} \n");
            Console.WriteLine();


        }
    }
}
