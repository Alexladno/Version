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
using System.Data.SqlClient;
using MaterialDesignThemes.Wpf.Converters.CircularProgressBar;
using System.Windows.Media.Animation;

namespace Регистрация
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ApplicationContext db;
        
        DataBase database = new DataBase();


        public MainWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            


        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            database.openConnection();

            
            string fio = textBoxfio.Text.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();
            string pass = passBox.Password.ToLower();
            string grups = textBoxgrups.Text.ToLower();

            if (pass.Length < 5)
            {
                passBox.ToolTip = "Это поле введено не корректно!";
                passBox.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно!";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxfio.ToolTip = "";
                textBoxfio.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                textBoxfio.ToolTip = "";
                textBoxfio.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно зарегистрировались!");
                
                
                var addQuery = $"insert into users (fio_users,  pass_users, email_users, grups_users) values ('{fio}', '{pass}', '{email}', '{grups}')";

                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                Login login1 = new Login();
                login1.Show();
                Close(); ;

                database.closedConnection();




            }
        }

        private void Button_Window_Login_Click(object sender, RoutedEventArgs e)
        {
            Login login1 = new Login();
            login1.Show();
            Close();
        }
    }
}
