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
using System.Drawing;
using System.Data.Common;

namespace Регистрация
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {

        private DataBase SqlConnetcion;



        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;



        public Admin()
        {
            InitializeComponent();
            vixod.MouseDown += Vixod_MouseDown;
        }


        private void ApplyFilter()
        {
            List<string> filters = new List<string>();

            if (checkBoxFilter1.IsChecked == true)
                filters.Add("grups_users = '2ИСиП-22'");

            if (checkBoxFilter2.IsChecked == true)
                filters.Add("grups_users = '1исип-22'");

            if (checkBoxFilter3.IsChecked == true)
                filters.Add("role_users = 'студент'");

            if (checkBoxFilter4.IsChecked == true)
                filters.Add("role_users = 'преподаватель'");


            string filterCondition = string.Join(" AND ", filters);

            if (!string.IsNullOrEmpty(filterCondition))
            {
                DataView dataView = dataGrid.ItemsSource as DataView;
                dataView.RowFilter = filterCondition;
            }
            else
            {
                (dataGrid.ItemsSource as DataView).RowFilter = "";
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ApplyFilter();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ApplyFilter();
        }


        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            string query = "SELECT id_users, fio_users, email_users,  grups_users, role_users FROM users";
            dataAdapter = new SqlDataAdapter(query, _connection());
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGrid.ItemsSource = dataTable.DefaultView;


            string searchText = searchTextBox.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                DataView dv = dataTable.DefaultView;
                dv.RowFilter = string.Format("fio_users LIKE '%{0}%'", searchText);
                dataGrid.ItemsSource = dv;
            }
            else if (searchTextBox.Text == null)
            {

                string query1 = "SELECT id_users, fio_users, email_users,  grups_users, role_users FROM users";
                dataAdapter = new SqlDataAdapter(query1, SqlConnection.);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGrid.ItemsSource = dataTable.DefaultView;
            }
            else
            {
                dataGrid.ItemsSource = dataTable.DefaultView;
            }

        }

        private void Vixod_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Raspisanie4u raspisanie4U = new Raspisanie4u();
            raspisanie4U.Show();
            Close();
        }
    }
}
