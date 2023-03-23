using System;

class Pessoa
{
    // Contrutor executado quando inicia uma classe.
    // E ele é public.
    // Posso criar varios construtores. Porém, como uma caracteristica diferente, ou seja, parametros.

    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }
}