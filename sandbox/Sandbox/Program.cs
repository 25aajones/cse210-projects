using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
   static void Main(string[] args)
   {
      // Console.WriteLine("Bonjour tout le monde");

      Circle myCircle = new Circle();
      Circle myCircle2 = new Circle();
      myCircle.SetRadius(10);
      // myCircle._radius= 10;

      myCircle2.SetRadius(20);
      // myCircle._radius= 10;
      Console.WriteLine($"{myCircle.GetRadius()}");
      Console.WriteLine($"{myCircle2.GetRadius()}");

      Console.WriteLine($"{myCircle.GetArea()}");
      Console.WriteLine($"{myCircle2.GetArea()}");

      Cylinder myCylinder = new Cylinder();
      myCylinder.SetCircle(myCircle);
      myCylinder.SetHeight(10);
      Console.WriteLine($"{myCylinder.GetVolume()}");
   }
}

public void WriteToFile(string filename)
{
   usign (StreamWriter outputFile = new StreamWriter(filename))
   {
      foreach(JournalEntry entry in entries)
      {
         outputFile.WriteLine(entry.ToString());
      }
   }
}

class Program 
{
   private 

   static void Main(string[] args)
   {
      Journal newJournal = new Journal;
   }
}