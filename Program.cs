using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\nSmartphone Nokia:");
var nokia = new Nokia("(99) 99999-9999", "Modelo 2.40", "123456789", 256);
nokia.Ligar();
nokia.InstalarAplicativo(" - Programando em C# -");

Console.WriteLine("\nSmartphone Iphone:");
var iphone = new Iphone("(88) 88888-8888", "versao 2.42 ", "123456789", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("- Programando em C# - ");
