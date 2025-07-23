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
        
        private List<Livro> livros = new List<Livro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        private int livroIdCounter = 1;
        private int usuarioIdCounter = 1;
        private int emprestimoIdCounter = 1;
        
        
        
        
        
        
        
        
        
        
        
        
        
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


    }
}
