using System;

namespace Struct;

public class Professor{

    public string name;
    public double salario;
    public int cargaHoraria;

    public Professor(string name, double salario, int cargaHoraria)
    {
        this.name = name;
        this.salario = salario;
        this.cargaHoraria = cargaHoraria;
    }
    public void ReajusteSalarialEmValor(double valor)
    {
        this.salario += valor;
    }
    public void ReajusteSalarialEmPorcentagem(double porcentagem)
    {
        this.salario += this.salario * (porcentagem / 100);
    }
    public void DescontoSalarialPorFaltaEmValor(double valor)
    {
        this.salario -= valor;
    }
    public void DescontoSalarialPorFaltaEmPorcentagem(double porcentagem)
    {
        this.salario -= this.salario * (porcentagem / 100);
    }
    public void AumentarCargaHorariaDeTrabalho(int novaCargaHoraria, double valorReajuste)
    {
        this.cargaHoraria += novaCargaHoraria;
        this.ReajusteSalarialEmValor(valorReajuste);
    }
    public void Imprimir()
    {
        Console.WriteLine($"Nome: {this.name}");
        Console.WriteLine($"Salário: {this.salario:C}");
        Console.WriteLine($"Carga Horária: {this.cargaHoraria} horas/semana");
    }
}