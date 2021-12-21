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
        SetStrategy _strategy;
        public MainWindow()
        {
            SetStrategy setStrategy = new SetStrategy(new Operation1());
            _strategy = setStrategy;
        }
        //Mouse takibi için
        private void popup_MouseMove(object sender, MouseEventArgs e)
        {
            var mousePosition = e.GetPosition(this.myWindow);
                Canvas.SetTop(followRectangle, mousePosition.Y);
                Canvas.SetLeft(followRectangle, mousePosition.X);
        }
        //Büyütme butonu strateji uygulaması
        private void getbig(object sender, RoutedEventArgs e)
        {
            SetStrategy setStrategy = new SetStrategy(new Operation1());
            _strategy = setStrategy;
            followRectangle.Width = _strategy.DoThings();
        }
        //Küçültme butonunda strateji uygulaması
        private void getsmall(object sender, RoutedEventArgs e)
        {
            SetStrategy setStrategy = new SetStrategy(new Operation2());
            _strategy = setStrategy;
            followRectangle.Width = _strategy.DoThings();
        }
    }
}
