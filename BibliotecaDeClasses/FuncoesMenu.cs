using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BibliotecaDeClasses
{

    public class FuncoesMenu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Gerenciador de Aniverários");
            Console.WriteLine(" ");
            Console.WriteLine("Opção - 01: Adicionar aniversariante");
            Console.WriteLine("Opção - 02: Pesquisar amigo");
            Console.WriteLine("Opçao - 03: SAIR");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    FuncoesMenu.AdicionarAmigo();
                    break;
                case "2":
                    FuncoesMenu.PesquisarAmigo();
                    break;
                case "3":
                    break;
                default:
                    Console.WriteLine("Por favor, escolha uma opção!");
                    Console.Clear();
                    MainMenu();
                    break;
            }
        }
        public static void AdicionarAmigo()
        {
            Console.WriteLine("Digite o nome do amigo que deseja adicionar:");
            string NomeAmigo = Console.ReadLine();
            Console.WriteLine("Digite agora o sobrenome:");
            string SobrenomeAmigo = Console.ReadLine();
            Console.WriteLine("Informe a data de Nascimento: ");
            DateTime DataDeNascimento = DateTime.Parse(Console.ReadLine());

            Amigo a1 = new Amigo(NomeAmigo, SobrenomeAmigo, DataDeNascimento);            

            BaseDeDados.SalvarAmigo(a1);
            Console.WriteLine("Amigo Adicionado na lista!");
            MostrarAmigo();
            if (DataDeNascimento.Month >= DateTime.Now.Month)
            {
                DateTime proxAniversario = new DateTime(DateTime.Now.Year, DataDeNascimento.Month, DataDeNascimento.Day);
                TimeSpan aniversario = proxAniversario.Subtract(DateTime.Today);
                Console.WriteLine("Faltam " + aniversario.Days + " dias para o aniversário de  " + NomeAmigo);
            }
            else
            {
                DateTime proxAniversario = new DateTime(DateTime.Now.Year, DataDeNascimento.Month, DataDeNascimento.Day);
                TimeSpan aniversario = proxAniversario.Subtract(DateTime.Today);
                Console.WriteLine("Faltam " + (365 + aniversario.Days) + " dias para o aniversário de " + NomeAmigo);
            }
            MainMenu();
        }   

        

        public static void PesquisarAmigo()
        {
            Console.Clear();

            Console.WriteLine("***Pesquisa de amigos***");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o nome do amigo que deseja saber o aniversário");

            string NomeAmigo = Console.ReadLine();

            var pesquisaNome = BaseDeDados.AmigosListados().Where(amigo => amigo.Nome.Contains(NomeAmigo));

            if (pesquisaNome != null)
            {
                Console.WriteLine("Amigo encontrado");

                foreach (var amigo in pesquisaNome)
                {
                    Console.WriteLine(" Nome: " + amigo.Nome + " " + amigo.Sobrenome);
                    Console.WriteLine(" Nascimento: " + amigo.DataDeNascimento);
                }
            }
            else
            {
                Console.WriteLine("Amigo não encontrado");
            }
            MainMenu(); 
            
        }
        public static void MostrarAmigo()
        {
            Console.Clear();

            if (BaseDeDados.AmigosListados() == null)
                Console.WriteLine("Parece que ninguem foi cadastrado ainda!");
            else
            {
                foreach (var amigo in BaseDeDados.AmigosListados())
                {
                    Console.WriteLine($" Nome: {amigo.Nome} " +
                        $" Nascido em: {amigo.DataDeNascimento} ");
                }
            }
        }
        
    }
}
