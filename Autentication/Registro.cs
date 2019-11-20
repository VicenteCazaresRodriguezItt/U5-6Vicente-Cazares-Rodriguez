using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autentication
{
   public class Registro
    {
        public void RegistrarUsuario(Usuario u, string path)
        {
            Console.WriteLine("Nombre completo");
           u.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu username:");
            u.Username = Console.ReadLine();
            Console.WriteLine("Ingresa tu Password");
            u.Password = Console.ReadLine();
            string data = u.Nombre + "\n" + u.Username + "\n" + u.Password;
            var datos = ObtenerLineas(path);
            if (datos != null)
            {
                datos.Add(data);
                File.WriteAllLines(path, datos);
            }
            else
            {

                File.WriteAllText(path, data);
            }
        }

        public List<string> ObtenerLineas(string ruta)
        {
            string[] data = null;

            if (File.Exists(ruta))
            {
                data = File.ReadAllLines(ruta);
            }
            else
            {
                Console.WriteLine("Archivo no existe");
                return null;
            }
            List<string> datos = new List<string>();

            foreach (var item in data)
            {
                datos.Add(item);
            }

            return datos;
        }
    }
}
