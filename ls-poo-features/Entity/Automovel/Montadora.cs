namespace ls_poo_features.Entity
{
    public class Montadora
    {
        public Montadora() { }

        public Montadora(int codigoMontadora, string? estado, string? razaoSocial)
        {
            CodigoMontadora = codigoMontadora;
            Estado = estado;
            RazaoSocial = razaoSocial;
        }

        public int CodigoMontadora { get; set; }
        public string? Estado { get; set; }
        public string? RazaoSocial { get; set; }

        public override string ToString()
        {
            return $"-> Montadora:\nCódigo: {this.CodigoMontadora},\nEstado: {this.Estado},\nRazão Social: {this.RazaoSocial}";
        }
    }
}
