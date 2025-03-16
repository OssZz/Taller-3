using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine());


        int[,] mat = new int[n, n];
        int sum = 0, may = int.MinValue, men = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = (i + 1) - j;
                Console.Write(mat[i, j] + "\t");

                sum += mat[i, j];

                if (mat[i, j] > may)
                    may = mat[i, j];

                if (mat[i, j] < men)
                    men = mat[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nLa sumatoria es: " + sum);
        Console.WriteLine("El valor máximo es: " + may);
        Console.WriteLine("El valor mínimo es: " + men);

        Console.ReadKey();
    }
}
