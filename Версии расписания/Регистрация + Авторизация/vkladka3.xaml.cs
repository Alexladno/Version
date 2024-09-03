using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для vkladka3.xaml
    /// </summary>
    public partial class vkladka3 : Window
    {
        private readonly string connectionString = @"Data Source=DESKTOP-AC0US7D\SQLEXPRESS;Initial Catalog=diplom;
        Integrated Security=True";


        public vkladka3()
        {
            InitializeComponent();
            LoadUsers();
            LoadUsers1();
        }

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT fio_users FROM users";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    List<string> users = new List<string>();
                    while (reader.Read())
                    {
                        users.Add(reader["fio_users"].ToString());
                    }
                    viborusers.ItemsSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке пользователей: " + ex.Message);
            }
        }

        private void LoadUsers1()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query11 = "SELECT users.fio_users FROM users where role_users = 'студент'";
                    SqlCommand command1 = new SqlCommand(query11, connection);
                    SqlDataReader reader1 = command1.ExecuteReader();
                    List<string> users1 = new List<string>();
                    while (reader1.Read())
                    {
                        users1.Add(reader1["fio_users"].ToString());
                    }
                    viborstud.ItemsSource = users1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке пользователей: " + ex.Message);
            }
        }

        private void UpdateRole_Click(object sender, RoutedEventArgs e)
        {
            string selectedUser = viborusers.SelectedItem as string;
            if (selectedUser == null)
            {
                MessageBox.Show("Выберите пользователя.");
                return;
            }

            string selectedRole = (roleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedRole == null)
            {
                MessageBox.Show("Выберите роль.");
                return;
            }

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET role_users = @role_users WHERE fio_users = @fio_users";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@fio_users", selectedUser);
                    command.Parameters.AddWithValue("@role_users", selectedRole);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Роль пользователя успешно обновлена.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить роль пользователя.");
                    }
                }



            }

        }

        private void roleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void UpdateGrups_Click(object sender, RoutedEventArgs e)
        {
            string selectedUser = viborstud.SelectedItem as string;
            if (selectedUser == null)
            {
                MessageBox.Show("Выберите Студента.");
                return;
            }

            string selectedGrups = (grupsComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedGrups == null)
            {
                MessageBox.Show("Выберите группу.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE users SET grups_users = @grups_users WHERE fio_users = @fio_users";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@fio_users", selectedUser);
                command.Parameters.AddWithValue("@grups_users", selectedGrups);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Группа пользователя успешно обновлена.");
                }
                else
                {
                    MessageBox.Show("Не удалось обновить группу пользователя.");
                }
            }
        }

        private void Vixod_Click(object sender, RoutedEventArgs e)
        {
            Login login1 = new Login();
            login1.Show();
            Close(); ;
        }
        private void Obnovlenie_Click(object sender, RoutedEventArgs e)
        {
            LoadUsers();
            LoadUsers1();
        }

    }
}
