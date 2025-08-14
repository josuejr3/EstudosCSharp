﻿using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um Nokia
        Nokia nokia = new Nokia("11999999999", "Nokia 3310", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        // Criando um iPhone
        Iphone iphone = new Iphone("11988888888", "iPhone 14 Pro", "987654321098765", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
