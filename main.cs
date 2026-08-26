
using System;
class HelloWorld {
  static void Main() {
      
      double m,cm;
      Console.WriteLine("Ingrese m:");
      m = double.Parse(Console.ReadLine());
      
      cm = m * 100;
      
    Console.WriteLine($"{m:F2} metro es igual a {cm:F2} centimetros");
    Console.ReadLine();
  }
}