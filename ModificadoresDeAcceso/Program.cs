using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Cuenta cuenta = new Cuenta();

            cliente.Nombre = "Emiliano";
            cliente.Telefono = "644 462 2668";

            cuenta.Propetario = cliente;
            cuenta.Saldo = 78900;


            Console.WriteLine("Cliente: ");
            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Teléfono: " + cliente.Telefono);
            Console.WriteLine(" ");

            Console.WriteLine("Cuenta: ");
            Console.WriteLine("Saldo: " + cuenta.Saldo);

            try
            {
                cuenta.Identificador = "73859375839184xx";
                Console.WriteLine("Identificador: " + cuenta.Identificador);
            }
            catch (Exception ide)
            {
                Console.WriteLine("Solo debe de tener entre 10 y 14 caracteres");
            }

            try
            {
                cliente.Curp = "738593758391845672";
                Console.WriteLine("Curp: " + cliente.Curp);
            }
            catch (Exception CurpNo18)
            {
                Console.WriteLine("La CURP debe ser de 18 caracteres");
            }

            Console.ReadLine();
        }
    }
}
 