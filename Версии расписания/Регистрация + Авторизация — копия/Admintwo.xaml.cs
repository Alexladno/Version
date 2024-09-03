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

namespace Регистрация
{
    /// <summary>
    /// Логика взаимодействия для Admintwo.xaml
    /// </summary>
    public partial class Admintwo : Window
    {
        public Admintwo()
        {
            InitializeComponent();
            nado.MouseDown += Nado_MouseDown;
        }

        private void Nado_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Raspisanie4u raspisanie4u=new Raspisanie4u();
            raspisanie4u.Show();
            Close();
        }
    }
}
