using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfÖdev
{
    public interface Strategy
    {
        //Boyut ayarı için strateji patterni 
        int doOperate();
    }
    public class Operation1 : Strategy
    {
        public int doOperate()
        {
            return 285;
        }
    }
    public class Operation2 : Strategy
    {
        public int doOperate()
        {
            return 25;
        }
    }
    public class SetStrategy
    {
        private Strategy strategy;

        public SetStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public int DoThings()
        {
          return  strategy.doOperate();
        }
    }
}
