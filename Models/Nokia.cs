namespace DesafioPOO.Models
{
    // Implementado!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string mei, int memoria):base(numero, modelo, mei, memoria)
        {
        }
        // Implementado!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}