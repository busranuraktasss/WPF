using System;
using System.Collections.Generic;
using System.Text;

namespace WindowMove
{
    public class Creator
    {
      public Mesaj  FactoryMethod(AllMessage messagetype)
        {
            Mesaj me = null;
            switch (messagetype)
            {
                case AllMessage.MesajA:
                   me = new MesajA();
                   break;
                case AllMessage.MesajB:
                    me = new MesajB();
                    break;
            }
            return me;
        }
    }
}
