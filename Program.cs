using System;

namespace aula_28_04_2020_listaEncadeadaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Lista listaEncadeade = new Lista();
            System.Console.WriteLine(listaEncadeade.mostrarElemento(0));
            listaEncadeade.adecionar(new Elemento("HS", 2));
            System.Console.WriteLine(listaEncadeade.mostrarElemento(0));
            System.Console.WriteLine(listaEncadeade.mostrarElemento(1));
            //System.Console.WriteLine(listaEncadeade.deletarElemento(1));
            System.Console.WriteLine(listaEncadeade.tamanho);
            listaEncadeade.adecionar(new Elemento("HSTR", 5));
            listaEncadeade.adecionar(new Elemento("TR", 3));
            listaEncadeade.adecionar(new Elemento("1R", 1));
            System.Console.WriteLine(listaEncadeade.tamanho);
            for (int i = 0; i < listaEncadeade.tamanho; i++)
            {
                System.Console.WriteLine(listaEncadeade.mostrarElemento(i));
            }
            //System.Console.WriteLine(listaEncadeade.deletarElemento(0));
            System.Console.WriteLine(listaEncadeade.deletarElemento(2));
            System.Console.WriteLine(listaEncadeade.tamanho);
            for (int i = 0; i < listaEncadeade.tamanho; i++)
            {
                System.Console.WriteLine(listaEncadeade.mostrarElemento(i));
            }
            System.Console.WriteLine(listaEncadeade.deletarElemento(listaEncadeade.tamanho - 1));
            System.Console.WriteLine(listaEncadeade.tamanho);
            for (int i = 0; i < listaEncadeade.tamanho; i++)
            {
                System.Console.WriteLine(listaEncadeade.mostrarElemento(i));
            }
        }
    }
}
