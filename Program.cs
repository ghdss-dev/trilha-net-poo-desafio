using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program {

    static void Main(string[] args) {

        Smartphone meuIphone = new Iphone("123456789", "iPhone 12", "123456789012345", 64);
        Smartphone meuNokia = new Nokia("987654321", "Nokia 3310", "543210987654321", 16);

        meuIphone.Ligar(); 
        meuIphone.ReceberLigacao(); 
        meuIphone.InstalarAplicativo("WhatsApp");

        meuIphone.Ligar();
        meuNokia.ReceberLigacao(); 
        meuNokia.InstalarAplicativo("Telegram");
    }
}