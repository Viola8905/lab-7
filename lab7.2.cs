using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab7._2
{
    class Program
    {
        static void printvec(double[] arr)
        {
            for (int j = 0; j < arr.GetLength(0); j++) //Як змінюються номери стовпців
            {
                Console.Write("{0,7:f}  ", arr[j]);
            }
            Console.WriteLine();
        }
        static void printMatrix(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    Console.Write("{0,7:f}  ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("введіть розмірність квадратної матриці: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[n, n];
            for (int i = 0; i < a.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < a.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if ((i + 1 + j + 1) % 2 == 0)
                    {
                        a[i, j] = a[i, j] + i + 1;
                    }
                    else
                    {
                        a[i, j] = a[i, j] + Math.Pow(j + 1, 2);
                    }
                }
            }
            printMatrix(a);

            double[] b = new double[a.GetLength(0)];
            double dob = 1;

            for (int i = 0; i < n; i++) //Як змінюються номери рядків
            {

                for (int j = 0; j < n; j++) //Як змінюються номери стовпців
                {
                    dob *= a[j, i];
                }
                b[i] = dob;
                dob = 1;
            }
            printvec(b);
            /*
            double tmp = 1;        // временная переменная для храненя проезведения элементов строки
            // добавление новых значений в результирующий массив
            for (int i = 1; i < a.Length; i++)
            {
                tmp = 1;
                for (int j = 1; j < a.Length; j++)
                {
                    tmp *= a[j, i];
                }
                b[i] = tmp;
            }
            */

            Console.WriteLine("вивід масиву:");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadLine();

            double maxValue = b[0];

            for (int i = 1; i < b.Length; i++)
            {
                if (b[i] < maxValue && b[i] % 2 == 0)
                {
                    maxValue = b[i];

                }

            }

            Console.WriteLine(maxValue);
            Console.ReadLine();
        }




    }
}
