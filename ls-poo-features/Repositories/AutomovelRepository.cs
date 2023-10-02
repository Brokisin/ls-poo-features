using ls_poo_features.Entity;
using ls_poo_features.Entity.Automovel;

namespace ls_poo_features.Repositories
{
    public class AutomovelRepository
    {
        Montadora montadora = new Montadora();
        Modelo modelo = new Modelo();
        Carro carro = new Carro();
        List<Montadora> listaMontadora = new List<Montadora>();
        List<Modelo> listaModelo = new List<Modelo>();
        List<Carro> listaCarro = new List<Carro>();

        public void MostrarAtributosAutomovel()
        {
            foreach (var item in listaMontadora)
            {
                Console.WriteLine("\n" + montadora);
            }
            foreach (var item in listaModelo)
            {
                Console.WriteLine("\n" + modelo);
            }
            foreach (var item in listaCarro)
            {
                Console.WriteLine("\n" + carro + "\n");
            }
        }

        public void CadastrarMontadora()
        {
            try
            {
                Console.WriteLine("### Montadora ###");
                Console.WriteLine("-> Codigo:");
                int codigoMontadora = int.Parse(Console.ReadLine()!);
                Console.WriteLine("-> Razão Social:");
                string razaoSocial = Console.ReadLine()!;
                Console.WriteLine("-> Estado:");
                string estado = Console.ReadLine()!;

                montadora = new Montadora(codigoMontadora, estado, razaoSocial);
                listaMontadora.Add(montadora);

                Console.WriteLine("\nCadastro finalizado!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro.\nErro: {ex}");
            }
        }

        public void CadastrarModelo()
        {
            try
            {
                if (listaMontadora.Count == 0)
                {
                    Console.WriteLine("\nNão há nenhuma montadora cadastrada para fazer vínculo a este modelo.\n");
                    return;
                }
                Console.WriteLine("### Modelo ###");
                Console.WriteLine("-> Codigo:");
                int codigoModelo = int.Parse(Console.ReadLine()!);
                Console.WriteLine("-> Nome do Modelo:");
                string nomeModelo = Console.ReadLine()!;
                Console.WriteLine("-> Código da Montadora:");
                int razaoSocial = int.Parse(Console.ReadLine()!);

                if (!VerificarMontadoraExistente(razaoSocial))
                {
                    Console.WriteLine("Não há Montadora cadastrada com esse código.");
                    return;
                }

                modelo = new Modelo(codigoModelo, nomeModelo, montadora);
                listaModelo.Add(modelo);

                Console.WriteLine("\nCadastro finalizado!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro.\nErro: {ex}");
            }
        }

        public void CadastrarCarro()
        {
            try
            {
                if (listaModelo.Count == 0)
                {
                    Console.WriteLine("\nNão há nenhum modelo cadastrado para fazer vínculo a este carro.\n");
                    return;
                }
                Console.WriteLine("### Carro ###");
                Console.WriteLine("-> Placa:");
                string placa = Console.ReadLine()!;
                Console.WriteLine("-> Ano de fabricação:");
                int anoFabricacao = int.Parse(Console.ReadLine()!);
                Console.WriteLine("-> Código do Modelo:");
                int codigoModelo = int.Parse(Console.ReadLine()!);

                if (!VerificarModeloExistente(codigoModelo))
                {
                    Console.WriteLine("Não há Modelo cadastrado com esse código.");
                    return;
                }

                carro = new Carro(placa, modelo, anoFabricacao);
                listaCarro.Add(carro);

                Console.WriteLine("\nCadastro finalizado!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro.\nErro: {ex}");
            }
        }

        private bool VerificarMontadoraExistente(int codigoMontadora)
        {
            foreach (var item in listaMontadora)
            {
                if (item.CodigoMontadora == codigoMontadora)
                {
                    modelo.Montadora = item;
                    listaModelo.Add(modelo);
                    return true;
                }
            }
            return false;
        }

        private bool VerificarModeloExistente(int codigoModelo)
        {
            foreach(var item in listaModelo)
            {
                if (item.CodigoModelo == codigoModelo)
                {
                    carro.Modelo = item;
                    listaCarro.Add(carro);
                    return true;
                }
            }
            return false;
        }

        public bool BuscarMontadora(int codigoMont)
        {
            foreach (var item in listaMontadora)
            {
                if (item.CodigoMontadora == codigoMont)
                {
                    Console.WriteLine("\nMontadora a ser atualizada: ");
                    Console.WriteLine(montadora);
                    return true;
                }
            }
            return false;
        }

        public bool BuscarModelo(int codigoModelo)
        {
            foreach (var item in listaModelo)
            {
                if (item.CodigoModelo == codigoModelo)
                {
                    Console.WriteLine("\nModelo a ser atualizado: ");
                    Console.WriteLine(modelo);
                    return true;
                }
            }
            return false;
        }

        public bool BuscarCarro(string placa)
        {
            foreach (var item in listaCarro)
            {
                if (item.Placa == placa)
                {
                    Console.WriteLine("\nCarro a ser atualizado: ");
                    Console.WriteLine(carro);
                    return true;
                }
            }
            return false;
        }

        public void AtualizarMontadoraCodigo(int codigo, int novoCodigo)
        {
            foreach (var item in listaMontadora)
            {
                if (item.CodigoMontadora == codigo)
                {
                    item.CodigoMontadora = novoCodigo;
                    Console.WriteLine("\nMontadora Atualizada!\n");
                    return;
                }
            }
        }
        public void AtualizarMontadoraEstado(int codigo, string novoEstado)
        {
            foreach (var item in listaMontadora)
            {
                if (item.CodigoMontadora == codigo)
                {
                    item.Estado = novoEstado;
                    Console.WriteLine("\nMontadora Atualizada!\n");
                    return;
                }
            }
        }
        public void AtualizarMontadoraRazaoSocial(int codigo, string novaRazaoSocial)
        {
            foreach (var item in listaMontadora)
            {
                if (item.CodigoMontadora == codigo)
                {
                    item.RazaoSocial = novaRazaoSocial;
                    Console.WriteLine("\nMontadora Atualizada!\n");
                    return;
                }
            }
        }

        public void AtualizarModeloCodigo(int codigo, int novoCodigo)
        {
            foreach (var item in listaModelo)
            {
                if (item.CodigoModelo == codigo)
                {
                    item.CodigoModelo = novoCodigo;
                    Console.WriteLine("\nModelo Atualizado!\n");
                    return;
                }
            }
        }

        public void AtualizarModeloNome(int codigo, string novoNome)
        {
            foreach (var item in listaModelo)
            {
                if (item.CodigoModelo == codigo)
                {
                    item.NomeModelo = novoNome;
                    Console.WriteLine("\nModelo Atualizado!\n");
                    return;
                }
            }
        }

        public void AtualizarCarroPlaca(string placa, string novaPlaca)
        {
            foreach (var item in listaCarro)
            {
                if (item.Placa == placa)
                {
                    item.Placa = novaPlaca;
                    Console.WriteLine("\nCarro Atualizado!\n");
                    return;
                }
            }
        }

        public void AtualizarCarroAnoFabricacao(string placa, int novoAnoFabricacao)
        {
            foreach (var item in listaCarro)
            {
                if (item.Placa == placa)
                {
                    item.AnoFabricacao = novoAnoFabricacao;
                    Console.WriteLine("\nCarro Atualizado!\n");
                    return;
                }
            }
        }
    }
}
