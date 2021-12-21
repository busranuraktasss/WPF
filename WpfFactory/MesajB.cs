using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WindowMove
{
    public class MesajB:Mesaj
    {
        public override void Send()
        {
            MessageBox.Show("Y koordinatı büyütüldü.");
        }
    }
}
