using System;

namespace cuenta
{
    public class CuentaPeso : cuentaBase
    {
           
        private int capital;

        public override int Capital { get => Capital; set => Capital = value; }

        public CuentaPeso(int capital):base(capital){
            this.capital = capital;
        }

        public string extraccion(int monto, int tipoOperacion){
            
            if (tipoOperacion == 1 && monto <= 20000)
                return descontarCajero(monto);
            else{
                capital -= monto;
                return "monto restante " + capital;   
            }
        }

        public string descontarCajero(int monto){
                if((monto - capital) > -5000 ){
                    capital -= monto;
                    return "monto restante " + capital;
                }     
                else
                    return "el monto solisitado es mayor al que se disponbe actualmente";
        }
    }

}
