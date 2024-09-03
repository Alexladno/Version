using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {


        readonly DataBase database = new DataBase();


        public Login()
        {
            InitializeComponent();

            Voiti_Click.MouseDown += Voiti_Click_MouseDown;
            Registr_CLick.MouseDown += Registr_CLick_MouseDown;
        }

        private void Registr_CLick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Registration login = new Registration();
            login.Show();
            Close();
        }

        private void Voiti_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
        //    Raspisanie raspisanie4 = new Raspisanie();
        //    raspisanie4.Show();
        //    Close();

            var emailUser = emailbox.Text;
            var passUser = passbox.Text;

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
                    if (grupsId == "1исип-22")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 1ИСиП-22!");
                        Raspstud raspstud = new Raspstud();
                        raspstud.Show();
                        Close();
                    }

                    if (grupsId == "2ИСиП-22")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 2ИСиП-22!");
                    }

                    if (grupsId == "1ИСиП-21")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 1ИСиП-21!");
                    }

                    if (grupsId == "2ИСиП-21")
                    {
                        MessageBox.Show("Вы успешно вошли как студент группы 2ИСиП-21!");
                    }
                }

                if (roleId == "преподаватель")
                {
                    MessageBox.Show("Вы успешно вошли как преподаватель!");
                }

                if (roleId == "админ")
                {
                    MessageBox.Show("Вы успешно вошли как АДМИН!");
                    Raspisanie raspisanie = new Raspisanie();
                    raspisanie.Show();
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









    }
}
