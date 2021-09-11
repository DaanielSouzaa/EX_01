using System;

class Program {
  public static void Main (string[] args) {
    Veiculo Ferrari1 = new Veiculo("Ferrari1",2021,5867.45,0);
    Veiculo Ferrari2 = new Veiculo("Ferrari2",2022,5868.45,1);
    Veiculo Ferrari3 = new Veiculo("Ferrari3",2023,5869.45,2);
    Veiculo Ferrari4 = new Veiculo("Ferrari4",2024,5861.45,3);
    Veiculo Ferrari5 = new Veiculo("Ferrari5",2025,5862.45,4);

    Vendedor Claudio = new Vendedor(2500.95,0.5,"Cláudio");

    Mostruario mostruario = new Mostruario();

    Mostruario.addCarro(Ferrari1,Claudio);
    Mostruario.addCarro(Ferrari1,Claudio);
    Mostruario.addCarro(Ferrari1,Claudio);
    Mostruario.addCarro(Ferrari1,Claudio);
  }
}