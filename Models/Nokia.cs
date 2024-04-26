namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando...");
            Thread.Sleep(1000);
            Console.WriteLine($"Instalação com sucesso do aplicativo {nomeApp} no Nokia");
        }
    }
}