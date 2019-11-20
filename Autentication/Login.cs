using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentication
{
   public class Login
    {
        public void IngresarDatos()
        {
            Registro r = new Registro();
            Usuario u = new Usuario();
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingresa tu username:");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu Password");
            u.Password = Console.ReadLine();
            List<string> datos = r.ObtenerLineas("Datos.txt");
            ValidarDatos(u, datos);
        }

        public void ValidarDatos(Usuario u, List<string> datos)
        {
            List<Usuario> usuario = new List<Usuario>();
            foreach(var item in datos)
            {
                string[] Info = item.Split(',');
                usuario.Add(new Usuario { Nombre = Info[0], Username = Info[1], Password = Info[2] });
            }
            foreach (var us in usuario)
            {
                if (u.Username == us.Username && u.Password == us.Password)
                {
                    Bienvienido();
                    Console.ReadKey();
                }
            }
        }

        public void Bienvienido()
        {
            Console.WriteLine("Ha entrado exitosamente a mi corazón");
            Console.ReadKey();
        }
    }
}
