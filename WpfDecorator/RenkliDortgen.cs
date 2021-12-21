using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfÖdev
{
    class RenkliDortgen : DortgenDecorator
    {
        public RenkliDortgen(ISekil sekil) : base(sekil)
        {
        }
        public RenkliDortgen(UzunDortgen uzun) : base(uzun)
        {

        }
        public override string GetRenk()
        {
            return "Blue";
        }
        public override int GetBoyut()
        {
            return base.GetBoyut();
        }
    }
}
