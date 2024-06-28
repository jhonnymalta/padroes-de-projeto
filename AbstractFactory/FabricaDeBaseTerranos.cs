using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class FabricaDeBaseTerranos : IFrabricaDeBase
    {
        public FabricaDeBaseTerranos()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Terranos Criada com Sucesso");

            RevestimentoBaseTerranos revestimento = new RevestimentoBaseTerranos();
            revestimento.Composicao();
            EnergiaBaseTerranos energia = new EnergiaBaseTerranos();
            energia.Composicao();
        }
    }
}
