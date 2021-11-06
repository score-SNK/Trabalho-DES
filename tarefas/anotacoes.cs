using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefas
{
    class anotacoes
    {
        public string[] anot = new string[50];
        public string anota;
        public string[] nom = new string[50];
        public string nomm;
        public int u;
        public int b;
        public int op;


        public void ano()
        {

            Console.WriteLine("Adicione um titulo para a nota");
            nomm = Console.ReadLine();

            Console.WriteLine("Adicione uma anotoção");
            anota = Console.ReadLine();
            

            anot[u] = anota;
            nom[u] = nomm;

            u++;

            Console.WriteLine("Anotoção adicionada");

        }

        public void checaano()
        {
            Console.WriteLine("Selecione uma anotação para ser acessada:");

            for (int b = 0; b < u; b++)
            {

                Console.WriteLine("Nota: " + b + " // " + nom[b]);

            }

            op = int.Parse(Console.ReadLine());

            if (op >= 0 && op < 50)
            {
      
                
                    Console.WriteLine("Titulo: " + nom[op]);
                    Console.WriteLine("Descrição: " + anot[op]);

                

            }
            else
            {
                Console.WriteLine("entrada invalida");
                Console.ReadLine();
            }

        }
    }
}
