using System;

namespace cuenta
{
    public class CuentaPeso : cuenta
    {
        private int capital;
           
            
        public cliente(int capital){
            this.capital = capita;
        }

        public string extraccion(int monto, int tipoOperacion){
            
            if (operacion == 1 && monto <= 20000)
                return descontar(monto);
            else
                return descontar(monto);
        }

        private string descontarCajero(int monto){
                if((monto - capital) > -5000 ){
                    capita -= monto;
                    return "monto restante " + capital;
                }     
                else
                    return "el monto solisitado es mayor al que se disponbe actualmente";
        }

}
