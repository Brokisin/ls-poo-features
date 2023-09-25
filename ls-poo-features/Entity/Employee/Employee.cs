namespace ls_poo_features.Entity.Employee
{
    public class Employee
    {
        public Employee(string? nome, string? cPF, float salario, string? departamento)
        {
            Nome = nome;
            CPF = cPF;
            Salario = salario;
            Departamento = departamento;
        }

        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public double Salario { get; set; }
        public string? Departamento { get; set; }

        public virtual void Bonificar()
        {
            Salario = Salario + (Salario * 0.1);
        }
    }
}
