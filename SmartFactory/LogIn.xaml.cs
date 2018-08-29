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
using System.Windows.Shapes;

namespace SmartFactory
{
    /// <summary>
    /// LogIn.xaml 的交互逻辑
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }
        public void Close_clickHandler(Object sender, RoutedEventArgs e)
         {
             this.Close();
        }

        private void Mouse_moveHandler(object sender, MouseEventArgs e)
         {
             if (e.LeftButton == MouseButtonState.Pressed&& e.Source == this) this.DragMove();
         }
}
}
