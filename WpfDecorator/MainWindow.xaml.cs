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
        private Rectangle follower;
        public MainWindow()
        {
            ISekil _standartSekil = new UzunDortgen(new RenkliDortgen(new Dortgen()));
        }
        //Mouse takibi için
        private void popup_MouseMove(object sender, MouseEventArgs e)
        {
            var mousePosition = e.GetPosition(this.myWindow);
            if (follower == null)
            {
                Canvas.SetTop(followRectangle, mousePosition.Y);
                Canvas.SetLeft(followRectangle, mousePosition.X);
            }
            else
            {
                //Yeni şekil oluşturulduktan sonra başlangıçtaki şekli silmek için
                containerCanvas.Children.Remove(followRectangle);
                //
                Canvas.SetTop(follower, mousePosition.Y+10);
                Canvas.SetLeft(follower, mousePosition.X+10);
            }
        }
        //Şekil ekleme
        private void addRectangle(object sender, RoutedEventArgs e)
        {
            //Önceden oluşturulmuş şekil varsa kaldırmak için
            if (follower != null)
            {
                containerCanvas.Children.Remove(follower);
            }
            //Yeni şekli yapmak için
            ISekil dortgen = new Dortgen();
            SolidColorBrush brush = Brushes.Red;
            if (chbig.IsChecked == true&&chcolor.IsChecked==false)
            {
                dortgen = new UzunDortgen(new Dortgen());
                if (dortgen.GetRenk() == "Red")
                    brush = Brushes.Red;
            }
            else if (chcolor.IsChecked == true&&chbig.IsChecked==false)
            {
                dortgen = new RenkliDortgen(new Dortgen());
                if(dortgen.GetRenk()=="Blue")
                brush = Brushes.Blue;
            }
            else if (chcolor.IsChecked == true && chbig.IsChecked == true)
            {
                dortgen = new RenkliDortgen(new UzunDortgen(dortgen));
                if (dortgen.GetRenk() == "Blue")
                    brush = Brushes.Blue;
                else
                    brush = Brushes.Red;
            }
            Rectangle rectangle = new Rectangle()
            {
                Width = dortgen.GetBoyut(),
                Height = dortgen.GetBoyut(),
                Fill = brush,
            };
            containerCanvas.Children.Add(rectangle);
            //oluşturulan şekli mouse nin takip etmesi için
            follower = rectangle;
        }
    }
}
