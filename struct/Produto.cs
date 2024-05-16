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

    public double DescontoPorcentagem;

    //operações da struct
    public Produto (string nome, double valor, int DescontoValor,  int quantidade, double DescontoPorcentagem)
    {
        this.nome = nome;
        this.valor = valor;
        this.DescontoValor = DescontoValor;
        this.quantidade = quantidade;
        this.DescontoPorcentagem= DescontoPorcentagem;
    }

    //operações
    public string imprimir()
    {
        return "\n Nome: " + this.nome + "\n Quantidade: " + this.quantidade + "\n Valor: R$" + string.Format("{0:0.00}", this.valor);
    }

    public void aplicarCupomDescontoValor()
    {
        this.valor = valor - DescontoValor;
    }

    public void aplicarCupomDescontoPorcentagem()
    {
        double desconto =  this.valor * (DescontoPorcentagem / 100);
        this.valor -= desconto;
    }

    public int verificarQuantidadeEmEstoque()
    {
        return this.quantidade;
    }
}