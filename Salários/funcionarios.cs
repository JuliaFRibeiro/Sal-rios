using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salários
{
    class funcionarios
    {
        //declaração das variaveis classe
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int Id { get; set; }

        //declaração do construtor
        public funcionarios(string nome, double salario, int id)
        {
            Nome = nome;
            Salario = salario;
            Id = id;
        }
        //mostra os funcionários em lista
        public override string ToString()
        {
            return Id + " , " + Nome + " , " + Salario;
        }
        //função para aumentar o salario
        public void AumentarSalario(double porcentagem)
        {
            Salario = Salario * porcentagem / 100;
        }
    }
}

