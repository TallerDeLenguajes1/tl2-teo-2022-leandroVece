using System;

namespace cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaAhorro newCuenta = new CuentaAhorro(800);

            Console.WriteLine(newCuenta.ingresar(200));
        }
    }
}
