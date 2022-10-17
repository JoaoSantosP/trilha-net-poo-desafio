using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone nokia:");
Nokia nokia = new Nokia("123456", "Modelo 1", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("4987", "Modelo 2", "22222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

