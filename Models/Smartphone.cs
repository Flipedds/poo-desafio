namespace Models;

public abstract class Smartphone
{
    private string _numero;
    public string Numero
    {
        get { return _numero; }
        set { _numero = value != "" ? _numero = value : throw new ArgumentException("Número inválido !"); }
    }

    private string _modelo;
    public string Modelo
    {
        get { return _modelo; }
        set { _modelo = value != "" ? _modelo = value : throw new ArgumentException("Modelo inválido !"); }
    }

    private string _imei;
    public string IMEI
    {
        get { return _imei; }
        set { _imei = value != "" ? _imei = value : throw new ArgumentException("Imei inválido !"); }
    }

    private int _memoria;
    public int Memoria
    {
        get { return _memoria; }
        set { _memoria = value > 0 ? _memoria = value : throw new ArgumentException("Memória inválida !");}
    }

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
