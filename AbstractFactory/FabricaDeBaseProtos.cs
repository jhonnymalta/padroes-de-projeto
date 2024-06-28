using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class FabricaDeBaseProtos : IFrabricaDeBase
    {
        public FabricaDeBaseProtos()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Protos Criada com Sucesso");

            RevestimentoBaseProtos revestimento = new RevestimentoBaseProtos();
            revestimento.Composicao();
            EnergiaBaseProtos energia = new EnergiaBaseProtos();
            energia.Composicao();
        }
    }
}
