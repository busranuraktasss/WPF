using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfÖdev
{
    class DortgenDecorator : ISekil
    {
        private ISekil _sekil;
        public DortgenDecorator(ISekil sekil)
        {
            _sekil = sekil;
        }
        public virtual int GetBoyut()
        {
            return _sekil.GetBoyut();
        }

        public virtual string GetRenk()
        {
            return _sekil.GetRenk();
        }
    }
}
