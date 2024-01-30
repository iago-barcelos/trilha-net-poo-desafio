using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: "1234", modelo: "model1", imei: "4321", memoria: 10);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("tigrinho");


Smartphone iphone = new Iphone(numero: "5678", modelo: "model2", imei: "8765", memoria: 10);

iphone.Ligar();
iphone.InstalarAplicativo("YouTube");
iphone.ReceberLigacao();