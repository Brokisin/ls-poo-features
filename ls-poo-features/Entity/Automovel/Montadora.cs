namespace ls_poo_features.Entity.Automovel
{
    public class Montadora
    {
        public Montadora(int codigoMontadora, string? estado, string? razaoSocial)
        {
            CodigoMontadora = codigoMontadora;
            Estado = estado;
            RazaoSocial = razaoSocial;
        }

        public int CodigoMontadora { get; set; }
        public string? Estado { get; set; }
        public string? RazaoSocial { get; set; }
    }
}
