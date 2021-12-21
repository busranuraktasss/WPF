using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace InsertTextTarget
{
    public class Block 
        //Receiver sınıfımız
        //Asıl İşlevi yapan sınıfımız
    {
        public Block() { }
        public void blocked()
        {
            MessageBox.Show("Texte yazı girişi engellendi.");
        }
        public void unblocked()
        {
            MessageBox.Show("Texte yazı girişi engeli kalktı.");
        }

    }
}
