using System;

namespace Relatorio
{
    public class Relatorio
    {
        public string dateTime;

        public virtual void MostrarRelatorio(){
            Console.WriteLine("Mostrando relatório geral");
        }
    }
}