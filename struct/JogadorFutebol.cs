using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Struct;

public struct JogadorFutebol
{
    //dados do struct
    public string nome;
    public string dtnascm;

    public int cartaoAmarelo = 0;

    public int cartaoVermelho = 0;

    public string clube;

    //operações da struct
    public JogadorFutebol (string nome,  string dtnascm, string clube)
    {
        this.nome = nome;
        this.dtnascm = dtnascm;
        this.clube = clube;
    }

    //operações
    public string imprimir()
    {
        return "\n Nome: " + this.nome + "\n Data de Nascimento: " + this.dtnascm + "\n Cartões Amarelos: " + 
        this.cartaoAmarelo + "\n Cartões Vermelhos: " + this.cartaoVermelho + "\n Clube: " + this.clube;
    }

    public void adicionarCartaoAmarelo()
    {
        this.cartaoAmarelo = cartaoAmarelo + 1;
    }
    public void adicionarCartaoVermelho()
    {
        this.cartaoVermelho = cartaoVermelho + 1;
    }
    public void verificarVinculoClube()
    {  
        if(this.clube == "")
        {
            this.clube = "Sem clube";
        }
        else if(this.clube == null)
        {
            this.clube = "Sem clube";
        }
    }
}