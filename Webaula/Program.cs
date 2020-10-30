using System;

namespace Webaula
{
    class Program
    {
        static void Main(string[] args)
        {
            _Pessoa Pessoa = new _Pessoa();
            Console.WriteLine("Digite o codigo");

            Pessoa.Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome.......:");
            Pessoa.Nome = Console.ReadLine();

            Console.Write("Digite o cpf........:");
            Pessoa.Cpf = Console.ReadLine();

            Console.Write("Digite o endereço...:");
            Pessoa.Endereco = Console.ReadLine();

            Console.Write("Digite a cidade.....:");
            Pessoa.Cidade = Console.ReadLine();

            Console.Write("Digite o estado.....:");
            Pessoa.Uf = Console.ReadLine();

            Console.Write("Digite o cep........:");
            Pessoa.Cep = Console.ReadLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("   Mostrando o conteúdo da classe Pessoa");
            Console.WriteLine("=========================================");

            Console.WriteLine($"Codigo.......: {Pessoa.Codigo}");
            Console.WriteLine($"Nome.........: {Pessoa.Nome}");
            Console.WriteLine($"Cpf..........: {Pessoa.Cpf}");
            Console.WriteLine($"Edereço......: {Pessoa.Endereco}");
            Console.WriteLine($"Cidade.......: {Pessoa.Cidade}");
            Console.WriteLine($"Estado.......: {Pessoa.Uf}");
            Console.WriteLine($"Cep..........: {Pessoa.Cep}");

            Console.ReadKey();

        }
    }
}
