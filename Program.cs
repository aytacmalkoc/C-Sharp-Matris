using System;

namespace C_Sharp_Matris
{
    class Program
    {
        static void setColorGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        static void resetColor()
        {
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            int[,] dizi = new int[3, 3];
            int det = 0;

            Console.Title = "C# Matris Generator v1.0";

            setColorGreen();
            Console.WriteLine("   ---------------------------------   ");
            Console.Write("--- Welcome to matris generator v1.0 ---\n");
            Console.WriteLine("   ---------------------------------   \n");
            Console.WriteLine("@author: Aytac Malkoc - <iletisim@aytacmalkoc.com.tr>\n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resetColor();
                    Console.Write("value of ");
                    setColorGreen();
                    Console.Write("[{0}],[{1}]: ", i, j);
                    resetColor();
                    dizi[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Generated Matris: \n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" {0} ", dizi[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Transpoze: \n");
            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 3; m++)
                    Console.Write(" {0} ", dizi[m, k]);
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
                det += (dizi[0, i] * dizi[1, (i + 1) % 3] * dizi[2, (i + 2) % 3] - dizi[1, (i + 2) % 3] * dizi[2, (i + 1) % 3]);

            Console.Write("Detarminant: {0}", det);

            Console.Read();
        }
    }
}
