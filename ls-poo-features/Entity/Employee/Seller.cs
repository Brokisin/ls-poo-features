namespace ls_poo_features.Entity.Employee
{
    public class Seller : Employee
    {
        public Seller(string? nome, string? cPF, float salario, string? departamento, int quantidadeVendas, int comissao, string senha) : base(nome, cPF, salario, departamento)
        {
            Nome = nome;
            CPF = cPF;
            Salario = salario;
            Departamento = departamento;
            QuantidadeVendas = quantidadeVendas;
            Comissao = comissao;
            Senha = senha;
        }

        public int QuantidadeVendas { get; set; }
        public int Comissao { get; set; }
        public string Senha { get; set; }

        public void AtualizaQuantidadeVendas(int quantidade)
        {
            QuantidadeVendas += quantidade;
        }

        public void CalcularSalario()
        {
            int quantidadeVendas = QuantidadeVendas;
            while (quantidadeVendas != 0)
            {
                Salario += Comissao;
                quantidadeVendas--;
            }
        }

        public virtual bool AutenticarSenha(string senha)
        {
            return senha == Senha;
        }
    }
}
