using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Alfabeto_switch
{
    internal class Alfabeto
    {
        public static void Main(string[] args) {

            // Escolher a letra para ser percorrida no Switch.
            Console.WriteLine("Escreva o numero da letra que você quer saber: ");
            string str = Console.ReadLine().ToLower();

            // Switch para validação da numeração da letra
            switch (str) {
                case "a":
                    Console.WriteLine($"A letra {str} está na posição 1 do alfabeto");
                    break;
                case "b":
                    Console.WriteLine($"A letra {str} está na posição 2 do alfabeto");
                    break;
                case "c":
                    Console.WriteLine($"A letra {str} está na posição 3 do alfabeto");
                    break;
                case "d":
                    Console.WriteLine($"A letra {str} está na posição 4 do alfabeto");
                    break;
                case "e":
                    Console.WriteLine($"A letra {str} está na posição 5 do alfabeto");
                    break;
                case "f":
                    Console.WriteLine($"A letra {str} está na posição 6 do alfabeto");
                    break;
                case "g":
                    Console.WriteLine($"A letra {str} está ma posição 7 do alfabeto");
                    break;
                case "h":
                    Console.WriteLine($"A letra {str} está na posição 8 do alfabeto");
                    break;
                case "i":
                    Console.WriteLine($"A letra {str} está na posição 9 do alfabeto");
                    break;
                case "j":
                    Console.WriteLine($"A letra {str} está na posição 10 do alfabeto");
                    break;
                case "k":
                    Console.WriteLine($"A letra {str} está na posição 11 do alfabeto");
                    break;
                case "l":
                    Console.WriteLine($"A letra {str} está na posição 12 do alfabeto");
                    break;
                case "m":
                    Console.WriteLine($"A letra {str} está na posição 13 do alfabeto");
                    break;
                case "n":
                    Console.WriteLine($"A letra {str} está ma posição 14 do alfabeto");
                    break;
                case "o":
                    Console.WriteLine($"A letra {str} está na posição 15 do alfabeto");
                    break;
                case "p":
                    Console.WriteLine($"A letra {str} está na posição 16 do alfabeto");
                    break;
                case "q":
                    Console.WriteLine($"A letra {str} está na posição 17 do alfabeto");
                    break;
                case "r":
                    Console.WriteLine($"A letra {str} está na posição 18 do alfabeto");
                    break;
                case "s":
                    Console.WriteLine($"A letra {str} está na posição 19 do alfabeto");
                    break;
                case "t":
                    Console.WriteLine($"A letra {str} está na posição 20 do alfabeto");
                    break;
                case "u":
                    Console.WriteLine($"A letra {str} está ma posição 21 do alfabeto");
                    break;
                case "v":
                    Console.WriteLine($"A letra {str} está na posição 22 do alfabeto");
                    break;
                case "w":
                    Console.WriteLine($"A letra {str} está na posição 23 do alfabeto");
                    break;
                case "x":
                    Console.WriteLine($"A letra {str} está na posição 24 do alfabeto");
                    break;
                case "y":
                    Console.WriteLine($"A letra {str} está na posição 25 do alfabeto");
                    break;
                case "z":
                    Console.WriteLine($"A letra {str} está na posição 26 do alfabeto");
                    break;
                default:
                    Console.WriteLine("Valor inválido");
                    break;
            }
        }
    }
}
