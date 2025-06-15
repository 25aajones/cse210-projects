using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
   static void Main(string[] args)
   {
      // Console.WriteLine("Bonjour tout le monde");

      // Circle myCircle = new Circle();
      // Circle myCircle2 = new Circle();
      // myCircle.SetRadius(10);
      // // myCircle._radius= 10;

      // myCircle2.SetRadius(20);
      // // myCircle._radius= 10;
      // Console.WriteLine($"{myCircle.GetRadius()}");
      // Console.WriteLine($"{myCircle2.GetRadius()}");

      // Console.WriteLine($"{myCircle.GetArea()}");
      // Console.WriteLine($"{myCircle2.GetArea()}");

      // Cylinder myCylinder = new Cylinder();
      // myCylinder.SetCircle(myCircle);
      // myCylinder.SetHeight(10);
      // Console.WriteLine($"{myCylinder.GetVolume()}");

      int sleepTime = 250;
      int time = 9;

      DateTime currentTime = DateTime.Now;
      DateTime endTime = currentTime.AddSeconds(time);

      string animationString2 = "-+\\|/";
      int index = 0;

      while (DateTime.Now < endTime)
      {
         Console.Write(animationString2[index++ % animationString2.Length]);
         Thread.Sleep(sleepTime);
         Console.Write("\b");
      }

      int count = time;

      while (DateTime.Now < endTime)
      {
         Console.Write(count--);
         Thread.Sleep(1000);
         Console.Write("\b");
      }

      string animationString = "(^_^)(-_-)";

      while (DateTime.Now < endTime)
      {
         Console.Write(animationString[0..5]);
         // Console.Write("\\");
         Thread.Sleep(sleepTime);
         Console.Write("\b\b\b\b\b");
         // Console.Write("|");
         Console.Write(animationString[5..]);
         Thread.Sleep(sleepTime);
         Console.Write("\b\b\b\b\b");
         // Console.Write("/");
         //  Thread.Sleep(sleepTime);
         //  Console.Write("\b");



      }
   }
}

// public void WriteToFile(string filename)
// {
//    usign (StreamWriter outputFile = new StreamWriter(filename))
//    {
//       foreach(JournalEntry entry in entries)
//       {
//          outputFile.WriteLine(entry.ToString());
//       }
//    }
// }

// class Program 
// {
//    private 

//    static void Main(string[] args)
//    {
//       Journal newJournal = new Journal;
//    }
// }