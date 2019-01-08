
using Ia_ComandaRestaurante.Models.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;


namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }
        public string Img { get; set; }
        public string Complexidade;


        public Menu()
        {

        }

        public Menu( string nome, string tipo, float preco, string descricao, string img, string complexidade)
        {
            Nome = nome;
            Tipo = tipo;
            Preco = preco;
            Descricao = descricao;
            Img = img;
            Complexidade = complexidade;
        }
    }
}
