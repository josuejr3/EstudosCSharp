namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; } // público
        private string Modelo { get; set; } // privado
        private string IMEI { get; set; } // privado
        private int Memoria { get; set; } // privado

        public Smartphone(string numero, string modelo, string imei, int memoria)
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
