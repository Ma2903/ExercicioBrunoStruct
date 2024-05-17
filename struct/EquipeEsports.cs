using System;

namespace Struct;

public struct EquipeEsports{
    public int CampeonatosVencidos;
    public double ValorTotalPremiacoes;
    public int AnoDeEstreia;
    public string Nome;
    public EquipeEsports(string Nome,int AnoDeEstreia){
        this.CampeonatosVencidos = 0;
        this.ValorTotalPremiacoes = 0;
        this.AnoDeEstreia = AnoDeEstreia;
        this.Nome = Nome;
    }
    public void registrarCampeonatoVencido(double valorPremio){
        this.CampeonatosVencidos += 1;
        this.atualizarValorTotalDasPremiacoes(valorPremio);
    }
    public void atualizarValorTotalDasPremiacoes(double valor){
        this.ValorTotalPremiacoes += valor;
    }
    public string VerificarAnoDeEstreia(){
        DateTime dataAtual = DateTime.Now;
        int anoAtual = dataAtual.Year;

        if(anoAtual == this.AnoDeEstreia){
            return "Novatos";
        }
        return "Veterano";
    }
    public string Imprimir()
    {
        return $"Nome da Equipe: {this.Nome}\n" +
                $"Ano de Estreia: {this.AnoDeEstreia}\n" +
                $"Status: {this.VerificarAnoDeEstreia()}\n" +
                $"Campeonatos Vencidos: {this.CampeonatosVencidos}\n" +
                $"Valor Total das Premiações: {this.ValorTotalPremiacoes:C}";
    }
}