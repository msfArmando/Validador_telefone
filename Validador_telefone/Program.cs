using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validador_telefone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phone;
            string padrao = "^\\s*(\\d{2}|\\d{0})[-. ]?(\\d{5}|\\d{4})[-. ]?(\\d{4})[-. ]?\\s*$";
            bool ciclo = true;

            Console.WriteLine("Bem-vindo ao phone validator!");

            while (ciclo)
            {
                Console.WriteLine("Digite o seu número de telefone ou digite X para fechar: ");
                phone = Console.ReadLine();

                if(phone == "x" || phone == "X")
                {
                    ciclo = false;
                }
                else
                {
                    Match resultado = Regex.Match(phone, padrao);

                    if (resultado.Success)
                    {
                        Console.WriteLine("Número de telefone válido!");
                    }
                    else
                    {
                        Console.WriteLine("Número de telefone inválido!");
                    }
                }
            }
        }
    }
}
