using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Struct;

public struct Produto
{
    //dados do struct
    public string nome;

    public double valor;

    public int DescontoValor;

    public int quantidade;

    public string estoque;

    //operações da struct
    public Produto (string nome, double valor, int DescontoValor,  int quantidade, string estoque)
    {
        this.nome = nome;
        this.valor = valor;
        this.DescontoValor = DescontoValor;
        this.quantidade = quantidade;
        this.estoque = estoque;
    }

    //operações
    public string imprimir()
    {
        return "\n Nome: " + this.nome + "\n Quantidade: " + this.estoque + "\n Valor: R$" + string.Format("{0:0.00}", this.valor);
    }

    public void aplicarCupomDescontoValor()
    {
        this.valor = valor - DescontoValor;
    }

    public void aplicarCupomDescontoPorcentagem()
    {
        //fazer amanhã
    }

    public void verificarQuantidadeEmEstoque()
    {
        if(this.quantidade == 0)
        {
            estoque = Convert.ToString(this.quantidade);
            estoque = "Não há disponibilidade no estoque";
        }
        else
        {
            estoque = Convert.ToString(this.quantidade); 
        }
    }
}