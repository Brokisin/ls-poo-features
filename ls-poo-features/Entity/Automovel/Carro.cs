using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ls_poo_features.Entity.Automovel
{
    public class Carro
    {
        public Carro() { }

        public Carro(string? placa, Modelo? modelo, int anoFabricacao)
        {
            Placa = placa;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
        }

        public string? Placa { get; set; }
        public Modelo? Modelo { get; set; }
        public int AnoFabricacao { get; set; }

        public override string ToString()
        {
            return $"-> Carro:\nPlaca: {this.Placa}," +
                $"\n    Código Modelo: {this.Modelo.CodigoModelo}," +
                $"\n    Nome Modelo: {this.Modelo.NomeModelo}," +
                $"\n        Código Montadora: {this.Modelo.Montadora.CodigoMontadora}," +
                $"\n        Razão Social Montadora: {this.Modelo.Montadora.RazaoSocial}," +
                $"\n        Estado Montadora: {this.Modelo.Montadora.Estado}," +
                $"\nAno fabricação: {this.AnoFabricacao}";
        }
    }
}
