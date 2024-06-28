using ComportamentoDosPatos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDosPatos
{
    internal class WoodDuck : Duck
    {
        var quackBehavior = 
        public WoodDuck(IFlyBehavior flyBehavior, flyBehavior)
        {
          var  quackBehavior = new QuackNoWay();
           var flyBehavior = new FlyNoWay();
        }

        public void display()
        {
            Console.WriteLine("Eu sou um pato de madeira!");
        }
    }
}
