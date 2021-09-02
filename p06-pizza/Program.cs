using System;
using static System.Console;

namespace p06_pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam, cub, lug;
            string[] ings;

            string tamaño, cubierta, lugar;
            string ingredientes="";

            if(args.Length<3){
              Menu();
              return 1;
            }
        //Tamaño
        tam = char.Parse(args[0]);
        if(tam=='P') tamaño="Pequeña";
        else if(tam=='M') tamaño="Mediana";
        else tamaño="Grande";

        //Ingredientes
        ings = args[1].Split("+");
        foreach( string i in ings){
            switch( char.Parse(i.ToUpper()))
       {
            case 'C' : ingredientes += "Champiñones"; break;
            case 'E' : ingredientes += "Extraqueso"; break;
            case 'P' : ingredientes += "Piña"; break;
            case 'T' : ingredientes += "Tomates"; break;
        }
        }
        //Cubierta 
        cub = char.Parse(args[2].ToUpper());
        if(cub =='D') cubierta = "Delgada"; else cubierta="Gruesa";

        //Lugar
        lug = char.Parse(args[3].ToUpper());
        lugar= (lug=='A' ? "Aqui" : "Llevar");

        WriteLine("Tu pizza es de tamaño: {0}",tamaño);
        WriteLine("Ingredientes: {0}",ingredientes);
        WriteLine("Cubierta: {0}", cubierta);
        WriteLine("Lugar: {0}", lugar);

        return 0;
    }
    static void Menu(){
        Clear();
        WriteLine("Tmaño: (P)equena , (M)ediana, (G)rande");
        WriteLine("Ingredientes: C hampiñones + E xtra queso + P iña + t omates");
        WriteLine("Cubierta: (D)elgada , (G)ruesa ");
        WriteLine("Donde: (A)qui , (L)levar");

    }
 }
}