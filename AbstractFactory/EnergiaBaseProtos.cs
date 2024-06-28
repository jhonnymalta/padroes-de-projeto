using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class EnergiaBaseProtos : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base em cristais");
        }
    }
}
