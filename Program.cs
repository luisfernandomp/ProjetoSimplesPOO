using System;

namespace ProjetoSimplesPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno milena = new Aluno();
            milena.nome = "Milena";
            milena.idade = 16;
            milena.bolsista = false;
            milena.valorMensalidade = 2000;
            milena.mediaFinal = 8.5f;

            Console.WriteLine("Milena: "+milena.verMediaFinal());
            Console.WriteLine("Milena: "+milena.verMensalidade());

            Aluno matheus = new Aluno();
            matheus.nome = "Matheus";
            matheus.idade = 15;

            Console.WriteLine("Aluno Bolsista?");
            matheus.bolsista = matheus.TraduzConsole(Console.ReadLine());

            matheus.percentual = 30;

            matheus.valorMensalidade = 2000;
            matheus.mediaFinal = 8.5f;

            Console.WriteLine("Matheus: "+matheus.verMediaFinal());
            Console.WriteLine("Matheus: "+matheus.verMensalidade()); 
        }       
    }
}
