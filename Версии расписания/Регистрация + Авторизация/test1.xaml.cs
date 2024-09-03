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
    /// Логика взаимодействия для test1.xaml
    /// </summary>
    public partial class test1 : Window
    {
        public test1()
        {
            InitializeComponent();
            Vixos_Click.Fill = Brushes.White;

            Vixos_Click.MouseDown += Vixos_Click_MouseDown;


            Vixos_Click1.Fill = Brushes.Black;

            Vixos_Click1.MouseDown += Vixos_Click_MouseDown1;
        }

        private void Vixos_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close(); 
        }

        private void Vixos_Click_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Close(); 
        }

    }



    
}
