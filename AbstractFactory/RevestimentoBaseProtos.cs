using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class RevestimentoBaseProtos : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Reverstimento cor verde");
        }
    }
}
