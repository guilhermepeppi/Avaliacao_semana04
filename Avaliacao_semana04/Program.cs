using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criar um Menu com 7 opções: 
//1 - Cadastrar Pessoa 
//2 - Cadastrar Livro
//3 - Emprestar Livro
//4 - Devolver Livro
//5 - Listar todos os livros
//6 - Listar todas as pessoas cadastradas 
//7 - Listar todos os livros emprestados
//8 - Sair

namespace Avaliacao_semana04;

internal class Program
{

    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();
        int opcao = 0;
        while (opcao != 8)
        {
            Console.WriteLine("1 - Cadastrar Pessoa");
            Console.WriteLine("2 - Cadastrar Livro");
            Console.WriteLine("3 - Emprestar Livro");
            Console.WriteLine("4 - Devolver Livro");
            Console.WriteLine("5 - Listar todos os livros");
            Console.WriteLine("6 - Listar todas as pessoas cadastradas");
            Console.WriteLine("7 - Listar todos os livros emprestados");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    string nome, cpf, telefone;
                    int id = 0;

                    Console.WriteLine("Digite o ID da pessoa");
                    id = int.Parse(Console.ReadLine());

                    foreach (Pessoa auxPessoas in Pessoa)
                    {
                        if (auxPessoas.getId() == auxPessoas.getId())
                        {
                            Console.WriteLine("Pessoa já cadastrada");
                            return;
                        }
                        else
                        {

                            Console.WriteLine("Digite o nome da pessoa");
                            nome = Console.ReadLine();
                            Console.WriteLine("Digite o cpf da pessoa");
                            cpf = Console.ReadLine();
                            Console.WriteLine("Digite o telefone da pessoa");
                            telefone = Console.ReadLine();

                            // Instanciando a pessoa
                            Pessoa pessoa = new Pessoa(id++, nome, cpf, telefone);

                            // Instanciando a biblioteca para guardar os dados da pessoa
                            biblioteca.CadastrarPessoa(pessoa);
                            return;
                        }
                    }
                    break;
                case 2:
                    string titulo, autor, editora;
                    int quantidadeExemplares, idDoLivro = 0;

                    Console.WriteLine("Digite o ID do livro");
                    id = int.Parse(Console.ReadLine());

                    foreach (Livros auxLivros in Livros)
                    {
                        if (auxLivros.getId() == auxLivros.getId())
                        {
                            Console.WriteLine("Livro já cadastrado");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Digite o nome do autor do livro");
                            autor = Console.ReadLine();
                            Console.WriteLine("Digite o titulo do livro");
                            titulo = Console.ReadLine();
                            Console.WriteLine("Digite o autor do livro");
                            editora = Console.ReadLine();
                            Console.WriteLine("Digite a quantidade de exemplares");
                            quantidadeExemplares = int.Parse(Console.ReadLine());

                            // Instanciando o livro
                            Livros livros = new Livros(id++, titulo, autor, editora, quantidadeExemplares);
                            livros.EmprestarLivro(quantidadeExemplares);

                            // Instanciando a biblioteca para guardar o livro
                            biblioteca.CadastrarLivro(livros);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Digite o id da pessoa: ");
                    int idPessoa = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o id do livro: ");
                    int idLivro = int.Parse(Console.ReadLine());
                    biblioteca.EmprestarLivroBiblioteca(idPessoa, idLivro);
                    break;
                case 4:
                    Console.WriteLine("Digite o id da pessoa: ");
                    int idPessoas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o id do livro: ");
                    int idLivros = int.Parse(Console.ReadLine());
                    biblioteca.DevolverLivroBiblioteca(idPessoas, idLivros);
                    break;
                case 5:
                    biblioteca.ListarLivros();
                    break;
                case 6:
                    biblioteca.ListarPessoas();
                    break;
                case 7:
                    biblioteca.ListarLivrosEmprestados();
                    break;
                case 8:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
