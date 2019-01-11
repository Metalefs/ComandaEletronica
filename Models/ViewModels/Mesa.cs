
using Ia_ComandaRestaurante.Models.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Mesa
    {
        private Ia_ComandaRestauranteContext _context;

        public Mesa(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMesa { get; set; }
        public string NomeDoCliente { get; set; }
        public int NumeroDaMesa { get; set; }
        public int QuantidadeDePessoas { get; set; }
        public EstadoDaMesa Disponibilidade { get; set; }
        public string Observacoes { get; set; }

        public Mesa(){
        }

        public Mesa(string nomeDoCliente, int numeroDaMesa, int quantidadeDePessoas, string observacoes)
        {
            NomeDoCliente = nomeDoCliente;
            NumeroDaMesa = numeroDaMesa;
            QuantidadeDePessoas = quantidadeDePessoas;
            Observacoes = observacoes;
            Disponibilidade = EstadoDaMesa.OCUPADO;
            //_context.Add(this);
        }
    }
}
