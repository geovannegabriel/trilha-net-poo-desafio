using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Novo", imei: "123654", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("ZapZap");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "163956", modelo: "Modelo Mais Novo", imei: "128874", memoria: 32);
        iphone.Ligar();
        iphone.InstalarAplicativo("Youtube");
    }
}