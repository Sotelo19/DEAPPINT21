using System;

namespace p10_VectorCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=20;
            double[] A = new double[TAM];
            double[] B = new double[TAM];
            Random rnd = new Random();

            for (int i=0; i<A.Length; i++){
                A[i]=rnd.Next(1,100);
                B[i]=Math.Pow(A[i],3);
            }
            Console.WriteLine($"\nElementos de A: ");imprime(A);
            Console.WriteLine($"\nElementos de B: ");imprime(B);
        }
        static void imprime(double[] v){
                for(int i=0; i<v.Length; i++)
                {
                Console.Write($"{v[i]} ");
                }
                Console.WriteLine(); 
        }
    }
}

