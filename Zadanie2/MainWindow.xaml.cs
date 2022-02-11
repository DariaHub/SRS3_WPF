using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Zadanie2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mutex mutex = new Mutex(false, "MyApplication");
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (!mutex.WaitOne(500, false))
            {
                MessageBox.Show("Это приложение уже запущено", "Ошибка");
                Application.Current.Shutdown();
            }
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if (tb_a.Text != "" && tb_b.Text != "")
            {
                tb_answer.Text = Convert.ToString(Convert.ToDouble(tb_a.Text) + Convert.ToDouble(tb_b.Text));
            }
            else
                tb_answer.Text = "ошибка";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (tb_a.Text != "" && tb_b.Text != "")
            {
                tb_answer.Text = Convert.ToString(Convert.ToDouble(tb_a.Text) - Convert.ToDouble(tb_b.Text));
            }
            else
                tb_answer.Text = "ошибка";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_a.Text != "" && tb_b.Text != "")
            {
                tb_answer.Text = Convert.ToString(Convert.ToDouble(tb_a.Text) * Convert.ToDouble(tb_b.Text));
            }
            else
                tb_answer.Text = "ошибка";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (tb_a.Text != "" && tb_b.Text != ""&& Convert.ToDouble(tb_b.Text)!=0)
            {
                tb_answer.Text = Convert.ToString(Convert.ToDouble(tb_a.Text) / Convert.ToDouble(tb_b.Text));
            }
            else
                tb_answer.Text = "ошибка";
        }
    }
}
