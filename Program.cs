using System;
using Struct;

namespace TAD
{
    class Program
    {
        static void Main(string[]args)
        {
            //Struct
            ClienteS cliente1 = new();

            cliente1.nome = "Daniel";
            cliente1.cpf = "123.456.789-00";
            cliente1.dtnascm = "31/10/2005";
            cliente1.email = "daniel.jacometo@fatec.sp.gov.br";

            Console.WriteLine(cliente1.imprimir());

            JogadorFutebol jogador1 = new();

            jogador1.nome = "Daniel";
            jogador1.dtnascm = "31/10/2005";
            jogador1.clube = "";

            //Exercício 1
            jogador1.adicionarCartaoAmarelo();
            jogador1.adicionarCartaoVermelho();
            jogador1.verificarVinculoClube();
            Console.WriteLine(jogador1.imprimir());
        }
    }   
}
