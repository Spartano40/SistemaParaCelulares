using DesafioPOO.Models;

Console.WriteLine ( " ======= Celular 1====== " );
  Smartphone nokia  =  new Nokia ( " (11)91111-0000 " , " G21 " , " IMEI:1234567890 " , 64 );
  nokia.InstalarAplicativo ( " WhatsApp " );
 nokia.Ligar ();
nokia.ReceberLigacao ();

Console.WriteLine ();

Console.WriteLine ( " ======= Celular 2====== " );
Iphone  iphone  = new Iphone ( " (11)92222-0000 " , " Iphone 14 Pro " , " IMEI:1239874560 " , 128 );  
iphone.InstalarAplicativo ( " Avenida " );
iphone.Ligar ();
iphone.ReceberLigacao ();

// TODO: Realizar os testes com as classes Nokia e Iphone