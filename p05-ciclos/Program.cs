using System;

namespace p05_ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op=0, c=0, s=0;

            if(args.Length==0){
                Menu();
                return 1;
            }
            op =int.Parse(args[0]);
            switch (op){
                case 1 : 
                    c=1; while(c<=100) { Console.Write("{0}",c++);  s += c; c++;}break;
                case 2:
                    c=100; do {  Console.Write("{0}",c);  s += c; c--;  }while(c>=1); break;
                case 3:
                 for(c=50; c<=200; c+=2){Console.Write("{0}",c); s += c; } break;
                 case 4:
                 for(c=99; c>=1; c-=2){Console.Write("{0}",c); s += c; } break;
                 case 5 : 
                 c=272; while(c>=40) { Console.Write("{0}",c);  s += c; c+=4;}break;


                default: Console.WriteLine("Opcion no Valida"); break;

                
            }
            Console.WriteLine("\nLa suma es {0}", s);
            return 0;
        }
        static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] 1 al 100 con while");
            Console.WriteLine("[2] 100 al 1 con do .. while");
            Console.WriteLine("[3] 50 al 200 los pares con for");
            Console.WriteLine("[4] 99 al 1 los impares con for");
            Console.WriteLine("[4] 272 al 40 decrementos con while");


        }
    }

}