using System;

namespace Pessoa___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CPF cpf = new CPF();
            cpf.nome = "Guilherme";
            System.Console.WriteLine( cpf.Saudar());

            cpf.cpf = "000.000.000-00";
            System.Console.WriteLine(cpf.validarCPF());

        }
    }
}
