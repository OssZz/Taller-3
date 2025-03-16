using System;

class Program
{
    static void Main()
    {

        Console.Write("Ingrese el número a descomponer: ");
        int n = int.Parse(Console.ReadLine());

        
        int[,] mat = new int[50, 2];
        int tope = 0;
        mat[tope, 0] = n;
        int i;

        while (!EsPrimo(mat[tope, 0]))
        {
            for (i = 2; i <= mat[tope, 0]; i++)
            {
                if (mat[tope, 0] % i == 0)
                    break;
            }

            mat[tope, 1] = i;
            mat[tope + 1, 0] = mat[tope, 0] / i;
            tope++;
            mat[tope, 1] = mat[tope, 0];
        }

       
        string fac = n + " = ";
        for (i = 0; i <= tope; i++)
        {
            fac += mat[i, 1] + " x ";
        }

        
        fac = fac.Substring(0, fac.Length - 3);
        Console.WriteLine(fac);
    }

    static bool EsPrimo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= n / 2; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}
