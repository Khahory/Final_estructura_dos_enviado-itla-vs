using ListaOrdenada1;
using ListaOrdenadaDesc1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_estructura_dos
{
    class ClassMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aqui digitara la lista original a ordenar");
            ListaOrdenadaDesc listaOrdenadaDesc = new ListaOrdenadaDesc();
            ListaOrdenada listaOrdenada = new ListaOrdenada();
            for (int i = 0; i < 20; i++)
            {

                var numero = Int32.Parse(Console.ReadLine());
                listaOrdenadaDesc.InsertarDesc(numero);
                listaOrdenada.InsertarAsce(numero);

            }

            Console.WriteLine();

            Console.WriteLine("Aqui se muestran la lista ordenada descendente");
            listaOrdenadaDesc.Imprimir();

            Console.WriteLine();

            Console.WriteLine("Aqui se muestran la lista ordenada ascendente");
            listaOrdenada.Imprimir();
            Console.ReadKey();
        }
    }
}
