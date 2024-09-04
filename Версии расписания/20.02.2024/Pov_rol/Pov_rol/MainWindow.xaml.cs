using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace UserRoleManagement
{
    public partial class MainWindow : Window
    {
        private readonly string connectionString = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=diplom;
        Integrated Security=True";

        public MainWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT login FROM users";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    List<string> users = new List<string>();
                    while (reader.Read())
                    {
                        users.Add(reader["login"].ToString());
                    }
                    userComboBox.ItemsSource = users;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке пользователей: " + ex.Message);
            }
        }

        private void UpdateRole_Click(object sender, RoutedEventArgs e)
        {
            string selectedUser = userComboBox.SelectedItem as string;
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

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET id_role = role WHERE login = login";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", selectedRole);
                    command.Parameters.AddWithValue("@id_role", selectedUser);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении роли пользователя: " + ex.Message);
            }
        }
    }
}