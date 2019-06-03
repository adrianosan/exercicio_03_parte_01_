using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_03_parte_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorAplicado = 0;
            int mesInvestir = 0;
            double rendimento = 0;
            double rendimentoTotal = 0;

            Console.WriteLine("Digite  o valor a ser aplicador: ");
            valorAplicado = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de mes da aplicação: ");
            mesInvestir = int.Parse(Console.ReadLine());

            for (int i = 1; i < mesInvestir; i++)
            {
                if (i == 1)
                {
                    rendimento = (valorAplicado * 0.0066) + valorAplicado;
                }

                else
                {
                    rendimentoTotal = (rendimento * 0.0066) + rendimento;
                }
            }

            Console.WriteLine("Valor total do investimento e: {0}", rendimentoTotal.ToString("C"));
            
            
                



                


            
                 
           
         
               
            

            
         
      
        }         
    }
}

