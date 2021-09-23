namespace p15_controlbancario{
    public class Cliente{
        public Cliente(string nombre, string apeido){
            this.nombre=nombre;
            this.apeido=apeido;
        }

        public string nombre {get; private set;}
        public string apeido {get; private set;}
        public CuentaBancaria cuenta {get;set;}
    }
}