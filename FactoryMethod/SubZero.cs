using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SubZero : IPersonagem
    {
        public void Escolhido()
        {
            Console.WriteLine("SubZero");
        }
    }
}
