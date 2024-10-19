using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "987654321", modelo: "10", imei: "192837465", memoria: 32);
Smartphone iphone = new Iphone(numero: "123456789", modelo: "5", imei: "918273645", memoria: 64);

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
nokia.ReceberLigacao(numeroRecebendo: iphone.Numero);
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");
Console.WriteLine("---------------------------------");
Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone: ");
iphone.Ligar(numeroLigando: nokia.Numero);
iphone.InstalarAplicativo("Whatsapp");