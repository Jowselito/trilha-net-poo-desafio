namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string MEI { get; set; }
        private int Memoria { get; set; }
        // Implementado!

        public Smartphone(string numero, string modelo, string mei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            MEI = mei;
            Memoria = memoria;
            // Implementado!
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
                public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}