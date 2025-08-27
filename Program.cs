using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456789", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("Modelo: " + nokia.Modelo);
Console.WriteLine("IMEI: " + nokia.Imei);
Console.WriteLine("Memória: " + nokia.Memoria + "GB");

Console.WriteLine("Smartphone iPhone:");

Smartphone iphone = new Iphone("987654321", "iPhone 12", "IMEI987654321", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
Console.WriteLine("Modelo: " + iphone.Modelo);
Console.WriteLine("IMEI: " + iphone.Imei);
Console.WriteLine("Memória: " + iphone.Memoria + "GB");
