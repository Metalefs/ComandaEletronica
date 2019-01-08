
using Ia_ComandaRestaurante.Models.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;


namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Mesa
    {
        [Key]
        public int IdMesa { get; set; }
        public string NomeDoCliente { get; set; }
        
        public int NumeroDaMesa { get; set; }
        public int QuantidadeDePessoas { get; set; }
        public EstadoDaMesa Disponibilidade { get; set; }
        public string Observacoes { get; set; }

        public Mesa(){
        }

        public Mesa(string nomeDoCliente, int numeroDaMesa, int quantidadeDePessoas)
        {
            NomeDoCliente = nomeDoCliente;
            NumeroDaMesa = numeroDaMesa;
            QuantidadeDePessoas = quantidadeDePessoas;
            Disponibilidade = EstadoDaMesa.OCUPADO;
        }
    }
}
