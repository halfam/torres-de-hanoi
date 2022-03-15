using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*public Pila() que representa el constructor de la clase.
public void push(Disco d) que permitir´a colocar un disco en la pila de discos.
public Disco pop() que permitir´a extraer el disco de la parte superior de la pila.
public bool isEmpty() que informar´a si la pila est´a o no vac´ıa.
Size para representar la cantidad de discos que hay en el palo.
Top para representar el disco que est´a en la parte superior del palo.
Elementos para representar el conjunto de discos que hay en ese palo
*/
namespace Torres_de_Hanoi
{
    class Pila
    {
        private int _size;
        public string Nombre { get; set; }
        public int Size
        { 
            get 
            {
                return Elementos.Count;
            }
			
        }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
       
        public int Top 
        {
			get 
            {
                //Console.WriteLine(this.Nombre + " Cantidad de elementos : " + this.Size);
                if (this.isEmpty())
				{
                    return int.MaxValue;
				}
				try { return Elementos.ElementAt(Elementos.Count - 1).Valor; }
                catch { return 0; }
                
                //return Elementos.Last<Disco>().Valor;
            }
        }

        /* TODO: Elegir tipo de Elementos
       public Disco[] Elementos { get; set; }
       public List<Disco> Elementos { get; set; }
       */
        public List<Disco> Elementos { get; set; }
        /* TODO: Implementar métodos */
        public Pila(string nombre)
        {
            this.Nombre =  nombre;
            Elementos = new List<Disco>();
        }
        public Pila(string nombre, List<Disco> discos)
        {
            this.Nombre = nombre;
            Elementos = discos;
        }

        public void push(Disco d)
        {
           Elementos.Add(d);
           //Elementos = Elementos;
        }

        public Disco pop()
        {
            /*if (this.isEmpty())
	        {
                return null;
	        }*/
            Disco elem = Elementos.Last<Disco>();
            Elementos.Remove(elem);
           // Elementos = Elementos;
            return elem;
        }                

        public bool isEmpty()
        {
            return Size == 0;
        }

    }
}
