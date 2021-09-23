using System;

namespace p11_VectorSumas
{
    class Program
    {
        static void Main(string[] args)
        {
            int []v=new int[30];
            Random rnd=new Random();
            int np=0,nn=0,sp=0,sn=0;

            for(int i=0; i<v.Length; i++){
                v[i]=rnd.Next(-100,100);
                Console.Write($"{v[i]} ");
                if(v[i]>0){
                    np++;
                    sp += v[i];
                }else if(v[i]<0){
                    nn++;
                    sn += v[i];
                }
            }
            Console.WriteLine($"\npositivos {np} y la suma {sp}");
            Console.WriteLine($"\nnegativos {nn} y la suma {sn}");   
        }
    }
}