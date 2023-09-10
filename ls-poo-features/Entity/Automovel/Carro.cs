namespace ls_poo_features.Entity.Automovel
{
    public class Carro
    {
        public Carro(string? placa, Modelo? modelo, int anoFabricacao)
        {
            Placa = placa;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
        }

        public string? Placa { get; set; }
        public Modelo? Modelo { get; set; }
        public int AnoFabricacao { get; set; }
    }
}
