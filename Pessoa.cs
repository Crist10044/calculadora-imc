using System;

class Pessoa
{
    double peso,altura;

    public Pessoa(double peso, double altura)
    {
        this.peso = peso;
        this.altura = altura;
    }

    public double imc()
    {
        return peso/(altura*altura);
    }

    public string resultado(double imc)
    {
        if(imc < 18.5)
        {
            return "abaixo do peso";
        }
        else if(imc < 25)
        {
            return "peso normal";
        }
        else if(imc < 30)
        {
            return "acima do peso";
        }
        else if(imc < 35)
        {
            return "obesidade I";
        }
        else if(imc < 40)
        {
            return "obesidade II";
        }
        else
        {
            return "obesidade III";
        }  
    }

    public void mensagem()
    {
        double obterIMC = imc();
        string obterResultado = resultado(obterIMC);

        // F2 foi usado para mostra apenas 2 casas decimais do IMC
        Console.WriteLine("IMC = {0:F2}",obterIMC);
        Console.WriteLine("Você está {0}",obterResultado);
    }
}