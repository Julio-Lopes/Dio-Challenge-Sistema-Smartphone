using SistemaSmartphone.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "999999999", modelo: "Modelo1", imei: "1111", memoria: "64GB");
nokia.Ligar();
nokia.InstalarAplicativo(nomeApp: "Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero: "999999999", modelo: "Modelo2", imei: "1111", memoria: "128GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "Telegram");