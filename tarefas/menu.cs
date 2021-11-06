using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas
{
    class menu
    {
        public string Menu()
        {
            Console.Clear();
            Console.WriteLine("1 -Adicionar tarefa");
            Console.WriteLine("2 -Checar tarefas");
            Console.WriteLine("3 -Concluir tarefa");
            Console.WriteLine("4 -Alterar tarefa");
            Console.WriteLine("5 -Descrever tarefa");
            Console.WriteLine("6 -Adicione uma anotação");
            Console.WriteLine("7 -Mostrar todas as anotações");
            Console.WriteLine("Q -Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();
           
        }
    }
}
