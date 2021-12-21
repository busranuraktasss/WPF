using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfÖdev
{
    abstract public class Observer
    {
        public abstract void Update();
    }
    public class BuyukObserver : Observer
    {
        public override void Update()
        {
            MessageBox.Show("Ortadaki şekil güncellendi!");
        }
    }
    public class KucukObserver : Observer
    {
        public override void Update()
        {
            MessageBox.Show("Üstteki şekil güncellendi!");
        }
    }
    public class OrtaObserver : Observer
    {
        public override void Update()
        {
            MessageBox.Show("Alttaki şekil güncellendi!");
        }
    }

    public class Sekil
    {
        public int Boyut { get; set; }

        bool butonabastiMi;
        public bool BoyutDegismeBastiMi
        {
            get { return butonabastiMi; }
            set
            {
                if (value == true)
                {
                    Notify();
                    butonabastiMi = value;
                }
                else
                    butonabastiMi = value;
            }
        }
        //Abone olunan nesneler burada tutulacak.
        List<Observer> Sekiller;
        public Sekil()
        {
            this.Sekiller = new List<Observer>();
        }
        //Observer olarak eklemek için
        public void SekliAboneEkle(Observer observer)
        {
            Sekiller.Add(observer);
        }
        //Observer olmaktan çıkarmak için
        public void SekliAboneliktenCikar(Observer observer)
        {
            Sekiller.Remove(observer);
        }
        //Güncelleme olunca abone olan observerlara haber vermek için
        public void Notify()
        {
            Sekiller.ForEach(g =>
            {
                g.Update();
            });
        }
    }

}
