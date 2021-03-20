using System;

namespace lab7._1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Кількість рядків: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кількість стовпців: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[r, c];
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < matrix.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    matrix[i, j] = random.Next(-10, 10);
                }
            }

            int result = 0;
            int[,] matrix2 = new int[r, c];
            for (int i = 0; i < matrix.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < matrix.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if (matrix[i, j] < 0 && (i + j) % 2 == 0)
                    {
                        matrix2[i, j] = matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < matrix2.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < matrix2.GetLength(1); j++) //Як змінюються номери стовпців
                {

                    result += matrix2[i, j];
                }
            }
            Console.Write("suma=", result);
        }
    }
}
