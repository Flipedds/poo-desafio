namespace Models;

public class Nokia: Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Aplicativo {nome} instalado com sucesso no seu Nokia !!!!!!");
    }
}
