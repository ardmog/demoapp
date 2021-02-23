using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            UCContentControl.Content = null;
        }
        
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
        private void ButtonBase_OnClick4(object sender, RoutedEventArgs e)
        {
            UserControl1 uc1 = new UserControl1();
            UCContentControl.Content = uc1;
            uc1.Name = "UC1";
        }

        private void ButtonBase_OnClick5(object sender, RoutedEventArgs e)
        {
            UserControl2 uc2 = new UserControl2();
            UCContentControl.Content = uc2;
            uc2.Name = "UC2";
        }

        private void ButtonBase_OnClick6(object sender, RoutedEventArgs e)
        {
            var uc = UCContentControl.Content as FrameworkElement;

            RenderTargetBitmap rtb = new RenderTargetBitmap(1888, 968, 96d, 96d, PixelFormats.Pbgra32);
            rtb.Render(uc);

        }
    }
}
