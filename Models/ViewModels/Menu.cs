
using Ia_ComandaRestaurante.Models.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Menu
    {
        private Ia_ComandaRestauranteContext _context;

        public Menu(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMenu { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }
        public string Img { get; set; }
        public string Complexidade { get; set; }


        public Menu()
        {

        }

        public Menu(int idMenu, string nome, string tipo, float preco, string descricao, string img, string complexidade)
        {
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
            Descricao = descricao;
            Img = img;
            IdMenu = idMenu;
            Complexidade = complexidade;
           // _context.Add(this);
        }
    }
}
