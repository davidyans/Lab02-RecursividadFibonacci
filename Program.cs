using System.Diagnostics;
using System;

namespace Lab02_RecursivoFibonacci;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch_rec = new Stopwatch();
        Stopwatch stopwatch_it = new Stopwatch();

        int n;
        
        do {
            Console.WriteLine("Introduzca el número de términos: ");
            n = int.Parse(Console.ReadLine());
        }while(n <= 1);

        Console.WriteLine("Serie de números de fibonnacci recursivo: ");
        
        // .........RECURSIVO..........
        stopwatch_rec.Start();
        for (int i = 0; i < n; i++)
        {
            Console.Write("  " + FibonacciRecursivo(i));
        }
        Console.WriteLine("\n"+"*** Recursivo -> Elapsed time: "+ stopwatch_rec.Elapsed.ToString() + " ***");
        stopwatch_rec.Stop();
        // ...................

        // .........ITERATIVO..........
        Console.WriteLine();
        Console.WriteLine("Serie de números de fibonnacci iterativo: ");
        
        stopwatch_it.Start();
        FibonacciIterativo(n);
        Console.WriteLine("\n"+"*** Iterativo -> Elapsed time: "+ stopwatch_it.Elapsed.ToString() + " ***");
        stopwatch_it.Stop();
        // ...................

    }

    static long FibonacciRecursivo(int n){
        if(n < 2) return n;
        else return FibonacciRecursivo(n-2) + FibonacciRecursivo(n-1);
    }

    static void FibonacciIterativo(int n){
        int ant1 = 0, ant2 = 1;
        int actual = 0;
        for (int i=1; i<=n; i++) { 
            Console.Write("  " + actual);
            actual = ant1 + ant2; 
            ant2 = ant1; 
            ant1 = actual; 
	    }
            Console.WriteLine();

    }
}