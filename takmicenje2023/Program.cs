using System;
using System.Reflection.Metadata.Ecma335;
internal class Program
{

    private static void Main(string[] args)
    {
        int a, b, c = 0, poma, pomb, sumaa = 0, sumab = 0, n, pom = 1, broj, pomc, pomcc, brojac, drugiBroj, sumak = 0;
        int[] d;
        int[,] mat, rot;
        float srednjaVredonst;
        Console.WriteLine("Unesite a");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Unesite b");
        b = int.Parse(Console.ReadLine());


        // 1.1
        poma = a;
        pomb = b;
        for(int i = 0; i < 5; i++)
        {
            sumaa += a % 10;
            a /= 10;
            sumab += b % 10;
            b /= 10;
        }
        srednjaVredonst = (float) sumaa / 5;
        Console.WriteLine("\n\n*********** odgovor 1 ***********\n\n");
        Console.WriteLine("Srednja vrednost broja " + poma + " je " + srednjaVredonst);
        srednjaVredonst = (float) sumab / 5;
        Console.WriteLine("Srednja vrednost broja " + pomb + " je " + srednjaVredonst);


        //1.2
        a = poma;
        b = pomb;

        for(int i = 0; i < 5 ; i++)
        {
            n = a % 10 + b % 10;
            if (n > 9) n %= 10;
            c += n * pom;
            a /= 10;
            b /= 10;
            pom *= 10;
        }
        Console.WriteLine("\n\n*********** odgovor 2 ***********\n\n");
        Console.WriteLine(c);


        //1.3
        d = new int[10];
        pomc = c;
        pomcc = c;
        brojac = 0;
        
        for(int i = 9 ; i > 0; i-=2)
        {
            d[i] = c % 10;
            c/= 10;
            for (int j = 0; j < 5; j++)
            {
                broj = d[i];
                drugiBroj = pomc % 10;
                pomc /= 10;
                if (drugiBroj == broj)
                {
                    brojac++;
                }
            }
            pomc = pomcc;
            d[i - 1] = brojac;
            brojac = 0;
        }

        Console.WriteLine("\n\n*********** odgovor 3 ***********\n\n");
        for(int i= 0; i<10; i++)
        {
            Console.Write(d[i] + " ");
        }


        //1.4
        mat = new int[11, 10];
        Console.WriteLine("\n\n******** odgovor 4 ***********\n\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                mat[i, j] = d[j];
            pom = d[0];
            for (int j = 0; j < 9; j++)
                d[j] = d[j + 1];
            d[9] = pom;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                if ((i + j) >= 9) sumak += mat[i, j];
            mat[10, i] = sumak;
        }

        for (int i = 0; i < 11; i++)
        {
            for (int j = 0; j < 10; j++)
                Console.Write(mat[i, j] + "\t");
            Console.WriteLine();
        }

        //1.5
        Console.WriteLine("\n\n******** odgovor 5 ***********\n\n");
        rot = new int[10, 11];
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 11; j++)
                rot[i, j] = mat[j, 10 - 1 - i];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 11; j++)
                Console.Write(rot[i, j] + "\t");
            Console.WriteLine();
        }
    }
}