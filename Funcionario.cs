using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_357
{
 internal class Funcionario
 {
public string Nome { get; set; }
public double Salario { get; set; }

public Funcionario(string nome, double salario){
   Nome = nome;
   Salario = salario;
   AplicarAumento();
  }
private void AplicarAumento(){
   Salario = Salario * 1.08;
  }

 }
}
