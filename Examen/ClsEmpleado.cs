using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsEmpleado
    {
        int opcion = 0;
        string[] nombre = new string[10];
        string[] cedula = new string[10];
        string[] direccion = new string[10];
        string[] telefono = new string[10];
        string[] salario = new string[10];


        public void agregar()
        {

            int cant = 1;
            for (int i = 0; i < cant; i++)
            {
                Console.Clear();
                Console.WriteLine("Digite la cedula del empleado 1=", cant);
                cedula[i] = Console.ReadLine();
                Console.WriteLine("Digite el nombre del empleado 1=", cant);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digite la direccion del empleado 1=", cant);
                direccion[i] = Console.ReadLine();
                Console.WriteLine("Digite el telefono del empleado 1=", cant);
                telefono[i] = Console.ReadLine();
                int.TryParse(Console.ReadLine(), out cant);
                Console.WriteLine("Digite el salario del empleado 1=", cant);
                salario[i] = Console.ReadLine();
                int.TryParse(Console.ReadLine(), out cant);
                cant++;
            }


        }
        public void consultar()
        {
            int cant = 1;
            string ced = "";
            Console.Write("Digite la Cedula: ");
            ced = Console.ReadLine();
            for (int i = 0; i < cant; i++)
            {
                if (Equals(cedula[i]))
                {
                    Console.Write($"Nombre: {nombre[i]}");
                    Console.Write($"cedula: {cedula[i]}");
                    break;
                }
            }

        }
        public void modificar()
        {
            int cant = 1;

            for (int i = 0; i < cant; i++)
            {
                if (Equals(cedula[i]))
                {
                    Console.Write("Digite un nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.Write("Digite la cedula: ");

                    break;
                }

            }
        }
    }
}
     
        

        
   

