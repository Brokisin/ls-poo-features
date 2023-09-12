namespace ls_poo_features.Entity.Automovel
{
    public class Modelo
    {
        public Modelo() { }

        public Modelo(int codigoModelo, string? nomeModelo, Montadora? montadora)
        {
            CodigoModelo = codigoModelo;
            NomeModelo = nomeModelo;
            Montadora = montadora;
        }

        public int CodigoModelo { get; set; }
        public string? NomeModelo { get; set; }
        public Montadora? Montadora { get; set; }

        public override string ToString()
        {
            return $"-> Modelo:\nCódigo: {this.CodigoModelo},\nNome: {this.NomeModelo}," +
                $"\n    Código Montadora: {this.Montadora.CodigoMontadora}," +
                $"\n    Razão Social Montadora: {this.Montadora.RazaoSocial}," +
                $"\n    Estado Montadora: {this.Montadora.Estado}";
        }
    }
}
