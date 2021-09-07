using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>
            {
                new Persona(2),
                new Perro(4)
            };

            foreach (var item in animales)
            {
                Console.WriteLine(item.Caminar());
            }

            Console.ReadLine();
        }
    }
}
