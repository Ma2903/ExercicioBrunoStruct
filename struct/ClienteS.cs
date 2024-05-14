//EXEMPLO!!!!!
namespace Struct;

public struct ClienteS
{
    //dados do struct
    public string nome;
    public string cpf;
    public string dtnascm;
    public string email;

    //operações da struct
    public ClienteS (string nome, string cpf, string dtnascm, string email)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.dtnascm = dtnascm;
        this.email = email;
    }

    //operações
    public string imprimir()
    {
        return "\n Nome: " + this.nome + "\n CPF: " + this.cpf + "\n Data de Nascimento: " + this.dtnascm + "\n E-mail: " + this.email;
    }


}