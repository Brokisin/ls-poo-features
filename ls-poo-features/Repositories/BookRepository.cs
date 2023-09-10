using ls_poo_features.Entity;

namespace ls_poo_features.Repositories
{
    public class BookRepository
    {
        Book book = new Book();
        Editor editor = new Editor();
        List<Editor> listaEditora = new List<Editor>();
        List<Book> listaLivros = new List<Book>();
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
    }
}
