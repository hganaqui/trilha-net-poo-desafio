using DesafioPOO.Models;

Nokia celularNokia = new Nokia("16 99999999", "c100", "fdasfasdfasdf", 2);
Iphone celularIphone = new Iphone("16 99999999", "S6", "fdasfasdfasdf", 2);

celularNokia.InstalarAplicativo("Whatsapp");
celularIphone.InstalarAplicativo("Whatsapp");

celularNokia.Ligar();
celularIphone.ReceberLigacao();