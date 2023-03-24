using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Classe Livro com os Atributos privados Id (int), Titulo (string), Autor (string), Editora (string) , QuantidadeExemplares (int)

namespace Avaliacao_semana04;

internal class Livros
{

    private int Id;
    private string Titulo;
    private string Autor;
    private string Editora;
    private int QuantidadeExemplares;

    // 2. Construtor Livro com os parâmetros Id (int), Titulo (string), Autor (string), Editora (string) , QuantidadeExemplares (int) e que inicializa os atributos da classe com os valores dos parâmetros.

    public Livros(int id, string titulo, string autor, string editora, int quantidadeExemplares)
    {


        Id = id;
        Titulo = titulo;
        Autor = autor;
        Editora = editora;
        QuantidadeExemplares = quantidadeExemplares;
    }

    // 3. Métodos get e set para os atributos da classe.

    public int getId()
    {


        return Id;
    }

    public void setId(int id)
    {


        Id = id;
    }

    public string getTitulo()
    {


        return Titulo;
    }

    public void setTitulo(string titulo)
    {


        Titulo = titulo;
    }

    public string getAutor()
    {


        return Autor;
    }

    public void setAutor(string autor)
    {


        Autor = autor;
    }

    public string getEditora()
    {


        return Editora;
    }

    public void setEditora(string editora)
    {


        Editora = editora;
    }

    public int getQuantidadeExemplares()
    {


        return QuantidadeExemplares;
    }

    public void setQuantidadeExemplares(int quantidadeExemplares)
    {


        QuantidadeExemplares = quantidadeExemplares;
    }

    // //Métodos
    // EmprestarLivro(int quantidadeEmprestada) - Deverá decrementar a QuantidadeExemplares do livro ;
    // DevolverLivro(int quantidadeDevolvida) - Deverá incrementar a QuantidadeExemplares do livro;

    public void EmprestarLivro(int quantidadeEmprestada)
    {


        QuantidadeExemplares -= quantidadeEmprestada;
    }

    public void DevolverLivro(int quantidadeDevolvida)
    {


        QuantidadeExemplares += quantidadeDevolvida;
    }


}



