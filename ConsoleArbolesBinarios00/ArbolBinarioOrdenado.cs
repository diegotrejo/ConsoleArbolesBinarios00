using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArbolesBinarios00
{
    public class ArbolBinarioOrdenado
    {
        public Nodo Raiz { get; set; }

        public ArbolBinarioOrdenado()
        {
            Raiz = null;
        }

        public void Insertar(string apellidosNombres, string telefono, string email)
        {
            if (!Existe(apellidosNombres))
            {
                Nodo nuevo = new Nodo(apellidosNombres, telefono, email);

                if (Raiz == null)
                {
                    Raiz = nuevo;
                }
                else
                {
                    Nodo
                        item = Raiz,
                        anterior = null;

                    while (item != null)
                    {
                        anterior = item;
                        if (apellidosNombres.ToLower().CompareTo(item.ApellidosNombres.ToLower()) < 0)
                            item = item.Izq;
                        else
                            item = item.Der;
                    }

                    if (apellidosNombres.ToLower().CompareTo(anterior.ApellidosNombres.ToLower()) < 0)
                        anterior.Izq = nuevo;
                    else
                        anterior.Der = nuevo;
                }
            }
        }

        private void RecorrerPreOrden(Nodo item)
        {
            if (item != null)
            {
                Console.WriteLine(item.ToString());
                RecorrerPreOrden(item.Izq);
                RecorrerPreOrden(item.Der);
            }
        }

        public void RecorrerPreOrden()
        {
            Console.WriteLine("--- Recorrido en PreOrden ---");
            RecorrerPreOrden(Raiz);
        }

        private void RecorrerPostOrden(Nodo item)
        {
            if (item != null)
            {
                RecorrerPreOrden(item.Izq);
                RecorrerPreOrden(item.Der);
                Console.WriteLine(item.ToString());
            }
        }

        public void RecorrerPostOrden()
        {
            Console.WriteLine("--- Recorrido en PostOrden ---");
            RecorrerPostOrden(Raiz);
        }

        private void RecorrerInOrdem(Nodo item)
        {
            if (item != null)
            {
                RecorrerInOrdem(item.Izq);
                Console.WriteLine(item.ToString());
                RecorrerInOrdem(item.Der);
            }
        }

        public void RecorrerInOrdem()
        {
            Console.WriteLine("--- Recorrido en InOrden ---");
            RecorrerInOrdem(Raiz);
        }

        public Nodo Buscar(string buscarPor)
        {
            buscarPor = buscarPor.ToLower();
            Nodo item = Raiz;

            while (item != null)
            {
                if (item.ApellidosNombres.ToLower().StartsWith(buscarPor))
                {
                    return item;
                }
                else
                {
                    if (buscarPor.CompareTo(item.ApellidosNombres.ToLower()) < 0)
                        item = item.Izq;
                    else
                        item = item.Der;
                }
            }
            return null;
        }

        private List<Nodo> BuscarLista(string buscarPor, Nodo item)
        {
            buscarPor = buscarPor.ToLower();
            List<Nodo> resultado = new List<Nodo>();

            if (item != null)
            {
                resultado.AddRange(BuscarLista(buscarPor, item.Izq));
                if (item.ApellidosNombres.ToLower().StartsWith(buscarPor))
                {
                    resultado.Add(item);
                }
                resultado.AddRange(BuscarLista(buscarPor, item.Der));
            }
            return resultado;
        }

        public List<Nodo> BuscarLista(string buscarPor)
        {
            return BuscarLista(buscarPor, Raiz);
        }

        public bool Existe(string apellidosNombres)
        {
            apellidosNombres = apellidosNombres.ToLower();
            Nodo item = Raiz;

            while (item != null)
            {
                if (item.ApellidosNombres.ToLower() == apellidosNombres)
                {
                    return true;
                }
                else
                {
                    if (apellidosNombres.CompareTo(item.ApellidosNombres.ToLower()) < 0)
                        item = item.Izq;
                    else
                        item = item.Der;
                }
            }
            return false;
        }
    }
}
