using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class ClsMenu
    {
        static int opcion;

       static public void menu(){
            int opcion = 0;
           
            do
            {
                Console.WriteLine("1=Agregar empleados");
                Console.WriteLine("2=Consultar empleados");
                Console.WriteLine("3=Borrar empleados");
                Console.WriteLine("4=Modificar empleados");
                Console.WriteLine("5=Inicializar arreglos");
                Console.WriteLine("6=Reportes");
                Console.WriteLine("7=Salir");
                Console.WriteLine("Ingrese un valor:");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: break;
                    case 2: break; 
                    case 3: break; 
                    case 4: break; 
                    case 5: break; 
                    case 6: break;
                    default:
                        break;
                }



            } while (opcion!=7);
        
        }


    }
}
