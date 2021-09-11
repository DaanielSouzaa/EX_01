using System;

class Vendedor {
  private double salario,comissao;
  public string nome;

  public Vendedor (double salario,double comissao,string nome){
    this.salario = salario;
    this.comissao = comissao;
    this.nome = nome;
  }
  public double getComissao(){
    return this.comissao;
  }
  public double getSalario(){
    return this.salario;
  }
  public double getNome(){
    return this.nome;
  }

  public double receberSalario(){
    Console.WriteLine("Favor informar o valor das vendas no período");
    double valorVendas = double.Parse(Console.ReadLine());
    return this.salario+((this.comissao)*valorVendas);
  }

}