
using System;
class HelloWorld {
  static void Main() {
      
      int h,m, s;
      Console.WriteLine("Ingrese horas:");
      h = int.Parse(Console.ReadLine());
      
      m = h * 60;
      
      s = h * 3600;
      
    Console.WriteLine($"{h:F2} horas es igual a {m:F2} minutos y es igual a {s:F2} segundos");
    Console.ReadLine();
  }
}