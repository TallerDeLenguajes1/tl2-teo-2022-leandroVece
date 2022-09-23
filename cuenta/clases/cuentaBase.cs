using System;

namespace cuenta
{
    public class cuentaBase
    {
        private int capital;

        public virtual int Capital { get => Capital; set => Capital = value; }
 
        public cuentaBase(int capital){
            this.capital = capital;
        }

        public string ingresar(int monto){
            this.capital += monto;
            string str = "ingresado " + monto + " cuenta actual " + capital;
            return str;
        }
    }
}
