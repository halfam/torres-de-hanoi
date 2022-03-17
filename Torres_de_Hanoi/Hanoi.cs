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
			if (a.Top < b.Top)
			{
				Console.WriteLine("Moviendo " + a.Top +" de " + a.Nombre + " a " + b.Nombre);
                b.push(a.pop());
			}
			else
			{
					Console.WriteLine("Moviendo " + b.Top + " de " + b.Nombre + " a " + a.Nombre);
					a.push(b.pop());
			}
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
			int m = 0;
			if (n % 2 != 0)
			{
				while (fin.Size!=n)
				{
					r++;
					mover_disco(ini, fin);
                    if (fin.Size == n)
                    {
						break;
                    }
					r++;
					mover_disco(ini, aux);
					if (fin.Size == n)
					{
						break;

					}
					r++;
					mover_disco(aux, fin);
				}
			}
			else
			{
				while (fin.Size != n)
				{

					r++;
					mover_disco(ini, aux);
					if (fin.Size == n)
					{
						break;

					}
					r++; 
					mover_disco(ini, fin);
					if (fin.Size == n)
					{
						break;

					}
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
				recursivo(n - 1, ini, aux, fin);
				r++;
				mover_disco(ini, fin);
				recursivo(n-1, aux, fin, ini);
			}
			return r;
		}
		

    }
}
