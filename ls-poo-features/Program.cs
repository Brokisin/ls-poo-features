using ls_poo_features.Repositories;
namespace ls_poo_features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menus menu = new Menus();

            int opt = 0;
            while (opt != 5)
            {
                menu.MenuPrincipal();
                Console.WriteLine("Escolha a opção:");
                opt = int.Parse(Console.ReadLine());
                if (opt == 1)
                    menu.CadastrarEditora();
                if (opt == 2) 
                    menu.CadastrarLivro();
                if (opt == 3)
                {
                    Console.WriteLine("Insira o nome da editora que desejas buscar:");
                    string nome = Console.ReadLine();
                    menu.RetornaEditora(nome);
                }
                if (opt == 4)
                {
                    Console.WriteLine("Insira o nome do livro que desejas buscar:");
                    string nome = Console.ReadLine();
                    menu.RetornaLivro(nome);
                }
                    
                if (opt == 5)
                    return;
            }
        }
    }
}