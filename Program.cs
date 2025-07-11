using DesafioPOO.Models;


Console.WriteLine("Smartphone: Nokia");
Smartphone Nokia = new Nokia(numero: "123", modelo: "Nokia 3310", imei: "12345", menoria: 32);
Nokia.Ligar();
Nokia.InstalarAplicativo("Clash Of Clãs");

Console.WriteLine();

Console.WriteLine("Smartphone: Iphone");
Smartphone Iphone = new Iphone(numero: "321", modelo: "Iphone 16", imei: "54321", menoria: 255);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Clash Royale");