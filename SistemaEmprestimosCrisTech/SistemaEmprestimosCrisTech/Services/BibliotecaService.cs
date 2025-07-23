using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimosCrisTech.Services
{
    class BibliotecaService
    {
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
                        ListarLivro();
                        break;
                    case 3:
                        AtualizarLivro();
                        break;
                    case 4:
                        RemoverLivro();
                        break;
                    case 0:
                        MenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }

        private void MenuUsuarios() 
        {
        
        }

        private void MenuEmprestimos()
        { 
        
        }


    }
}
