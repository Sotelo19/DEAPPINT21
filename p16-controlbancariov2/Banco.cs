using System.Collections.Generic;

namespace p15_controlbancario
{
    public class Banco{
        public Banco(string nombre, string direccion){
            this.nombre=nombre;
            this.direccion=direccion;
            clientes = new List<Cliente>();
        }

        public string nombre {get; private set;}
        public string direccion {get; private set;}
        public List<Cliente> clientes {get; private set;}
        public void AgregarCliente(Cliente cliente){
            clientes.Add(cliente);
        }

    }
}