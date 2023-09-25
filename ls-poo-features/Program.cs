using ls_poo_features.Repositories;
namespace ls_poo_features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menus menu = new Menus();
            AutomovelRepository _repository = new AutomovelRepository();
            //BookRepository bookRepository = new BookRepository();
            //EditorRepository editorRepository = new EditorRepository();



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
            int opt = 0;
            while (opt != 4)
            {
                menu.MenuAutomovel();
                opt = int.Parse(Console.ReadLine()!);
                if (opt == 1)
                {
                    _repository.CadastrarMontadora();
                    _repository.CadastrarModelo();
                    _repository.CadastrarCarro();
                }
                if (opt == 2)
                    _repository.MostrarAtributosAutomovel();
                if (opt == 3)
                {
                    menu.MenuAtualizarAutomovel();
                    int opt2 = int.Parse(Console.ReadLine()!);
                    if (opt2 == 1)
                    {
                        Console.WriteLine("Insira o código da montadora que deseja alterar: ");
                        int codMont = int.Parse(Console.ReadLine()!);

                        if (!_repository.BuscarMontadora(codMont))
                        {
                            Console.WriteLine("\nNão foi encontrado nenhuma Montadora.\n");
                            return;
                        }
                        menu.MenuAtualizarMontadora();
                        int opt3 = int.Parse(Console.ReadLine()!);
                        if (opt3 == 1)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            int novoCodigo = int.Parse(Console.ReadLine()!);
                            _repository.AtualizarMontadoraCodigo(codMont, novoCodigo);
                        }
                        if (opt3 == 2)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            string novoEstado = Console.ReadLine()!;
                            _repository.AtualizarMontadoraEstado(codMont, novoEstado);

                        }
                        if (opt3 == 3)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            string novaRazao = Console.ReadLine()!;
                            _repository.AtualizarMontadoraRazaoSocial(codMont, novaRazao);
                        }
                    }
                    if (opt2 == 2)
                    {
                        Console.WriteLine("Insira o código do modelo que deseja alterar: ");
                        int codModelo = int.Parse(Console.ReadLine()!);

                        if (!_repository.BuscarModelo(codModelo))
                        {
                            Console.WriteLine("\nNão foi encontrado nenhum Modelo.\n");
                            return;
                        }

                        menu.MenuAtualizarModelo();
                        int opt3 = int.Parse(Console.ReadLine()!);
                        if (opt3 == 1)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            int novoCodigo = int.Parse(Console.ReadLine()!);
                            _repository.AtualizarModeloCodigo(codModelo, novoCodigo);
                        }
                        if (opt3 == 2)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            string novoNome = Console.ReadLine()!;
                            _repository.AtualizarModeloNome(codModelo, novoNome);
                        }
                    }
                    if (opt2 == 3)
                    {
                        Console.WriteLine("Insira a placa do carro que deseja alterar: ");
                        string placa = Console.ReadLine()!;

                        if (!_repository.BuscarCarro(placa))
                        {
                            Console.WriteLine("\nNão foi encontrado nenhum Carro.\n");
                            return;
                        }

                        menu.MenuAtualizarCarro();
                        int opt3 = int.Parse(Console.ReadLine()!);
                        if (opt3 == 1)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            string novaPlaca = Console.ReadLine()!;
                            _repository.AtualizarCarroPlaca(placa, novaPlaca);
                        }
                        if (opt3 == 2)
                        {
                            Console.WriteLine("Insira o novo valor: ");
                            int novoAnoFabricacao = int.Parse(Console.ReadLine()!);
                            _repository.AtualizarCarroAnoFabricacao(placa, novoAnoFabricacao);
                        }
                    }
                }
            }
            Console.WriteLine("\nQuitting...");
        }
    }
}