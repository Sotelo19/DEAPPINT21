namespace p15_controlbancario
{
    public class CuentaBancaria{
        public CuentaBancaria(){}
        public CuentaBancaria (float saldo){
            this.saldo=saldo;
        }
        public float saldo {get; private set;}

        public void deposita(float cantidad){
            saldo += cantidad;
            }
            
        public bool retira(float cantidad){
            if(cantidad<=saldo){
                saldo-=cantidad;
                return true;
            }
            else  return false;
        }
    }
}