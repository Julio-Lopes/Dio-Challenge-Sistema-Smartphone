namespace SistemaSmartphone.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get;}
        private string IMEI { get; }
        private string Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
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