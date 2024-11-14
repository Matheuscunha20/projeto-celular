using System;

// Classe abstrata Smartphone
public abstract class Smartphone
{
    // Propriedade comum a todos os smartphones
    public string Modelo { get; set; }
    public string SistemaOperacional { get; set; }

    // Método abstrato que será sobrescrito pelas classes filhas
    public abstract void InstalarAplicativo(string nomeAplicativo);
}

// Classe Nokia herda de Smartphone
public class Nokia : Smartphone
{
    // Sobrescrevendo o método InstalarAplicativo para Nokia
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} de forma simples no Nokia.");
    }
}

// Classe Iphone herda de Smartphone
public class Iphone : Smartphone
{
    // Sobrescrevendo o método InstalarAplicativo para Iphone
    public override void InstalarAplicativo(string nomeAplicativo)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeAplicativo} através da App Store no Iphone.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando instâncias de Nokia e Iphone
        Smartphone nokia = new Nokia { Modelo = "Nokia 6.1", SistemaOperacional = "Android" };
        Smartphone iphone = new Iphone { Modelo = "iPhone 13", SistemaOperacional = "iOS" };

        // Instalando aplicativos
        nokia.InstalarAplicativo("WhatsApp");
        iphone.InstalarAplicativo("WhatsApp");
    }
}
