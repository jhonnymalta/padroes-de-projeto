using ComportamentoDosPatos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDosPatos
{
    internal class Quack : IQuackBehavior
    {
        public void Quackar()
        {
            Console.WriteLine("Quack Quack Quack");
        }
    }   
}
