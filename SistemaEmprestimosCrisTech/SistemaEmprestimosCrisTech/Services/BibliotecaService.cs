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




        #region Métodos Livros

        private void AdicionarLivro()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            livros.Add(new Livro { Id = livroIdCounter ++, Titulo = titulo, Autor = autor});
            Console.WriteLine("Livro adicionado com sucesso!");
        }

        private void ListarLivros()
        {
            Console.WriteLine("\nLista de Livros: ");

            foreach (Livro livro in livros)
            {
                string status = livro.Disponivel ? "Disponível" : "Emprestado";
                Console.WriteLine($"Id: {livro.Id} | Título: {livro.Titulo} | Autor: {livro.Autor} | {status}");
            }
        }

        private void AtualizarLivro()
        {
            Console.WriteLine("Id do livro a atualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Livro livro = livros.FirstOrDefault(l => l.Id == id); //Esse código procura o primeiro objeto do tipo Livro na lista livros cujo Id seja igual ao valor da variável id; se não encontrar, atribui null à variável livro.
        
            if( livro != null )
            {
                Console.Write("Novo Título: ");
                livro.Titulo = Console.ReadLine();

                Console.Write("Novo Autor: ");
                livro.Autor = Console.ReadLine();

                Console.WriteLine("Livro atualizado!");
            }
            else
            {
                Console.WriteLine("Livro não localizado!");
            }
        }

        private void RemoverLivro()
        {
            Console.WriteLine("Id do livro a remover: ");
            int id = Convert.ToInt32(Console.ReadLine());

            livros.RemoveAll(l => l.Id == id);
            Console.WriteLine("Livro removido!");
        }

        #endregion


        #region Métodos Usuários

        private void AdicionarUsuario()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            usuarios.Add(new Usuario { Id = usuarioIdCounter++, Nome = nome, Email = email });
            Console.WriteLine("Usuário adicionado com sucesso!");
        }

        private void ListarUsuarios()
        {
            Console.WriteLine("\nLista de Usuários: ");

            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.Id} | Nome: {usuario.Nome} | Email: {usuario.Email}");
            }
        }

        private void AtualizarUsuario()
        {
            Console.WriteLine("Id do usuário a atualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Usuario usuario = usuarios.FirstOrDefault(u => u.Id == id);
            
            if (usuario != null)
            {
                Console.Write("Novo Nome: ");
                usuario.Nome = Console.ReadLine();

                Console.Write("Novo Email: ");
                usuario.Email = Console.ReadLine();

                Console.WriteLine("Usuário atualizado!");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado!");
            }
        }

        private void RemoverUsuario() 
        {
            Console.WriteLine("ID do usuário a remover: ");
            int id = Convert.ToInt32(Console.ReadLine());

            usuarios.RemoveAll(u => u.Id == id);
            Console.WriteLine("Usuário removido!");
        }

        #endregion

        #region Métodos Empréstimos

        private void AdicionarEmprestimo()
        {
            Console.Write("Id do  Livro:  ");
            int livroId = Convert.ToInt32(Console.ReadLine());

            Livro livro = livros.FirstOrDefault(l => l.Id == livroId && l.Disponivel);

            if (livro != null) 
            {
                Console.WriteLine("Livro não disponível ou não encontrado!");
                return;
            }

            Console.WriteLine("Id do Usuário: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            if (!usuarios.Any(u => u.Id == usuarioId))
            {
                Console.WriteLine("Usuário não encontrado!");
                return;
            }

            emprestimos.Add(new Emprestimo { Id = emprestimoIdCounter++, LivroId = livroId, UsuarioId = usuarioId});

            livro.Disponivel = false;

            Console.WriteLine("Empréstimo registrado!");
        }

        private void ListarEmprestimosAtivos()
        {
            List<Emprestimo> emprestimosAtivos = emprestimos.Where(e => e.DataDevolucao == null).ToList();

            foreach(Emprestimo emprestimo in emprestimosAtivos)
            {
                Usuario usuario = usuarios.FirstOrDefault(u => u.Id == emprestimo.UsuarioId);
                Livro livro = livros.FirstOrDefault(l => l.Id == emprestimo.LivroId);

                Console.WriteLine($"Id Empréstimo: {emprestimo.Id} | Livro: {livro.Titulo} | Usuário: {usuario.Nome} | Data Empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()}");
            }
        }

        private void DevolverLivro()
        {
            Console.WriteLine("Id do Empréstimo: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Emprestimo emprestimo = emprestimos.FirstOrDefault(e => e.Id == id && e.DataDevolucao == null);

            if (emprestimo == null)
            {
                Console.WriteLine("Empréstimo não  encontrado ou já devolvido!");
                return;
            }

            emprestimo.DataDevolucao = DateTime.Now;

            Livro livro = livros.FirstOrDefault(l => l.Id == emprestimo.LivroId);
            livro.Disponivel = true;

            Console.WriteLine("Livro devolvido com sucesso!");
        }

        private void HistoricoEmprestimosUsuario()
        {
            Console.WriteLine("Id do Usuário: ");
            int id = Convert.ToInt32(Console.ReadLine());


        }

        #endregion

    }
}
