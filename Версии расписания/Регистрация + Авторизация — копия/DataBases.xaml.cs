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
    /// Логика взаимодействия для DataBases.xaml
    /// </summary>
     partial  class  DataBases : Window
    {






        public DataBases()
        {
            InitializeComponent();
        }



        private void saveserver(object sender, MouseButtonEventArgs e)
        {
            string server = serverTextBox.Text;
            string database = databaseTextBox.Text;

            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            else
            { 
                string connectionString = $"Data Source={server}; Initial Catalog={database}; Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MessageBox.Show("Подключено!");
                        Raspisanie raspisanie = new Raspisanie();
                        raspisanie.Show();
                        Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Не удалось подключиться: {ex.Message}");
                    }
                }
            }
        }





        private void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            
        }



            
        }
    }

