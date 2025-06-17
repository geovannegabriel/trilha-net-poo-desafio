namespace DesafioPOO.Models
{
    // Feito: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Feito: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando '{nomeApp}' no Iphone {Modelo} com Imei {Imei}.");
        }
    }
}