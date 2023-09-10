using ls_poo_features.Entity;
using System.ComponentModel;

namespace ls_poo_features.Repositories
{
    public class Menus
    {   
        public void MenuBooksAndEditor()
        {
            Console.WriteLine("#### Menu ####");
            Console.WriteLine("1. Cadastrar Editora: ");
            Console.WriteLine("2. Cadastrar Livro: ");
            Console.WriteLine("3. Pesquisar Editora: ");
            Console.WriteLine("4. Pesquisar Livro: ");
            Console.WriteLine("5. Sair: ");
        }

        public void MenuAutomovel()
        {
            Console.WriteLine("#### Menu ####");
            Console.WriteLine("1. Cadastrar Autómovel: ");
            Console.WriteLine("--------------");
            Console.WriteLine("2. Mostrar Automóvel cadastrado: ");
            Console.WriteLine("--------------");
            Console.WriteLine("3. Atulizar valor cadastrado: ");
            Console.WriteLine("--------------");
            Console.WriteLine("4. Sair: ");
        }

        public void MenuAtualizarAtributo()
        {
            Console.WriteLine("-> Qual atributo deseja atualizar?");
            Console.WriteLine("--------------");
            Console.WriteLine("-- Montadora --");
            Console.WriteLine("1. Codigo");
            Console.WriteLine("2. Estado");
            Console.WriteLine("3. Razão Social");
            Console.WriteLine("-- Modelo --");
            Console.WriteLine("4. Codigo");
            Console.WriteLine("5. Nome");
            Console.WriteLine("6. Montadora");
            Console.WriteLine("-- Carro --");
            Console.WriteLine("7. Placa");
            Console.WriteLine("8. Modelo");
            Console.WriteLine("9. Ano de fabricação");
        }
    }
}
