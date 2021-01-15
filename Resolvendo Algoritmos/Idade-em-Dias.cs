using System;

class MinhaClasse {
  public static void Main (string[] args) {
    const int quantidadeDeDiasNoAno = 365;
    const int quantidadeDeDiasNoMes = 30;
    var idadeEmDias = int.Parse(Console.ReadLine());
    var anos = idadeEmDias / quantidadeDeDiasNoAno;
    var meses = (idadeEmDias % quantidadeDeDiasNoAno) / quantidadeDeDiasNoMes;
    var dias =  (idadeEmDias % quantidadeDeDiasNoAno) % quantidadeDeDiasNoMes;
    
    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}