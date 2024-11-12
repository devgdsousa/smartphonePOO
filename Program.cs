using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe Nokia
            Console.WriteLine("Teste com o Nokia:");
            Nokia nokia = new Nokia("12345", "Nokia 3310", "111111111111111", 64);
            Console.WriteLine($"Número: {nokia.Numero}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria}MB");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine("\n");

            // Testando a classe Iphone
            Console.WriteLine("Teste com o iPhone:");
            Iphone iphone = new Iphone("54321", "iPhone 13", "222222222222222", 128);
            Console.WriteLine($"Número: {iphone.Numero}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria}MB");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.WriteLine("\nTestes concluídos!");
        }
    }
}
