using System;


class Veiculo {
  private string marca;
  private int ano,km;
  private double valor;

  public static void Veiculo(string marca,int ano,double valor,
  int km){
    this.marca = marca;
    this.ano = ano;
    this.valor = valor;
    this.km = km;
  }
}
