namespace ls_poo_features.Entity.Employee
{
    public class Manager : Employee
    {
        public Manager(string? nome, string? cPF, float salario, string? departamento, string? senha, int numeroFuncionarios) : base(nome, cPF, salario, departamento)
        {
            Nome = nome;
            CPF = cPF;
            Salario = salario;
            Departamento = departamento;
            Senha = senha;
            NumeroFuncionariosGerenciados = numeroFuncionarios; 
        }

        public string? Senha { get; set; }
        public int NumeroFuncionariosGerenciados { get; set; }

        
        public virtual bool AutenticarSenha(string senha)
        {
            return senha == Senha;
        }

        public override void Bonificar()
        {
            Salario = Salario + (Salario * 0.15);
        }
    }
}
