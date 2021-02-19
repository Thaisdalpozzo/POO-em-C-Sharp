using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Instanciar o objeto da classe aluno
           Aluno a = new Aluno();
           a.nome = "Thaís";
           a.nota1 = 8;
           a.nota2 = 10;
           a.mensagem();
        }
    }
}
