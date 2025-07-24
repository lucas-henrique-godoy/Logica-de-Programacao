using SistemaEmprestimosCrisTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimosCrisTech.Services
{
    class BibliotecaService
    {
        
        private List<Livro> livros = new List<Livro>(); //Variável de lista que guardará os livros
        private List<Usuario> usuarios = new List<Usuario>(); //Variável de lista que guardará os usuários
        private List<Emprestimo> emprestimos = new List<Emprestimo>(); //Variável de lista que guardará os empréstimos

        private int livroIdCounter = 1; //Variável que irá incrementar os ids de livros
        private int usuarioIdCounter = 1;//Variável que irá incrementar os ids de usuários
        private int emprestimoIdCounter = 1;//Variável que irá incrementar os ids de empréstimos



        public void MenuPrincipal() 
        {
            while (true)
            {
                Console.WriteLine("\n ========== MENU BIBLIOTECA ==========");
                Console.WriteLine("1. Gerenciar Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("3. Gerenciar Empréstimos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuLivros();
                        break;
                    case 2:
                        MenuUsuarios();
                        break;
                    case 3:
                        MenuEmprestimos();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }

        private void MenuLivros()
        {
            while (true)
            {
                Console.WriteLine("\n ========== Gerencimento de Livros ==========");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Atualizar Livro");
                Console.WriteLine("4. Remover Livro");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        ListarLivros();
                        break;
                    case 3:
                        AtualizarLivro();
                        break;
                    case 4:
                        RemoverLivro();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }

        private void MenuUsuarios() 
        {
            while (true)
            {
                Console.WriteLine("\n ========== Gerencimento de Usuários ==========");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Atualizar Usuário");
                Console.WriteLine("4. Remover Usuário");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        AtualizarUsuario();
                        break;
                    case 4:
                        RemoverUsuario();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }

        private void MenuEmprestimos()
        {
            while (true)
            {
                Console.WriteLine("\n ========== Gerencimento de Empréstimos ==========");
                Console.WriteLine("1. Adicionar Empréstimo");
                Console.WriteLine("2. Listar Empréstimos Ativos");
                Console.WriteLine("3. Devolver Livro");
                Console.WriteLine("4. Histórico de Empréstimos por Usuário");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarEmprestimo();
                        break;
                    case 2:
                        ListarEmprestimosAtivos();
                        break;
                    case 3:
                        DevolverLivro();
                        break;
                    case 4:
                        HistoricoEmprestimosUsuario();
                        break;
                    case 0:
                        return;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }


        
        
        //Métodods Livros
        private void AdicionarLivro()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            livros.Add(new Livro { Id = livroIdCounter ++, Titulo = titulo, Autor = autor});
            Console.WriteLine("Livro Adicionado com sucesso!");
        }

        private void ListarLivros()
        {
            Console.WriteLine("\nLista de Livros:");

            foreach (Livro livro in livros)
            {
                string status = livro.Disponivel ? "Disponível" : "Emprestado";
                Console.WriteLine($"Id: {livro.Id} | Título: {livro.Titulo} | Autor: {livro.Autor} | ");
            }
        }


    }
}
