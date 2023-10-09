namespace ls_poo_features.Entity.Employee
{
    public class Seller : Employee
    {
        public Seller()
        {
        }

        public Seller(string? nome, string? cPF, double salario, string? departamento, int quantidadeVendas, int comissao) : base(nome, cPF, salario, departamento)
        {
            Nome = nome;
            CPF = cPF;
            Salario = salario;
            Departamento = departamento;
            QuantidadeVendas = quantidadeVendas;
            Comissao = comissao;
        }

        public int QuantidadeVendas { get; set; }
        public int Comissao { get; set; }

        public void AtualizaQuantidadeVendas(int quantidade)
        {
            QuantidadeVendas += quantidade;
        }

        public void CalcularSalario()
        {
            Salario += (QuantidadeVendas * Comissao);
        }
    }
}
