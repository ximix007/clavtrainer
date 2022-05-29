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

namespace Clavtrainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // начальная строка
        String task = "Hello world";

        //выполняется при инициализации формы
        public MainWindow()
        {
            InitializeComponent();
            Label1.Content = task;
            textBox1.KeyDown += TextBox1_KeyDown;
        }

        //выполняется при нажатии кнопки, если выбран элемент управления (в часности TextBox)
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Label1.Content = e.Key.ToString();
            //e.Key - код нажатой клавиши
        }
    }
}
