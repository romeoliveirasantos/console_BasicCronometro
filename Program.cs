using System;

namespace Cronometro
{
  class Program
  {
    static void Main(string[] args)
    {      
      Menu();
    }
    
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("S = Segundo => 10s = 10 segundos.");
      Console.WriteLine("M = Minuto => 1m = 1 minuto.");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Quanto tempo deseja contar?");

      string data = Console.ReadLine()!.ToLower();
      char type = char.Parse(data.Substring(data.Length -1, 1));      
      int time = int.Parse(data.Substring(0, data.Length -1));
      int multiplier = 1;

      if(type == 'm')
      {
        multiplier = 60;
      }

      if(time == 0)
      {
        System.Environment.Exit(0);
      }

      PreStart(time * multiplier);

      
    }
    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Escolha o tipo do cronometro");
      Console.WriteLine("1 - Cronômetro Progressivo");
      Console.WriteLine("2 - Cronômetro Regressivo");
      Console.WriteLine("0 - Sair");
      short res = short.Parse(Console.ReadLine()!);
      switch(res)
      {
        case 0: 
          Console.WriteLine("Finalizando app");
          System.Environment.Exit(0);
          break;
        case 1: 
          Console.Clear();
          Console.WriteLine("Ready...");
          Thread.Sleep(1000);
          Console.WriteLine("Set...");
          Thread.Sleep(1000);
          Console.WriteLine("Go...");
          Thread.Sleep(2500);
          StartContagemProgressiva(time);
          break;
        case 2: 
          Console.Clear();
          Console.WriteLine("Ready...");
          Thread.Sleep(1000);
          Console.WriteLine("Set...");
          Thread.Sleep(1000);
          Console.WriteLine("Go...");
          Thread.Sleep(2500);
          StartContagemRegressiva(time);          
          break;
      }
      
    }
    
    static void StartContagemProgressiva(int time)
    {
      
      int currentTime = 0;

      while(currentTime != time)
      {
        Console.Clear();
        currentTime++;        
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();
      Console.WriteLine("Cronômetro finalizado");
      Thread.Sleep(2500);
      Menu();
    }
    static void StartContagemRegressiva(int time)
    {
      
      int currentTime = 0;

      while( time >= currentTime)
      {
        Console.Clear();
        Console.WriteLine(time);
        Thread.Sleep(1000);
        time--;        
        
      }
      Console.Clear();
      Console.WriteLine("Cronômetro finalizado");
      Thread.Sleep(2500);
      Menu();
    }
  }
}

