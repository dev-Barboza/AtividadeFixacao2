using System;

class Ingresso
{
    public float ValorIngresso { get; set; }

    public void ImprimirValor()
    {
        System.Console.WriteLine("O valor do ingresso é R$ " + ValorIngresso);
    }
}