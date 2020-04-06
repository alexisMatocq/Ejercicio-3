using System;

class MainClass {
  public static void Main (string[] args) {
  int NUM1, NUM2;
    string linea;
    Console.Write("INGRESAR PRIMER NÚMERO :");
    linea = Console.ReadLine();
    NUM1 = int.Parse(linea);
    Console.Write("INGRESAR SEGUNDO NÚMERO :");
    linea = Console.ReadLine();
    NUM2 = int.Parse(linea);
    Console.WriteLine("El resultado es:"+((NUM1+NUM2)*(NUM1-NUM2)));
  }
}