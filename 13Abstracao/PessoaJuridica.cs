using System;

class PessoaJuridica : Padrao
{

    //Método obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Juridica R$: " + (valor * 0.2));

    }

}