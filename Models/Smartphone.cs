namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(string numeroLigando)
        {
            Console.WriteLine("Ligando para: " + numeroLigando);
        }

        public void ReceberLigacao(string numeroRecebendo)
        {
            Console.WriteLine("Recebendo ligação de: " + numeroRecebendo);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}