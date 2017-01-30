using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileKiiras
{
  class Program
  {
    static void Main(string[] args)
    {
      string fileName = "";
      Console.WriteLine("Mi legyen a file neve? (kiterjesztés nélkül) ");
      fileName = Console.ReadLine();
      fileName += ".txt";

      FileStream file = new FileStream(fileName, FileMode.Create);
      StreamWriter Ki = new StreamWriter(file);

      //for (int i = 0; i < 5; i++)
      //{
      //    Console.Write("Kérem az {0} adatot:",i+1);
      //    string adat = Console.ReadLine();
      //    Ki.WriteLine(adat);
      //}
      string adat = "";
      
      // hiba!?
      // az üres sor is belekerül a file-ba!!
      //do
      //{
      //    Console.Write("Kérek egy adatot (üres string vége):");
      //    adat = Console.ReadLine();
      //    Ki.WriteLine(adat);
      //// amíg üres string-et nem adunk 
      //} while ( adat != "" );

      Console.Write("Kérek egy adatot (üres string vége):");
      adat = Console.ReadLine();
      while ( adat != "")
      {
          Ki.WriteLine(adat);
          Console.Write("Kérek egy adatot (üres string vége):");
          adat = Console.ReadLine();
      }

      Ki.Close();
      file.Close();
      Console.WriteLine("Program vége, tovább egy billentyű...");
      Console.ReadLine();
    }
  }
}
