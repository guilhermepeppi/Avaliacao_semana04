using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3.Classe interna Biblioteca com os atributos privados Pessoas (List<Pessoa>), Livros (List<Livros>) com get e set

namespace Avaliacao_semana04;

internal class Biblioteca
{

    private List<Pessoa> Pessoa;
    private List<Livros> Livros;

    public Biblioteca()
    {

        Pessoa = new List<Pessoa>();
        Livros = new List<Livros>();
    }

    public List<Pessoa> getPessoas()
    {

        return Pessoa;
    }

    public void setPessoas(List<Pessoa> pessoas)
    {

        Pessoa = pessoas;
    }

    public List<Livros> getLivros()
    {

        return Livros;
    }

    public void setLivros(List<Livros> livros)
    {

        Livros = livros;
    }

    //Métodos:       
    //CadastrarPessoa(Pessoa) - Deverá incluir uma pessoa na lista Pessoas do objeto Biblioteca;
    //CadastrarLivro(Livro) - Deverá incluir um livro na lista de Livros do objeto Biblioteca;
    //EmprestarLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método EmprestarLivro do objeto Livro e Adicionar um Livro na lista LivrosEmprestados do objeto Pessoa através do método AdicionarLivroLista;
    //DevolverLivroBiblioteca(int idLivro, int idPessoa) - Deverá chamar o método DevolverLivro do objeto Livro e Remover um Livro na lista LivrosEmprestados do objeto Pessoa através do método RemoverLivroLista;

    public void CadastrarPessoa(Pessoa pessoa)
    {

    }

    public void CadastrarLivro(Livros livro)
    {

    }

    public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
    {
        //Para a devolução o sistema deve solicitar o Id da Pessoa e o Id do Livro;
        //Se o Id da pessoa não estiver cadastrado deverá exibir a mensagem “Pessoa não cadastrada” e então retornar ao menu principal;
        //Se o Id do livro não estiver cadastrado deverá exibir a mensagem “Livro não cadastrado” e então retornar ao menu principal;
        // Após o usuário informar um ID de livro e Pessoa válidos, mostrar a mensagem: “O Livro {nome do livro} que estava com a pessoa {nome da pessoa} foi devolvido com sucesso” e então retornar para o menu principal.

        foreach (Pessoa pessoa in Pessoa)
        {
            if (pessoa.getId() == idPessoa)
            {
                foreach (Livros livro in Livros)
                {
                    if (livro.getId() == idLivro)
                    {
                        livro.DevolverLivro(idLivro);
                        pessoa.RemoverLivroLista(idLivro);
                        Console.WriteLine("O Livro {0} que estava com a pessoa {1} foi devolvido com sucesso", livro.getTitulo(), pessoa.getNome());
                        return;
                    }
                }
                Console.WriteLine("Livro não cadastrado");
                return;
            }
        }
        Console.WriteLine("Pessoa não cadastrada");
    }

    public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
    {
        //Para o empréstimo o sistema deve solicitar o Id da Pessoa e o Id do Livro;
        //Se o Id da pessoa não estiver cadastrado deverá exibir a mensagem “Pessoa não cadastrada” e então retornar ao menu principal;
        //e o Id do livro não estiver cadastrado deverá exibir a mensagem “Livro não cadastrado” e então retornar ao menu principal;
        //Após o usuário informar um ID de livro e Pessoa válidos, mostrar a mensagem: “O Livro {nome do livro} foi emprestado para a pessoa {nome da pessoa}” e então retornar para o menu principal.

        foreach (Pessoa pessoa in Pessoa)
        {
            if (pessoa.getId() == idPessoa)
            {
                foreach (Livros livro in Livros)
                {
                    if (livro.getId() == idLivro)
                    {
                        livro.EmprestarLivro(idLivro);
                        pessoa.AdicionarLivroLista(livro);
                        Console.WriteLine("O Livro {0} foi emprestado para a pessoa {1}", livro.getTitulo(), pessoa.getNome());
                        return;
                    }
                }
                Console.WriteLine("Livro não cadastrado");
                return;
            }
        }
        Console.WriteLine("Pessoa não cadastrada");
    }

    public void ListarLivrosEmprestados()
    {
        //Nesta opção, o sistema deverá percorrer as listas de todos os livros emprestados de cada pessoa e então os imprimir na tela da seguinte forma: “{Nome do Livro} está emprestado para {nome da pessoa}”, se não houver livros emprestados, deverá exibir a mensagem “Não há livros emprestados”.

        foreach (Pessoa pessoa in Pessoa)
        {
            if (pessoa.getLivrosEmprestados().Count > 0)
            {
                foreach (Livros livro in pessoa.getLivrosEmprestados())
                {
                    Console.WriteLine("{0} está emprestado para {1}", livro.getTitulo(), pessoa.getNome());
                }
            }
            else
            {
                Console.WriteLine("Não há livros emprestados");
            }
        }
    }

    public void ListarLivros()
    {
        //Nesta opção o sistema deverá listar todos os livros cadastrados no sistema, se não houver livros cadastrados, deverá exibir a mensagem “Não há livros cadastrados”.

        if (Livros.Count > 0)
        {
            foreach (Livros livro in Livros)
            {
                Console.WriteLine("Id: {0} - Nome: {1} - Autor: {2} - Editora: {3} - Ano: {4} - Disponível: {5}", livro.getId(), livro.getTitulo(), livro.getAutor(), livro.getEditora());
            }
        }
        else
        {
            Console.WriteLine("Não há livros cadastrados");
        }
    }

    public void ListarPessoas()
    {
        //Nesta opção o sistema deverá listar todos as pessoas cadastrados no sistema, se não houver pessoas cadastradas, deverá exibir a mensagem “Não há pessoas cadastradas”.

        if (Pessoa.Count > 0)
        {
            foreach (Pessoa pessoa in Pessoa)
            {
                Console.WriteLine("Id: {0} - Nome: {1} - Endereço: {2} - Telefone: {3}", pessoa.getId(), pessoa.getNome(), pessoa.getCpf(), pessoa.getTelefone());
            }
        }
        else
        {
            Console.WriteLine("Não há pessoas cadastradas");
        }
    }

}



