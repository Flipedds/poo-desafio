namespace Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    public object Nome { get; }
    public string Modelo { get; set; }

    public string IMEI { get; set; }
    public int Memoria { get; set; }

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;

    }

    public static void Ligar()
    {
        Console.WriteLine("Ligando....");
    }

    public static void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação....");
    }

    public abstract void InstalarAplicativo(string nome);
}
