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
using System.Drawing;

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
        int a = 1;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                PicOutput1.Visibility = Visibility.Visible;
                PicOutput2.Visibility = Visibility.Collapsed;
                PicOutput3.Visibility = Visibility.Collapsed;
                TextOutput.Text = "Слоны — самые крупные наземные животные на Земле. Обитают они в Юго-Восточной Азии и Африке в тропических лесах и саваннах. Самыми крупными являются африканские саванные слоны, их масса может превышать 6 тонн."; ;
                a++;
            }
            else if (a == 1)
            {
                PicOutput1.Visibility = Visibility.Collapsed;
                PicOutput2.Visibility = Visibility.Visible;
                PicOutput3.Visibility = Visibility.Collapsed;
                TextOutput.Text = "Шея у жирафов необычайно длинная, и это несмотря на то, что у них, как и почти у всех других млекопитающих (за исключением ламантинов и ленивцев), лишь семь шейных позвонков. ";
                a++;
            }
            else if (a == 2)
            {
                PicOutput1.Visibility = Visibility.Collapsed;
                PicOutput2.Visibility = Visibility.Collapsed;
                PicOutput3.Visibility = Visibility.Visible;
                TextOutput.Text = "Тигр — хищное млекопитающее семейства кошачьих, один из пяти видов рода пантер, принадлежащего к подсемейству больших кошек.";
                a = 0;
            }
        }
    }
}
