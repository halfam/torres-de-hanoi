using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            List<Disco> discos = new List<Disco>();
			for (int i = 8; i >= 1; i--)
			{
                Disco d = new Disco();
                d.Valor = i;
                discos.Add(d);
			}
            Pila ini = new Pila("inicio",discos);
            Pila aux = new Pila("auxiliar");
            Pila fin = new Pila("final");
            Hanoi h = new Hanoi();
            int r;
            //r = h.iterativo(discos.Count, ini, fin, aux);
            r = h.recursivo(discos.Count, ini, fin, aux);
            Console.WriteLine("resultado: " + r);
            Console.ReadKey();
        }
    }
}
