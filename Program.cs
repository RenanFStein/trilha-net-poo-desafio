using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123654789", modelo: "Nokia Tijolão 2000", imei: "123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Dio.me - Aprendendo C#");



Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Iphone 37 x", imei: "123-b", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Dio.me - Aprendendo POO C#");