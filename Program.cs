using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular IMC");
            Pessoa pessoa1 = new Pessoa(65,1.64);
            pessoa1.mensagem();
        }
    }
