using System;

class Pessoa
{

    //Atributos
    public double peso;

    public double altura;

    //Método
    public double IMC()
    {
        return peso / (altura * altura);
    }

    //Método2
    public string retornoCalculoImc()
    {
        var imc = IMC();

        if (imc < 18.5)
        {
            return "Abaixo do peso ";
        }
        else if (imc < 25)
        {
            return "Peso Normal ";
        }

        else if (imc < 30)
        {
            return "Acima do peso ";
        }

        else if (imc < 35)
        {
            return "Obesidade I";
        }

        else if (imc < 40)
        {
            return "Obesidade II";
        }
        else
            return "Obesidade III";
    }

    //Mensagem
    public void mensagem()
    {
        //Calculo
        double imc = IMC();

        //Situação
        string situacao = retornoCalculoImc();

        //Mensagem
        Console.WriteLine(string.Format("Seu peso é: {0} e seu IMC é: {1} , sua situação é {2}", peso, imc, situacao));
    }

}