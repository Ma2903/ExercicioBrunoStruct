using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Struct;

public struct Produto
{
    //dados do struct
    public string nome;

    public double valor;

    public string descricao;

    public int quantidade;

    public string fabricante;

    public double DescontoValor;

    public double DescontoPorcentagem;

    //operações da struct
    public Produto (string nome, double valor,  int quantidade, string descricao, string fabricante, 
    double DescontoValor, double DescontoPorcentagem)
    {
        this.nome = nome;
        this.valor = valor;
        this.quantidade = quantidade;
        this.descricao = descricao;
        this.fabricante = fabricante;
        this.DescontoValor = DescontoValor;
        this.DescontoPorcentagem = DescontoPorcentagem;
    }

    //operações
    public string imprimir()
    {
        return "\n Nome: " + this.nome + "\n Quantidade: " + this.quantidade + "\n Valor: R$" +
        string.Format("{0:0.00}", this.valor)  + "\n Descrição: " + this.descricao + "\n Fabricante: " + 
        this.fabricante;
    }

    public void aplicarCupomDescontoValor()
    {
        if (DescontoValor > this.valor)
        this.valor = 0.0f;
        else{
            this.valor = this.valor - DescontoValor;
        }
    }

    public void aplicarCupomDescontoPorcentagem()
    {
        double desconto =  this.valor * (DescontoPorcentagem / 100.0f);
        this.valor -= desconto;
    }

    public Boolean verificarQuantidadeEmEstoque()
    {
        if(this.quantidade > 0) return true;
        else return false;
    }
}