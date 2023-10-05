using System;
using System.Numerics;

namespace faktorial
{
  class Program
  {
    static void Main(string[] args)
    {
      int cislo;
      BigInteger fakt;
      while(true){
        while (true)
        {
          Console.Clear();
          Console.Write("Zadej celé číslo: ");
          if (int.TryParse(Console.ReadLine(), out cislo))
          {
            if (cislo < 0)
            {
              Console.WriteLine("Zadané číslo musí být větší než 0!!!");
            }
            else
            {
              break;
            }
          }
          else
          {
            Console.WriteLine("Musíš zadat číslo!!!!");
          }
          Console.ReadKey(true);
        }
        fakt = 1;
        for (int i = 1; i <= cislo; i++)
        {
          fakt *= i;
          Console.WriteLine($"{i}! = {fakt}");
        }
        
        Console.ReadKey();
      }
    }      
  }
}
