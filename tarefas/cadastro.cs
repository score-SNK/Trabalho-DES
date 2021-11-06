using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas
{
    class cadastro
    {
        public string nome;
        public string cpf;
        public string cep;



        public string[] vetor = new string[50];

        public string[] vetorcpf = new string[50];
        public string[] vetorcep = new string[50];



        public int i;
        public int op;
        public int opi;
        public int opit;
        
    


        string[] pvetor = new string[50];

        string[] pvetorcpf = new string[50];
        string[] pvetorcep = new string[50];


        public void cad()
        {


            Console.WriteLine("Digite o titulo da tarefa");
            nome = Console.ReadLine();
            Console.WriteLine("Descreva a tarefa");
            cpf = Console.ReadLine();
            Console.WriteLine("Adicione um prazo de conclusão");
            cep = Console.ReadLine();

            Console.WriteLine("Tarefa adicionada");


            vetorcpf[i] = cpf;
            vetorcep[i] = cep;
            vetor[i] = nome;


            idi();


            Console.ReadKey();

        }

        public int idi()
        {
            i++;
            return i;

        }

        public void chec()
        {


            for (int a = 0; a < i ; a++)
            {

                Console.WriteLine("Tarefa: " + a + " // Titulo: " + vetor[a] + " // Prazo: " + vetorcep[a]);

            }

        }

        public void conc()
        {

            Console.WriteLine("Escolha a tarefa que foi completa:");

            chec();

            op = int.Parse(Console.ReadLine());

            if (op >= 0 && op < 50)
            {
                for (int c = op; op < 49; op++)
                {
                    vetor[op] = vetor[op + 1];
                    vetorcpf[op] = vetorcpf[op + 1];
                    vetorcep[op] = vetorcep[op + 1];

                }

                i--;
            }
            else
            {
                Console.WriteLine("entrada invalida");
                Console.ReadLine();
            }
        }

        public void alt()
        {
            Console.WriteLine("Escolha o cadastro para ser alterado");

            chec();
            opi = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da tarefa");
            nome = Console.ReadLine();
            Console.WriteLine("Descreva a tarefa");
            cpf = Console.ReadLine();
            Console.WriteLine("Adicione um prazo de conclusão");
            cep = Console.ReadLine();

            Console.WriteLine("Tarefa alterada");

            vetorcpf[opi] = cpf;
            vetorcep[opi] = cep;

            vetor[opi] = nome;
        }

        public void desc()
        {
            Console.WriteLine("Escolha o cadastro a ser checado");
 
            chec();
            opit = int.Parse(Console.ReadLine());

            if (opit >= 0 && opit <= 49)
            {
                Console.WriteLine("Titulo: " + vetor[opit]);
                Console.WriteLine("Descrição: " + vetorcpf[opit]);
                Console.WriteLine("Prazo: " + vetorcep[opit]);
            }
            else
            {
                Console.WriteLine("Opção invalida");
                Console.ReadLine();
            }



        }
    }
}
