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
    public string verificarAnoDeEstreia(){
        DateTime dataAtual = DateTime.Now;
        int anoAtual = dataAtual.Year;

        if(anoAtual == this.AnoDeEstreia){
            return "Novatos";
        }
        return "Veterano";
    }
}