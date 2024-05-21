using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_357
{
 internal class Program
 {
  static void Main(string[] args)
  {

   Funcionario[] funcionarios = new Funcionario[5];
   

   for (int iterador = 0; iterador < 5; iterador++){
    Console.Write($"Digite o {iterador + 1}° nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("-------------------------");
    Console.Write("Entre com os salarios: ");
   double salario = double.Parse(Console.ReadLine());
    Console.WriteLine("-------------------------");


    funcionarios[iterador] = new Funcionario(nome, salario);
   }

   Console.WriteLine("Relação dos Funcionarios");
for(int iterador = 0; iterador < 5; iterador++){
    Console.WriteLine($"{funcionarios[iterador].Nome} - {funcionarios[iterador].Salario}");
   }
  }


 }
}
