using System;

namespace cuenta
{
    public class CuentaAhorro
    {
        private int capital;
           
            
        public cliente(int capital){
            this.capital = capita;
        }

        public string extraccion(int monto, int tipoOperacion){
            
            if (operacion == 1 && monto <= 10000)
                return descontar(monto);
            else
                return descontar(monto);
        }

        private string descontarCajero(int monto){
                if(monto < capital){
                    capita -= monto;
                    return "monto restante " + capital;
                }     
                else
                    return "el monto solisitado es mayor al que se disponbe actualmente";
        }

        public string insercion(int monto){
            this.capital += monto;
            return "ingresado " + monto + "cuenta actual" capita;

        }
}
