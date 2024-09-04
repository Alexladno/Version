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

            List<User> users  = db.Users.ToList();
            string str = "";
            foreach (User user in users)
            {
                str += "Login: " + user.Login + " | ";
            }

            exampleText.Text = str;
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            database.openConnection();

            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxLogin.Text = "Это поле введено не корректно!";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Это поле введено не корректно!";
                passBox.Background = Brushes.DarkRed;
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Пароли не совпадают!";
                passBox_2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введено не корректно!";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Вы успешно зарегистрировались!");
                
                
                var addQuery = $"insert into users (login, pass, email) values ('{login}', '{pass}', '{email}')";

                var command = new SqlCommand(addQuery, database.GetConnection());
                command.ExecuteNonQuery();

                Login login1 = new Login();
                login1.Show();
                this.Hide();

                database.closedConnection();




            }
        }

        private void Button_Window_Login_Click(object sender, RoutedEventArgs e)
        {
            Login login1 = new Login();
            login1.Show();
            this.Hide();
        }
    }
}
