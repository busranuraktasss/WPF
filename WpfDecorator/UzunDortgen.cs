using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfÖdev
{
    class UzunDortgen : DortgenDecorator
    {
        public UzunDortgen(ISekil sekil) : base(sekil)
        {
        }
        public UzunDortgen(RenkliDortgen renkli):base(renkli)
        {

        }
        public override string GetRenk()
        {
            return base.GetRenk();
        }
        public override int GetBoyut()
        {
            int newBoyut = base.GetBoyut() + 100;
            return newBoyut;
        }
    }
}
