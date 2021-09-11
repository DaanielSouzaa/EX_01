using System;


class Veiculo {
  private string marca;
  private int ano,km;
  private double valor;

  public Veiculo(string marca,int ano,double valor,
  int km){
    this.marca = marca;
    this.ano = ano;
    this.valor = valor;
    this.km = km;
  }

  public void atualizaValor(){
    Console.WriteLine("Favor informar o ano atual:");
    int anoAtual = int.Parse(Console.ReadLine());

    this.valor = this.valor - ((anoAtual - this.ano)*2.05);

    Console.WriteLine("O novo valor do carro é {0}",this.valor);
  }

  public void relatorio(){
    Console.WriteLine("Marca: {0}",this.marca);
    Console.WriteLine("Ano: {0}",this.ano);
    Console.WriteLine("Valor: {0}",this.valor);
    Console.WriteLine("Km: {0}",this.km);
  }

  public string getMarca(){
    return this.marca;
  }

  public int getAno(){
    return this.ano;
  }

  public double getValor(){
    return this.valor;
  }

  public int getKm(){
    return this.km;
  }

}
