using System;

namespace Relatorio
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório do mês \n");
        }
    }
}