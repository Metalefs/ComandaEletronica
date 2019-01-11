using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace Ia_ComandaRestaurante.Models.ViewModels
{


    public class Pedido
    {
        
       private readonly Ia_ComandaRestauranteContext _context;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPedido { get; set; }
        public string PrazoDoPedido { get; set; }
        public Mesa MesaDoPedido { get; set; }
        public int IdMesa { get; set; }
        public string TipoDoPedido { get; set; }
        public Funcionario Funcionario { get; set; }
        public int IdFuncionario { get; set; }
        public float PrecoDoPedido { get; set; }
        public Menu Menu { get; set; }
        public int IdMenu { get; set; }
        public EstadoDePedido Estado { get; set; }
        public string Observacoes { get; set; }
        public string NomeDoFuncionario { get; set; }
       

        public Pedido() { }

        public Pedido(int IdPedido, Mesa mesaDoPedido, Funcionario funcionarioResponsavel,Menu itensDoPedido, float precoDoPedido, string tipoDoPedido, string observacoes)
        {
            MesaDoPedido = mesaDoPedido;
            IdMesa = mesaDoPedido.IdMesa;
            NomeDoFuncionario = funcionarioResponsavel.NomeDoFuncionario;
            Estado = EstadoDePedido.ABERTO;
            Funcionario = funcionarioResponsavel;
            IdFuncionario = funcionarioResponsavel.IdFuncionario;
            Menu = itensDoPedido;
            IdMenu = itensDoPedido.IdMenu;
            PrecoDoPedido = precoDoPedido;
            TipoDoPedido = tipoDoPedido;
            Observacoes = observacoes;
                       
        }


        

        public Pedido(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        public List<Menu> FindAllMenu()
        {
            return _context.Menu.ToList();
        }
        public List<Pedido> ListAll()
        {
            return _context.Pedido.ToList();
        }
    }
    
}
