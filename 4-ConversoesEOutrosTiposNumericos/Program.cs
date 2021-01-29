using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto4");

            double salario;
            salario = 1200.50;

            // int suporta 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //o long suporta 64 bits
            long idade;
            idade = 13000000000;
            Console.WriteLine(idade);

            //o short suporta 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;

            Console.WriteLine(altura);






            Console.ReadLine();
        }
    }
}
