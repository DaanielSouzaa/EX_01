using System;
using System.Collections.Generic;

class Mostruario {
  private List<Veiculo> veiculos = new List<Veiculo>();
  private static List<Vendedor> vendedores = new List<Vendedor>();

  public Mostruario(Veiculo veic,Vendedor vend){
    this.veiculos.add(veic);
    this.vendedores.add(vend);
  }

  public Mostruario(){
    Console.WriteLine("Mostruário criado");
  }

  public static void addCarro(Veiculo veic,Vendedor vend){
    this.veiculos.add(veic);
    this.vendedores.add(vend);
  }

  public static void getMostruario(){
    for(int i = 0;i < veiculos.Count;i++){
      Console.WriteLine(veiculos[i]);
      Console.WriteLine(Vendedor[i].nome);
    }
  }

  public static void calculaValor(){

  }
}