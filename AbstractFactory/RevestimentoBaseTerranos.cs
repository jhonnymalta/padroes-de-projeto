using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class RevestimentoBaseTerranos : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Revestimento da cor amarela");
        }
    }
}
