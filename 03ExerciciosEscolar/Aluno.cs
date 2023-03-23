using System;

class Aluno
{
    public string nome;
    public double nota1, nota2;

     // Média
     public double media()
     {
        return(nota1 + nota2 / 2);
     }
     // Situção
     public string situacao( double media)
     {
        return media >= 7 ? "Aprovado":"Reprovado";
     }
     // Mensagem
     public void mesangem()
     {
        // Obter média
        double obterMedia = media();

        // Obter situação
        string obterSituacao = situacao(obterMedia);

        Console.WriteLine(nome+" está "+obterSituacao+" com a média "+obterMedia);
     }
}