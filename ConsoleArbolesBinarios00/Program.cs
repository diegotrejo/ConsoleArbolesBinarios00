using System.Collections.Specialized;
using System.ComponentModel.Design;


namespace ConsoleArbolesBinarios00
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado arbol = new ArbolBinarioOrdenado();

            arbol.Insertar("Cadena Luis", "099989899", "abcd@asa.com");
            arbol.Insertar("Zambrano Esteban", "989898000", "zyx@gga.com");
            arbol.Insertar("Enriquez Eduardo", "8980989090", "ed@gog.com");
            arbol.Insertar("Enriquez Eduardo casa", "1111111", "ed@gog.com");
            arbol.Insertar("Enriquez Eduardo oficna", "2222222222", "ed@gog.com");
            arbol.Insertar("Enriquez Eduardo 2", "333333333", "ed@gog.com");
            arbol.Insertar("Enriquez Eduardo nuevo", "444444444", "ed@gog.com");
            arbol.Insertar("Enriquez Eduardo privado", "55555555555", "ed@gog.com");
            arbol.Insertar("Enriquez Eduardo 3", "6666666666", "ed@gog.com");
            arbol.Insertar("Contreras Jorge", "098789878", "ggas@aoso.com");
            arbol.Insertar("Pineda Elisa", "0998897777", "ghjgh@jhja.com");

            //arbol.RecorrerPreOrden();
            //arbol.RecorrerPostOrden();
            //arbol.RecorrerInOrdem();

            List<Nodo> encontrados = arbol.BuscarLista("enrique");
            foreach(var item  in encontrados) 
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
