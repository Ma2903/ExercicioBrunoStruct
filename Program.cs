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

            //Exercicio Produto
            Produto produto1 = new();

            produto1.nome = "Miojo Nissin Sabor Carne";
            produto1.valor = 5.00;
            produto1.DescontoValor = 1;
            produto1.DescontoPorcentagem = 25;
            produto1.quantidade = 4;

            produto1.aplicarCupomDescontoPorcentagem();
            produto1.aplicarCupomDescontoValor();
            produto1.verificarQuantidadeEmEstoque();
            Console.WriteLine(produto1.imprimir());

            Professor professor = new Professor("João Silva", 5000.0, 40);
        
            professor.Imprimir();
            
            professor.ReajusteSalarialEmValor(500.0);
            professor.ReajusteSalarialEmPorcentagem(10.0);
            professor.DescontoSalarialPorFaltaEmValor(200.0);
            professor.DescontoSalarialPorFaltaEmPorcentagem(5.0);
            professor.AumentarCargaHorariaDeTrabalho(10, 1000.0);
            
            professor.Imprimir();
            
        }
    }   
}
