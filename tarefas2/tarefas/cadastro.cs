using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace tarefas
{
    

    class cadastro
    {

        //MySqlCommand cmd;
        public MySqlConnection conexao;

        

        string sql;

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
            MySqlConnection conexao;
           

            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;


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

            //sql = "insert into nottarefas values('" + vetorcpf[i] + "','" + vetorcep[i] + "','"+vetor[i]+"')";
            sql = "insert into nottarefa(tarefad, tarefap, tarefat, i) values(@cpf, @cep, @nome, @i)";
            
            //sql = "insert into nottarefa values(@cpf, @cep, @nome)";
            cmd = new MySqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@i", i);

            cmd.ExecuteNonQuery();
            //conexao.Close();


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

            /*MySqlConnection conexao;


            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }
            MySqlCommand cmd;

            sql = "select * from nottarefa";


            //sql = "insert into nottarefa values(@cpf, @cep, @nome)";
            cmd = new MySqlCommand(sql, conexao);


            /*cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@i", i);*/

            /*cmd.ExecuteNonQuery();
            //$resultado = $valores->execute();
            Console.WriteLine(cmd.ExecuteNonQuery());*/

        }

        public void conc()
        {
            MySqlConnection conexao;


            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }

            MySqlCommand cmd;
            //cmd = new MySqlCommand(sql, conexao);

            Console.WriteLine("Escolha a tarefa que foi completa:");

            chec();

            op = int.Parse(Console.ReadLine());

            sql = "delete from nottarefa where i=@op";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@op", op);

            cmd.ExecuteNonQuery();

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
            MySqlConnection conexao;


            conexao = new MySqlConnection("server=localhost;database=tarefas;uid=root");
            try
            {

                conexao.Open();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Nao foi possivel conectar com o banco de dados");
                Console.ReadKey();
                Environment.Exit(0);
            }

            MySqlCommand cmd;


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

            sql = "update nottarefa set tarefat=@nome, tarefad=@cpf, tarefap=@cep where i=@opi";
            cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@opi", opi);

            cmd.ExecuteNonQuery();
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
