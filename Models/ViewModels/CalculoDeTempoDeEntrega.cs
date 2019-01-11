using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ia_ComandaRestaurante.Models.ViewModels
{
    public class CalculoDeTempoDeEntrega
    {

        private readonly Ia_ComandaRestauranteContext _context;

        public CalculoDeTempoDeEntrega()
        {
        }

        public CalculoDeTempoDeEntrega(Ia_ComandaRestauranteContext context)
        {
            _context = context;
        }

        public int QuantidadeDeMesas { get; set; }
        public int QuantidadeDeClientes { get; set; }
        public int QuantidadePedidosCozinha { get; set; }
        public int QuantidadePedidosCopa { get; set; }
        public string ComplexidadeMediaDosPedidos { get; set; }
        public float PrecoTotal { get; set; }
        public int TempoDeEntrega { get; set; }
        public string ARFFLocation  { get; set; }
        public int SomaItensCozinha { get; set; }
        public int SomaItensCopa { get; set; }

        public string CalcularTempo(List<Pedido> Pedidos)
        {
            int i = 0;
            var ListaDePedidos = Pedidos;
            
                
                    SomaItensCopa = _context.Pedido.Count(Pr => Pr.TipoDoPedido == "Bebida");
                
                    SomaItensCozinha = _context.Pedido.Count(Pr => Pr.TipoDoPedido == "Comida"); 
                
            
            //Pedido list = _context.Pedido.OrderBy(m => m.ItensDoPedido.Complexidade).ToList().Last();


            QuantidadeDeMesas = _context.Pedido.Sum(LP1 => LP1.MesaDoPedido.IdMesa);
            QuantidadeDeClientes = _context.Pedido.Sum(LP=> LP.MesaDoPedido.QuantidadeDePessoas);
            QuantidadePedidosCozinha = SomaItensCozinha;
            QuantidadePedidosCopa = SomaItensCopa;
            ComplexidadeMediaDosPedidos = Pedidos.Last().Menu.Complexidade;
            TempoDeEntrega = 0; //DEFAULT
            PrecoTotal = _context.Pedido.Sum(LP => LP.PrecoDoPedido);
            ARFFLocation = "http://eumotorista.portifoliotgm.esy.es/IA/TreinamentoRestaurante.arff";


            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "C:/Users/User/source/repos/Ia-ComandaRestaurante/Ia-ComandaRestaurante/bin/CalculaTempo.exe";

            //strCommandParameters are parameters to pass to program

            string args = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", QuantidadeDeMesas, QuantidadeDeClientes, QuantidadePedidosCozinha, QuantidadePedidosCopa, ComplexidadeMediaDosPedidos, TempoDeEntrega, PrecoTotal, ARFFLocation);
            pProcess.StartInfo.Arguments = args;
            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();


            return strOutput;


        }

        public string CalcularTempo(IEnumerable<Pedido> Pedidos)
        {
            int i = 0;
            var ListaDePedidos = Pedidos;

           
            QuantidadePedidosCozinha = 3;
            QuantidadePedidosCopa = 2;
            ComplexidadeMediaDosPedidos = "baixa";
            

            try
            {
                SomaItensCopa = _context.Pedido.Count(Pr => Pr.TipoDoPedido == "Bebida");

                SomaItensCozinha = _context.Pedido.Count(Pr => Pr.TipoDoPedido == "Comida");
            }
            catch
            {
                SomaItensCopa = 2;

                SomaItensCozinha = 4;
            }

            


            QuantidadeDeMesas = _context.Pedido.Sum(LP1 => LP1.MesaDoPedido.IdMesa);
            QuantidadeDeClientes = _context.Pedido.Sum(LP => LP.MesaDoPedido.QuantidadeDePessoas);
            QuantidadePedidosCozinha = SomaItensCozinha;
            QuantidadePedidosCopa = SomaItensCopa;
            ComplexidadeMediaDosPedidos = "baixa";
            TempoDeEntrega = 0; //DEFAULT
            try
            {
                PrecoTotal = Pedidos.Sum(LP => LP.PrecoDoPedido); 
            }
            catch (InvalidCastException)
            {
                PrecoTotal = (float) _context.Pedido.Sum(LP => LP.PrecoDoPedido);
            }
            

            ARFFLocation = "http://eumotorista.portifoliotgm.esy.es/IA/TreinamentoRestaurante.arff";


            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();

            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = "C:/Users/User/source/repos/Ia-ComandaRestaurante/Ia-ComandaRestaurante/bin/CalculaTempo.exe";

            //strCommandParameters are parameters to pass to program

            string args = string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", QuantidadeDeMesas, QuantidadeDeClientes, QuantidadePedidosCozinha, QuantidadePedidosCopa, ComplexidadeMediaDosPedidos, TempoDeEntrega, PrecoTotal, ARFFLocation);
            pProcess.StartInfo.Arguments = args;
            //Set output of program to be written to process output stream
            pProcess.StartInfo.RedirectStandardOutput = true;

            //Start the process
            pProcess.Start();

            //Get program output
            string strOutput = pProcess.StandardOutput.ReadToEnd();

            //Wait for process to finish
            pProcess.WaitForExit();


            return strOutput;



        }




    }
}
