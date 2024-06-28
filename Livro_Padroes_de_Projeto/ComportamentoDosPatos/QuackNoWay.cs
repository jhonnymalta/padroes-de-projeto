using ComportamentoDosPatos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDosPatos
{
    internal class QuackNoWay : IQuackBehavior
    {
        public void Quackar()
        {
            Console.WriteLine("Não faço nada");
        }
    }
}
