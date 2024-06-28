using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class FabricaDeBaseZergs : IFrabricaDeBase
    {
        public FabricaDeBaseZergs()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Zergs Criada com Sucesso");

            RevestimentoBaseZergs revestimento = new RevestimentoBaseZergs();
            revestimento.Composicao();
            EnergiaBaseZergs energia = new EnergiaBaseZergs();
            energia.Composicao();
        }
    }
}
