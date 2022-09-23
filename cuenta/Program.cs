using System;

namespace cuenta
{
    class Program
    {
        static void Main(string[] args)
        {

            int option;
            cuentaBase newCuenta = null;
            
            Console.WriteLine("Tipo de cuenta que quiere crear 1) ahorro 2) Pesos 3) dolares");
            
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    newCuenta = new CuentaAhorro(500);
                    break;
                case 2:
                    newCuenta = new CuentaPeso(500);
                    break;
                case 3:
                    newCuenta = new CuentaDolar(500);
                    break;
                default:
                    break;
                     Console.WriteLine("opcion incorrecta");

            }

            Console.WriteLine(newCuenta.ingresar(200));
            
        }
    }
}
