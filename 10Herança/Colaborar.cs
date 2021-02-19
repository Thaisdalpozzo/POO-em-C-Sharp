using System;

class Colaborar : Pessoa

{
    //Atributos
    private double salario;

    //Construtor 
    public Colaborar(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborar();

    }

    //Método
    private void mensagemColaborar()
    {
        Console.WriteLine("Salário: " + salario);

    }
}