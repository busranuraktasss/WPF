using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfÖdev
{
    public partial class MainWindow : Window
    {
        private Sekil Sekil1;
        private Sekil Sekil2;
        private Sekil Sekil3;
        public MainWindow()
        {
            //Şekilleri observer için abone etme
            Sekil o = new Sekil();
            o.SekliAboneEkle(new BuyukObserver());
            o.Boyut = 50;

            Sekil o2 = new Sekil();
            o.SekliAboneEkle(new KucukObserver());
            o.Boyut = 25;

            Sekil o3 = new Sekil();
            o.SekliAboneEkle(new OrtaObserver());
            o.Boyut = 35;
            Sekil1 = o;
            Sekil2 = o2;
            Sekil3 = o3;
        }
        //Mouse Hareketleri
        private void popup_MouseMove(object sender, MouseEventArgs e)
        {
            var mousePosition = e.GetPosition(this.myWindow);
            Canvas.SetTop(followRectangle, mousePosition.Y);
            Canvas.SetLeft(followRectangle, mousePosition.X);
            Canvas.SetTop(followRectangle2, mousePosition.Y + 55);
            Canvas.SetLeft(followRectangle2, mousePosition.X + 55);
            Canvas.SetTop(followRectangle3, mousePosition.Y - 30);
            Canvas.SetLeft(followRectangle3, mousePosition.X - 30);
        }
        //Şekillere büyüme mesajı göndermek için
        private void getbig(object sender, RoutedEventArgs e)
        {
            Sekil1.BoyutDegismeBastiMi = true;
            Sekil2.BoyutDegismeBastiMi = true;
            Sekil3.BoyutDegismeBastiMi = true;
            Sekil3.Notify();
            followRectangle.Width =250;
            followRectangle2.Width =90;
            followRectangle3.Width = 150;
        }

        //Orijinal hallerine döndürmek için
        private void getsmall(object sender, RoutedEventArgs e)
        {
            followRectangle.Width = 50;
            followRectangle2.Width = 25;
            followRectangle3.Width = 35;
        }
    }
}
