using System;

class Pessoa
{
    // Atributo
    private string nome = "Bem-Vindo(a)!";

    //Construtor

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}