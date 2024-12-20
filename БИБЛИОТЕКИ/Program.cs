using _1;
namespace БИБЛИОТЕКИ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = 8; 
            int m = 3; 
            int[,] mas1 = new int[n, m];

            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Строка {i + 1}: ");
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    if (j < input.Length)
                    {
                        mas1[i, j] = int.Parse(input[j]);
                    }
                }
            }
            int result = Mas1Op.Summa(mas1);
            Console.WriteLine($"Сумма элементов матрицы, кратных 3: {result}");
        }
    }
}