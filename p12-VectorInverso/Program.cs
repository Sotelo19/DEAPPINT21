using System;

namespace p12_VectorInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM=16;
            int[] A=new int[TAM];
            int[] B=new int[TAM];
            Random rnd=new Random();

            for(int i=0; i<A.Length;i++){
                A[i]=rnd.Next(1,100);
                B[15-i]=A[i];
            }
            Console.WriteLine("\nValores de A");imprime(A);
            Console.WriteLine("\nValores de B");imprime(B);
        }
        static void imprime(int[] v){
                for(int i=0; i<v.Length; i++){
                Console.WriteLine($"{v[i]} " );
                }
                Console.WriteLine(); 
                }
    }
}
