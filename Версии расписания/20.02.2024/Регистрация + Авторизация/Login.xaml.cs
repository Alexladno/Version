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
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;
using System.Net;

namespace Регистрация
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {


        DataBase database = new DataBase();


        public Login()
        {
            InitializeComponent();
            
        }

        private void ButtonVoiti(object sender, RoutedEventArgs e)
        {
;           var loginUser = textBoxLogin.Text;
            var passUser = passBox.Password;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            
            string querystring = $"select id, login, pass, email, id_role from users where login = '{loginUser}' and pass = '{passUser}' and (((users.id_role)=1))";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!"); 
                UserPageWindow userPageWindow = new UserPageWindow();
                userPageWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Пароль или логин указан неверно", "Ошибка!");
            }

        }




        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }


    
    

