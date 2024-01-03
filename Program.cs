using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia (numero: "12345678", modelo: "a00", imei: "asdfghjkl10", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("instagram");

Console.WriteLine("\n");
Console.WriteLine("-----------------------------------------------------------\n");


Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone (numero: "98765432", modelo: "I15", imei: "qwertyuiop20", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");