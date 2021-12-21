using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WindowMove
{
    public class MesajA:Mesaj
    {
        public override void Send()
        {
            MessageBox.Show("X koordinatı büyütüldü.");
        }
    }
}
