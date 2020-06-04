using System;

namespace Relatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Data:");
            

            System.Console.WriteLine("Mostrando todos os relatórios disóníveis: \n");
            Mensal mes = new Mensal();
            mes.MostrarRelatorio();

            Anual ano = new Anual();
            ano.MostrarRelatorio();
        }
    }
}
