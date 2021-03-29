using System;

namespace lab77._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("розмірність матриці: ");
            int r = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[r, r];
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < matrix.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }
            int[] b = new int[r];
            for(int i = 0; i < b.Length; i++)
            {
                b[i] = random.Next(-10, 10);
            }

            for (int i = 0; i < matrix.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //Як змінюються номери стовпців
                {

                    matrix[i, j] *= b[j];
                }
            }
            int[] c = new int[r];

            for (int i = 0; i < r; i++)
            {
                int summa = 0;
                for (int j = 0; j < r; j++)
                {
                    summa += matrix[i, j];
                }
                c[i] = summa;
            }
            Console.WriteLine(c);
        }
    }
}
