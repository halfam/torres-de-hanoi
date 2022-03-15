using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b)
        {
			if (a.Top < b.Top && a.Top!=0)
			{
				Console.WriteLine("Moviendo " + a.Top +" de " + a.Nombre + " a " + b.Nombre);
                b.push(a.pop());
			}
			else
			{
				//if (a.Top != b.Top )
				//{
					Console.WriteLine("Moviendo " + b.Top + " de " + b.Nombre + " a " + a.Nombre);
					a.push(b.pop());
			//	}
			}
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
			int m = 0;
			if (n % 2 == 0)
			{
				while (!ini.isEmpty() || !aux.isEmpty())
				{
					
					r++;
					mover_disco(ini, fin);
					r++;
					mover_disco(ini, aux);
					r++;
					mover_disco(aux, fin);
					/*Console.WriteLine("Top fin " + fin.Top);
					Console.WriteLine("Top aux " + aux.Top);
					Console.WriteLine("Top ini " + ini.Top);
					Console.WriteLine(n);*/
				}
			}
			else
			{
				while (!ini.isEmpty() || !aux.isEmpty())
				{
					r++;
					mover_disco(ini, aux);
					r++; 
					mover_disco(ini, fin);
					r++; 
					mover_disco(aux, fin);
				}
			}
            return r;
        }
		public int r = 0;
		public int recursivo(int n, Pila ini, Pila fin, Pila aux)
		{
			if (n == 1)
			{
				r++;

				mover_disco(ini, fin);
			}
			else
			{
				r++;

				recursivo(n - 1, ini, fin, aux);
				mover_disco(ini, fin);
				recursivo(n-1, aux, fin, aux);
			}
			return r;
		}
		

    }
}
