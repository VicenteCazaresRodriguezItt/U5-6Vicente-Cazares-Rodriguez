using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentication
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            string nombre = "vicente cazares";
            string[] datos = nombre.Split(' ');
            foreach (string item in datos)
            {
                Console.WriteLine(item);
            }
           Menu();
        }

        private static void Menu()
        {
            int opc;
            Console.WriteLine("Este es el menu: 1.Registrese");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Registrse();
                    break;
                default:
                    break;
            }
        }

        private static void Registrse()
        {
            Usuario u = new Usuario();
            //Variable ruta
            string path = "Datos.txt";
            Registro r = new Registro();
            r.RegistrarUsuario(u, path);

            //Pedimos los datos
            
            Console.WriteLine("Ingrese su nombre:");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su usuario:");
            u.Username = Console.ReadLine();
            Console.WriteLine("Ingrese su password:");
            u.Password = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
