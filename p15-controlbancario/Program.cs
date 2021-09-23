using System;

namespace p15_controlbancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco mibanco= new Banco ("Banco del norte SA de CV","privada las cumbres 117");
            CuentaBancaria cta1 = new CuentaBancaria();
            CuentaBancaria cta2 = new CuentaBancaria(100);
            CuentaBancaria cta3;
            cta3 = new CuentaBancaria(500);

            Cliente cte1 =new Cliente("Ernesto Sotelo");
            Cliente cte2 =new Cliente("fernando","sanchez");
            Cliente cte3 =new Cliente("luis","lopez");

            mibanco.AgregarCliente(cte1);
            mibanco.AgregarCliente(cte2);
            mibanco.AgregarCliente(cte3);
            mibanco.AgregarCliente(new Cliente("luisa","susa"));

            mibanco.clientes[3].cuenta = cta2;

            cte1.cuenta = cta1;
            cte2.cuenta = new CuentaBancaria(10000);
            cte3.cuenta = cte2.cuenta;
            
            
            //cta1.saldo = 10;
            //cta2.saldo = 20;
            //cta3.saldo = 40;
            cta1.deposita(10);
            cta2.deposita(20);
            cta3.deposita(40);

            bool retiro = cta1.retira(15);
            cte3.cuenta.retira(3000);

            if (!retiro) Console.WriteLine("no se pudo retirar");
            else Console.WriteLine("retiro exitoso");
        
            cta3.retira(120);

            Console.WriteLine($"El saldo de la cuenta 1 es {cta1.saldo}");
            Console.WriteLine($"El saldo de la cuenta 2 es {cta2.saldo}");
            Console.WriteLine($"El saldo de la cuenta 3 es {cta3.saldo}");

            Console.WriteLine($"Cliente 1 {cte1.nombre},{cte1.apeido} saldo rn cuenta {cte1.cuenta.saldo}");
            Console.WriteLine($"Cliente 2 {cte2.nombre},{cte2.apeido} saldo rn cuenta {cte2.cuenta.saldo}");
            Console.WriteLine($"Cliente 3 {cte3.nombre},{cte3.apeido} saldo rn cuenta {cte2.cuenta.saldo}");

            //Reporte de clientes del banco
            Console.WriteLine($"\nReporte de clientes del banco {mibanco.nombre}, {mibanco.direccion}");
            foreach (Cliente cte in mibanco.clientes)
            {
                Console.WriteLine($"Cliente 2 {cte.nombre},{cte.apeido} saldo en cuenta {cte.cuenta.saldo}");
            }
            Console.WriteLine($"Total de clientes {mibanco.clientes.Count}") ;

        }
    }
}
