using ls_poo_features.Repositories;
namespace ls_poo_features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menus menu = new Menus();
            //BookRepository bookRepository = new BookRepository();
            //EditorRepository editorRepository = new EditorRepository();

            int opt = 0;
            //while (opt != 5)
            //{
            //    menu.MenuPrincipal();
            //    Console.WriteLine("Escolha a opção:");
            //    opt = int.Parse(Console.ReadLine()!);
            //    if (opt == 1)
            //        editorRepository.CadastrarEditora();
            //    if (opt == 2)
            //        bookRepository.CadastrarLivro();
            //    if (opt == 3)
            //    {
            //        Console.WriteLine("Insira o nome da editora que desejas buscar:");
            //        string nome = Console.ReadLine()!;
            //        editorRepository.RetornaEditora(nome);
            //    }
            //    if (opt == 4)
            //    {
            //        Console.WriteLine("Insira o nome do livro que desejas buscar:");
            //        string nome = Console.ReadLine()!;
            //        bookRepository.RetornaLivro(nome);
            //    }
            //    if (opt == 5)
            //        return;
            //}

            while (opt != 4)
            {
                menu.MenuAutomovel();
                opt = int.Parse(Console.ReadLine()!);
            }
            
        }
    }
}