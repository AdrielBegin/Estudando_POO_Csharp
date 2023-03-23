using System;

class Pessoa
{
    // Atributo igual a caracteristica
    public string nome;
    public int idade;
    // Métodos são funções, ações 
    // Não retorno de algo
    public void mensagem()
    {
        Console.WriteLine("Ola "+nome+" você tem "+idade+" anos");
    }

}