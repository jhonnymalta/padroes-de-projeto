using ComportamentoDosPatos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComportamentoDosPatos
{
   
    public abstract class Duck
    {
        private IFlyBehavior _flyBehavior;
        private IQuackBehavior _quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        { 
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }
        

        public void performQuack()
        {
            _quackBehavior.Quackar();
        }
        public void performFly()
        {
            _flyBehavior.Fly();
        }
    }
}
