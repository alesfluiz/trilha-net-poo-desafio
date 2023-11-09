using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("99999-9999", "Lumia", "1111111111122222", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Iphone iphone = new Iphone("98888-8888", "XS Pró Max", "54584654465465424424654", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");