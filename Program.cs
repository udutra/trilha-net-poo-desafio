using DesafioPOO.Models;
using System;

namespace DesafioPOO {
    public class Program {
        public static void Main(string[] args) {
            if (args is null) {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone("4987", "Modelo 2", "222222222", 128);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");


        }
    }
}