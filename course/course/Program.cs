using System;
using System.Globalization;

namespace course
{
    class Program
    {
        static void Main (string[] args) {

            sbyte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483649L;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            n1++;

            int min = int.MinValue;
            int max = int.MaxValue;
            sbyte val_sbyte = sbyte.MinValue;
            decimal val_max_decimal = decimal.MaxValue;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(val_sbyte);
            Console.WriteLine(val_max_decimal);

            // Saída de dados em C#
            Console.Write("Bom dia.");
            Console.WriteLine("Boa tarde");
            Console.Write("Boa noite.");
            Console.WriteLine();
            Console.WriteLine("#######################################");
            Console.WriteLine();

            // Imprimindo variáveis.
            string nome1 = "Maria Prado";
            char genero2 = 'F';
            int idade = 32;
            double saldo = 10.35784;

            Console.WriteLine(genero2);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome1);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            // Placeholders, concatenação e interpolação
            int idade1 = 32;
            double saldo1 = 10.35784;
            string nome2 = "Maria Prado";

            //Placeholders
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", 
                nome2, idade1, saldo1);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2}.");

            //Concatenação
            Console.WriteLine(nome + " tem" + idade + " anos e tem saldo igual a " + saldo.ToString("f2", CultureInfo.InvariantCulture) + " reais.");
            




                 
        }
    }
}
