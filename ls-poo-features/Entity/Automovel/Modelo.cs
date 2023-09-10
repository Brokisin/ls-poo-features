namespace ls_poo_features.Entity.Automovel
{
    public class Modelo
    {
        public Modelo(int codigoModelo, string? nomeModelo, Montadora? montadora)
        {
            CodigoModelo = codigoModelo;
            NomeModelo = nomeModelo;
            Montadora = montadora;
        }

        public int CodigoModelo { get; set; }
        public string? NomeModelo { get; set; }
        public Montadora? Montadora { get; set; }
    }
}
