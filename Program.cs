using DesafioPOO.Models;

// implementado!
            Nokia nokia = new Nokia("123456789", "Modelo Nokia", "111222333444555", 64);
            Iphone iphone = new Iphone("987654321", "Modelo iPhone", "555444333222111", 128);

            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

