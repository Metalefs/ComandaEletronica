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
            foreach (var Pedido in Pedidos)
            {
                if (Pedidos.ElementAt(i).ItensDoPedido.Tipo == "Bebida")
                {
                    SomaItensCopa++;
                }
                else
                {
                    SomaItensCozinha++;
                }
                i++;
            }

            QuantidadeDeMesas = Pedidos.Sum(LP1 => LP1.MesaDoPedido.IdMesa);
            QuantidadeDeClientes = Pedidos.Sum(LP=> LP.MesaDoPedido.QuantidadeDePessoas);
            QuantidadePedidosCozinha = SomaItensCozinha;
            QuantidadePedidosCopa = SomaItensCopa;
            ComplexidadeMediaDosPedidos = "baixa";
            TempoDeEntrega = 0; //DEFAULT
            PrecoTotal = Pedidos.Sum(LP => LP.PrecoDoPedido);
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
