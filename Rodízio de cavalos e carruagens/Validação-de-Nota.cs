using System;

class Desafio {
  
    public static void Main() {
      
      double somarNotas = 0;
      int contador = 0;
      
      do
      {
        float notaEntrada = float.Parse(Console.ReadLine());
        
        if(notaEntrada < 0 || notaEntrada > 10)
        {
          Console.WriteLine("nota invalida");
          
        } else {
          contador++;
          somarNotas += notaEntrada; 
        }
        
      } while (contador < 2);
      
      Console.WriteLine("media = " + (somarNotas / 2).ToString("N2"));
    }
}