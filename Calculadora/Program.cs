using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
           double valor1 = 0;
           double valor2 = 0;
            double valor3 = 0;
           

            
            Console.WriteLine("Digite o primeiro valor: ");
            
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("  Qual operação você quer fazer?");
            Console.WriteLine("    1- Soma");
            Console.WriteLine("    2- Subtração");
            Console.WriteLine("    3- Divisão");
            Console.WriteLine("    4- Multiplicação");
            Console.WriteLine("    5- Nada, só estou dando uma olhadinha.");

            //Console.WriteLine("digite sua opção:");
            //opc = Console.ReadLine();
            /*if (opc == "1")
            {
                Console.WriteLine("O resultado é:" + (valor1 + valor2));
                Console.ReadKey();
            }
            else
            if(opc == "2")
            {
                Console.WriteLine("O resultado é:" + (valor1 -valor2));
                Console.ReadKey();
            }
            else
            if(opc == "3")
            {
                Console.WriteLine("O resultado é:" + (valor1 / valor2));
                Console.ReadKey();
            }//
            else
            if (opc == "4")
            {
                Console.WriteLine("O resultado é:" + (valor1 * valor2));
                Console.ReadKey();
            }
            else
                Environment.Exit(0);
            
            
            /*
            */
             switch (Console.ReadLine())
             {
                 case "1":
                     Console.WriteLine("O resultado é:" + (valor1 + valor2));
                     break;
                 case "2":
                     Console.WriteLine("O resultado é:" + (valor1 - valor2));
                     break;
                 case "3":
                     Console.WriteLine("O resultado é:" + (valor1 / valor2));
                     break;
                 case "4":
                     Console.WriteLine("O resultado é:" + (valor1 * valor2));
                     break;

                 case "5":
                     
                     break;
                    
             }
            Console.ReadKey();
           




        }

       
    }
}
