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


        readonly DataBase database = new DataBase();


        public Login()
        {
            InitializeComponent();
            
        }

        private void ButtonVoiti(object sender, RoutedEventArgs e)
        {
;           var emailUser= textBoxemail.Text;
            var passUser = passBox.Password;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_users, pass_users, fio_users, email_users, role_users, grups_users from users where email_users = '{emailUser}' and pass_users = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                string roleId = Convert.ToString(table.Rows[0]["role_users"]);
                if (roleId == "студент")
                {
                    
                    string grupsId = Convert.ToString(table.Rows[0]["grups_users"]);
                    if (grupsId == "1ИСиП-22")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 1ИСиП-22!");
                        Vkladka1 vkl1 = new Vkladka1();
                        vkl1.Show();
                        Close();
                    }

                    if (grupsId == "2ИСиП-22")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 2ИСиП-22!");
                        Vkladka1 vkl1 = new Vkladka1();
                        vkl1.Show();
                        Close();
                    }

                    if (grupsId == "1ИСиП-21")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 1ИСиП-21!");
                        Vkladka1 vkl1 = new Vkladka1();
                        vkl1.Show();
                        Close();
                    }

                    if (grupsId == "2ИСиП-21")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 2ИСиП-21!");
                        Vkladka1 vkl1 = new Vkladka1();
                        vkl1.Show();
                        Close();
                    }
                }

                if (roleId == "преподаватель")
                {
                    MessageBox.Show("Вы успешно вошли как преподаватель!");
                    Vkladka1 vkl1 = new Vkladka1();
                    vkl1.Show();
                    Close();
                }

                if (roleId == "админ")
                {
                    MessageBox.Show("Вы успешно вошли как АДМИН!");
                    vkladka3 vkl3 = new vkladka3();
                    vkl3.Show();
                    Close();
                }

                if (roleId == "")
                {
                    MessageBox.Show("Вы успешли вошли в роли гостя!");
                }
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


    
    

