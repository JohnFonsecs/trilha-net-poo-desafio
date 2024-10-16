using DesafioPOO.Models;

Smartphone nokia = new Nokia("1234567890", "Nokia 3310", "BBBB1234", 16);
Smartphone iphone = new Iphone("1111111111", "Iphone 13", "DDDDD1234", 64);

nokia.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Facebook");

nokia.Ligar();
iphone.ReceberLigacao();
