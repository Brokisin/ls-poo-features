using ls_poo_features.Entity;
using System.ComponentModel;

namespace ls_poo_features.Repositories
{
    public class Menus
    {
        Book book = new Book();
        Editor editor = new Editor();
        List<Editor> listaEditora = new List<Editor>();
        List<Book> listaLivros = new List<Book>();
        public void MenuPrincipal()
        {
            Console.WriteLine("#### Menu ####");
            Console.WriteLine("1 Cadastrar Editora: ");
            Console.WriteLine("2 Cadastrar Livro: ");
            Console.WriteLine("3 Pesquisar Editora: ");
            Console.WriteLine("4 Pesquisar Livro: ");
            Console.WriteLine("5 Sair: ");
        }

        public void CadastrarLivro()
        {
            Console.WriteLine("\nInsira os atributos do livro: ");
            Console.WriteLine("Título: ");
            book.Title = Console.ReadLine();
            Console.WriteLine("Código ISBN: ");
            book.ISBNCode = Console.ReadLine();
            Console.WriteLine("Nome da Editora: ");
            editor.SocialName = Console.ReadLine();
            book.Editor = editor;
            listaLivros.Add(book);
        }

        public void CadastrarEditora()
        {
            Console.WriteLine("\nInsira os atributos da editora: ");
            Console.WriteLine("Nome de contato: ");
            editor.ContactName = Console.ReadLine();
            Console.WriteLine("Nome social: ");
            editor.SocialName = Console.ReadLine();
            Console.WriteLine("Telefone para contato: ");
            editor.Cellphone = Console.ReadLine();
            listaEditora.Add(editor);
        }

        public void RetornaLivro(string tituloLivro)
        {
            foreach (var book in listaLivros)
            {
                if (tituloLivro == book.Title)
                {
                    book.Editor = editor;
                    Console.WriteLine("\nLivro buscado:");
                    Console.WriteLine($"{book.Title}\nEditora:{editor.SocialName}\n{editor.ContactName}\n{editor.Cellphone}");
                }
                else
                {
                    Console.WriteLine("\nNão foi encontrado livro com esse nome\n");
                }
            }
        }

        public void RetornaEditora(string nomeEditora)
        {
            foreach (var editor in listaEditora)
            {
                if (nomeEditora == editor.ContactName)
                {
                    Console.WriteLine("\nEditora buscada:");
                    Console.WriteLine($"{editor.SocialName}\n{editor.ContactName}\n{editor.Cellphone}\n");
                }
                else
                {
                    Console.WriteLine("\nNão foi encontrado editora com esse nome\n");
                }
            }
        }
    }
}
