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

            cliente.Nombre = "Emiliano";
            cliente.Telefono = "644 462 2668";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Teléfono: " + cliente.Telefono);

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
