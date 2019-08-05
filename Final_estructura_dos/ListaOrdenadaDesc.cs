using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ListaOrdenadaDesc1
{
    class ListaOrdenadaDesc
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }
        private Nodo raiz;
        public ListaOrdenadaDesc()
        {
            raiz = null;
        }

        public void InsertarDesc(int x)
        {
            Nodo nuevo = new Nodo();
            nuevo.info = x;
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                if (x > raiz.info)
                {
                    nuevo.sig = raiz;
                    raiz = nuevo;
                }
                else
                {
                    Nodo reco = raiz;
                    Nodo atras = raiz;
                    while (x <= reco.info && reco.sig != null)
                    {
                        atras = reco;
                        reco = reco.sig;
                    }
                    if (x <= reco.info)
                    {
                        reco.sig = nuevo;
                    }
                    else
                    {
                        nuevo.sig = reco;
                        atras.sig = nuevo;
                    }
                }
            }
        }
        public void Imprimir()
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                Console.WriteLine(": " + reco.info);
                reco = reco.sig;
            }
            Console.WriteLine();
        }
        
    }
}