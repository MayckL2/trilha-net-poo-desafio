using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone11 = new("11111111", "iphone11", "123456", 50);
iphone11.Ligar();
iphone11.ReceberLigacao();
iphone11.InstalarAplicativo("zapzap");

Nokia nokia = new("22222222", "nokia", "123456", 50);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("zapzap");