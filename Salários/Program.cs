using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salários
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando o vetor
            funcionarios[] vect = new funcionarios[100];
            //solicita o numero de Funcionarios
            Console.WriteLine("Digite o numero de Funcionarios a ser registrado: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(" ");
                //informações sobre os funcionarios
                Console.WriteLine($"Funcionario#{i}");
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario:");
                double salario = double.Parse(Console.ReadLine());

                vect[id] = new funcionarios(nome, salario, id);
            }
            Console.WriteLine("");
            //informa qual funcionário que receberá o aumento
            Console.WriteLine("Id do funcionário receberá aumento: ");
            int id2 = int.Parse(Console.ReadLine());

            if (vect[id2] != null)
            {
                //conta que realiza o aumento
                Console.WriteLine("Porcentagem de aumento de salario: ");
                double porcentagem = double.Parse(Console.ReadLine());
                porcentagem = porcentagem + 100;
                vect[id2].AumentarSalario(porcentagem);
            }
            else
            {
                //caso digite um id inexistente
                Console.WriteLine("Este funcionario não existe!");
            }
            //atualizando a lista dos funcinários com o aumento realizado
            Console.WriteLine("Lista atualizada dos funcionarios da Bravo: ");
            for (int i = 0; i < x + 1; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
