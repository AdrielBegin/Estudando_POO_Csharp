using System;

class Pessoas{
    public double peso, altura;
    public double calculo()
    {
        return peso/(altura*altura);
    }
    public string situacao(double imc)
    {
        // Varialvel 
        string retorno;
        // Condicional
            if(imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if(imc < 25)
            {
                retorno = "Peso normal";
            }
            else if(imc < 30 )
            {
                retorno = "Acima do peso";
            }
            else if(imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if(imc < 40)
            {
                retorno = "Obesidade II";
            }
            else if (imc > 40)
            {
                retorno = "Obesidade III";
            }
        return retorno;
    }
    public void mensagem ()
    {
        // Obter o cálculo
        double obterCalculo = calculo();
        // Obter o situação
        string obterSituaco = situacao(obterCalculo);
        // Exibir mensagem
        Console.WriteLine("Seu IMC é: "+ obterCalculo);
        Console.WriteLine("Resultado da sua situação é: "+ obterSituaco);
    }

    
}