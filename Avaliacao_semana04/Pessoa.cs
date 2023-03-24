using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Classe interna Pessoa com os Atributos privados Id (int), Nome (string), Cpf (string), Telefone (string), LivrosEmprestados (List<Livros>)

namespace Avaliacao_semana04;

internal class Pessoa
{

    private int Id;
    private string Nome;
    private string Cpf;
    private string Telefone;
    private List<Livros> LivrosEmprestados;

    // 3. Construtor Pessoa com os parâmetros Id (int), Nome (string), Cpf (string), Telefone (string) e que inicializa os atributos da classe com os valores dos parâmetros.   

    public Pessoa(int id, string nome, string cpf, string telefone)
    {

        Id = id;
        Nome = nome;
        Cpf = cpf;
        Telefone = telefone;
        LivrosEmprestados = new List<Livros>();
    }

    // 4. Métodos get e set para os atributos da classe.

    public int getId()
    {

        return Id;
    }

    public void setId(int id)
    {

        Id = id;
    }

    public string getNome()
    {

        return Nome;
    }

    public void setNome(string nome)
    {

        Nome = nome;
    }

    public string getCpf()
    {

        return Cpf;
    }

    public void setCpf(string cpf)
    {

        Cpf = cpf;
    }

    public string getTelefone()
    {

        return Telefone;
    }

    public void setTelefone(string telefone)
    {

        Telefone = telefone;
    }

    public List<Livros> getLivrosEmprestados()
    {

        return LivrosEmprestados;
    }

    public void setLivrosEmprestados(List<Livros> livrosEmprestados)
    {

        LivrosEmprestados = livrosEmprestados;
    }

    //Métodos
    //AdicionarLivroLista(Livro) - adiciona um livro na lista de livros emprestados
    //RemoverLivroLista(int idLivro) - remove um livro da lista de livros emprestados

    public void AdicionarLivroLista(Livros livro)
    {

        LivrosEmprestados.Add(livro);
    }

    public void RemoverLivroLista(int idLivro)
    {

        LivrosEmprestados.Remove(LivrosEmprestados.Find(x => x.getId() == idLivro));
    }

}


