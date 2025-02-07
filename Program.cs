using DesafioPOO.Models;

Smartphone Nokia = new Nokia(numero: "1", modelo: "Nokia1", imei: "01", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("");

Smartphone Iphone = new Iphone(numero: "2", modelo: "iphone1", imei: "000000000001", memoria: 128);
Iphone.Ligar();
Iphone.InstalarAplicativo("JogoDoTigrinho");

Smartphone Nokia2 = new Nokia(numero: "3", modelo: "Nokia1", imei: "03", memoria: 128);
Nokia.Ligar();
Nokia.InstalarAplicativo("Telegram");