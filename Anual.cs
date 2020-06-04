using System;

namespace Relatorio
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório do ano");
        }
    }
}