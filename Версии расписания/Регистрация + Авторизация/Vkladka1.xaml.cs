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
using System.Reflection.Emit;

namespace Регистрация
{
    /// <summary>
    /// Логика взаимодействия для Vkladka1.xaml
    /// </summary>
    public partial class Vkladka1 : Window
    {
        public Vkladka1()
        {
            InitializeComponent();
            Pon1isip1par();
            Pon1isip1par1();
            Pon1isip1par2();
        }

        private void Pon1isip1par()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=diplom; Integrated Security=True");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT predmet FROM raspisanie where day = 'понедельник' and para = 1 and grups = '1ИСиП-22'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            predmet.Content = sb.ToString();

            sqlConnection.Close();
        }

        private void Pon1isip1par1()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=diplom; Integrated Security=True");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT grups FROM raspisanie where day = 'понедельник' and para = 1 and predmet = 'математика'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grupa.Content = sb.ToString();

            sqlConnection.Close();
        }
        private void Pon1isip1par2()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=diplom; Integrated Security=True");
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT fio FROM raspisanie where day = 'понедельник' and para = 1 and predmet = 'математика'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio.Content = sb.ToString();

            sqlConnection.Close();
        }

    }
}
