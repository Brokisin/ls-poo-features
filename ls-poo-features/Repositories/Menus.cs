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

        public void MenuCadastrarAutomovel()
        {
            Console.WriteLine("1. Cadastrar Montadora: ");
            Console.WriteLine("2. Cadastrar Modelo: ");
            Console.WriteLine("3. Cadastrar Carro: ");
            Console.WriteLine("4. Voltar: ");
        }

        public void MenuAtualizarAutomovel()
        {
            Console.WriteLine("-> Escolha o que será atualizado ");
            Console.WriteLine("--------------");
            Console.WriteLine("1. Atualizar Montadora: ");
            Console.WriteLine("2. Atualizar Modelo: ");
            Console.WriteLine("3. Atualizar Carro: ");
            Console.WriteLine("4. Voltar: ");
        }

        public void MenuAtualizarMontadora()
        {
            Console.WriteLine("-- Montadora --");
            Console.WriteLine("-> Qual atributo será alterado?");
            Console.WriteLine("1. Codigo");
            Console.WriteLine("2. Estado");
            Console.WriteLine("3. Razão Social");
        }

        public void MenuAtualizarModelo()
        {
            Console.WriteLine("-- Modelo --");
            Console.WriteLine("-> Qual atributo será alterado?");
            Console.WriteLine("1. Codigo");
            Console.WriteLine("2. Nome");
        }

        public void MenuAtualizarCarro()
        {
            Console.WriteLine("-- Carro --");
            Console.WriteLine("-> Qual atributo será alterado?");
            Console.WriteLine("1. Placa");
            Console.WriteLine("2. Ano de fabricação");
        }
    }
}
