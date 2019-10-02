using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);

            Lista<string> cursos = new Lista<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            Lista<ContaCorrente> contas = new Lista<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));

            Console.ReadKey();
        }

        public static void TestaArrayInt()
        {
            int[] idades = new int[] { 15, 28, 35, 50, 28 };

            // Exibindo cada item do array
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Valor no indice {i}: {idade}");
            }

            // Calculando a média de idades
            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                acumulador += idades[i];
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"Média das idades: {media}");
        }

        public static void TestaListaContaCorrente()
        {
            // Usando a classe ListaDeContaCorrente
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente[] contas = new ContaCorrente[]
            {

            };

            lista.AdicionarVarios(
                new ContaCorrente(100, 40010),
                new ContaCorrente(101, 40011),
                new ContaCorrente(102, 40012),
                new ContaCorrente(103, 40013)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente conta = lista[i];
                Console.WriteLine($"{conta.Agencia}/{conta.Numero}");
            }
        }
    }
}
