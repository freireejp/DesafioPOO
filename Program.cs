using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("(22) 99876-5432", "Tijolo", "9876543210", 2);
Console.WriteLine("Usando o smartphone Nokia:\n");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Iphone iphone = new Iphone("(31) 91234-5678", "13 Pro Max", "0123456789", 5);
Console.WriteLine("Usando o smartphone Iphone:\n");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");