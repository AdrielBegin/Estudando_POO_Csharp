using System;

class Aluno
{
    // Atributos Privete
    private double nota1, nota2;
    // Método Méidia 

    private double media()
    {
        return (nota1+nota2)/2;        
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota");
        //Testando o método de conversão.
        nota1 = Convert.ToInt32(Console.ReadLine());
        // Testando outro método
        nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Média é :" +media());

    }

}
