namespace ls_poo_features.Entity.Employee
{
    public class Seller : Employee
    {
        public Seller(string? nome, string? cPF, float salario, string? departamento, int quantidadeVendas, double comissao) : base(nome, cPF, salario, departamento)
        {
            Nome = nome;
            CPF = cPF;
            Salario = salario;
            Departamento = departamento;
            QuantidadeVendas = quantidadeVendas;
            Comissao = comissao;
        }

        public int QuantidadeVendas { get; set; }
        public double Comissao { get; set; }


        public void AtualizaQuantidadeVendas(int quantidade)
        {
            QuantidadeVendas += quantidade;
        }

        public void CalcularSalario()
        {
            Salario += Comissao;
        }
    }
}
