using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data;
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
    /// Логика взаимодействия для Raspisanie.xaml
    /// </summary>
    public partial class Rasp_prepod : Window
    {

        DataBase DataBase = new DataBase();



        public Rasp_prepod()
        {
            InitializeComponent();
            Vixos_Click.MouseDown += Vixos_Click_MouseDown;
            Uroki.MouseDown += Uroki_MouseDown;
            oneisip22.MouseDown += Oneisip22_MouseDown;
            podklychenie.MouseDown += Podklychenie_MouseDown;
            otchet.MouseDown += Otchet_MouseDown;


            testcolor11.Fill = new SolidColorBrush(Colors.White);
            testcolor12.Fill = new SolidColorBrush(Colors.White);
            testcolor13.Fill = new SolidColorBrush(Colors.White);
            testcolor14.Fill = new SolidColorBrush(Colors.White);

            time.MouseDown += Time_MouseDown;
            time1.MouseDown += Time1_MouseDown;

            
        }

        private void Otchet_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Otchetp otchetp = new Otchetp();
            otchetp.Show();
        }

        private void Podklychenie_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DataBases dataBases = new DataBases();
            dataBases.Show();
            Close();
        }

        private void Time_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content = "8:15";
            label1.Content = "9:50";
            label3.Content = "10:00";
            label4.Content = "11:35";
            label5.Content = "12:00";
            label6.Content = "13:35";
            label7.Content = "13:45";
            label8.Content = "15:20";
        }


        private void Time1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content = "8:15";
            label1.Content = "9:15";
            label3.Content = "9:25";
            label4.Content = "10:25";
            label5.Content = "10:35";
            label6.Content = "11:35";
            label7.Content = "11:45";
            label8.Content = "12:45";
        }

        private void Oneisip22_MouseDown(object sender, MouseButtonEventArgs e)
        {


        }



        public void anikashin_111()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 1";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor11.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet11.Content = sb.ToString();
        }

        public void anikashin_112()
        {
            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 1", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups11.Content = sb.ToString();
        }


        public void anikashin_113()
        {
            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 1", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio11.Content = sb.ToString();
        }

        public void anikashin_114()
        {
            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 1", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud11.Content = sb.ToString();
        }

        public void anikashin_121()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 2";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor12.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet12.Content = sb.ToString();
        }

        public void anikashin_122()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 2", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups12.Content = sb.ToString();
        }


        public void anikashin_123()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 2", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio12.Content = sb.ToString();
        }

        public void anikashin_124()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 2", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud12.Content = sb.ToString();
        }




        public void anikashin_131()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 3";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor13.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet13.Content = sb.ToString();
        }

        public void anikashin_132()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 3", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups13.Content = sb.ToString();
        }


        public void anikashin_133()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 3", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio13.Content = sb.ToString();
        }

        public void anikashin_134()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 3", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud13.Content = sb.ToString();
        }



        public void anikashin_141()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 4";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor14.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet14.Content = sb.ToString();
        }

        public void anikashin_142()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 4", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups14.Content = sb.ToString();
        }


        public void anikashin_143()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 4", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio14.Content = sb.ToString();
        }

        public void anikashin_144()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 4", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud14.Content = sb.ToString();
        }















        public void anikashin_211()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 5";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor21.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet21.Content = sb.ToString();
        }

        public void anikashin_212()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 5", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups21.Content = sb.ToString();
        }


        public void anikashin_213()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 5", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio21.Content = sb.ToString();
        }

        public void anikashin_214()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 5", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud21.Content = sb.ToString();
        }

        public void anikashin_221()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 6";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor22.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet22.Content = sb.ToString();
        }

        public void anikashin_222()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 6", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups22.Content = sb.ToString();
        }


        public void anikashin_223()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 6", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio22.Content = sb.ToString();
        }

        public void anikashin_224()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 6", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud22.Content = sb.ToString();
        }




        public void anikashin_231()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 7";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor23.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet23.Content = sb.ToString();
        }

        public void anikashin_232()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 7", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups23.Content = sb.ToString();
        }


        public void anikashin_233()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 7", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio23.Content = sb.ToString();
        }

        public void anikashin_234()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 7", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud23.Content = sb.ToString();
        }



        public void anikashin_241()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 8";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor24.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet24.Content = sb.ToString();
        }

        public void anikashin_242()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 8", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups24.Content = sb.ToString();
        }


        public void anikashin_243()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 8", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio24.Content = sb.ToString();
        }

        public void anikashin_244()
        {
            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 8", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            aud24.Content = sb.ToString();
        }








        public void anikashin_311()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 9";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor31.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet31.Content = sb.ToString();
        }

        public void anikashin_312()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 9", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups31.Content = sb.ToString();
        }


        public void anikashin_313()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 9", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio31.Content = sb.ToString();
        }

        public void anikashin_314()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 9", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud31.Content = sb.ToString();
        }

        public void anikashin_321()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 10";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor32.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet32.Content = sb.ToString();
        }

        public void anikashin_322()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 10", DataBase.ConnectToDatabase()); ;
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups32.Content = sb.ToString();
        }


        public void anikashin_323()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 10", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio32.Content = sb.ToString();
        }

        public void anikashin_324()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 10", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud32.Content = sb.ToString();
        }




        public void anikashin_331()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 11";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor33.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet33.Content = sb.ToString();
        }

        public void anikashin_332()
        {
            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 11", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups33.Content = sb.ToString();
        }


        public void anikashin_333()
        {
            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 11", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio33.Content = sb.ToString();
        }

        public void anikashin_334()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 11", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud33.Content = sb.ToString();
        }



        public void anikashin_341()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 12";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor34.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet34.Content = sb.ToString();
        }

        public void anikashin_342()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 12", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups34.Content = sb.ToString();
        }


        public void anikashin_343()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 12", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio34.Content = sb.ToString();
        }

        public void anikashin_344()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 12", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud34.Content = sb.ToString();
        }














        public void anikashin_411()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 13";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor41.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet41.Content = sb.ToString();
        }

        public void anikashin_412()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 13", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups41.Content = sb.ToString();
        }


        public void anikashin_413()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 13", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio41.Content = sb.ToString();
        }

        public void anikashin_414()
        {


            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 13", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud41.Content = sb.ToString();
        }

        public void anikashin_421()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 14";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor42.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet42.Content = sb.ToString();
        }

        public void anikashin_422()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 14", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups42.Content = sb.ToString();
        }


        public void anikashin_423()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 14", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio42.Content = sb.ToString();
        }

        public void anikashin_424()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 14", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud42.Content = sb.ToString();
        }




        public void anikashin_431()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 15";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor43.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet43.Content = sb.ToString();
        }

        public void anikashin_432()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 15", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups43.Content = sb.ToString();
        }


        public void anikashin_433()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 15", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio43.Content = sb.ToString();
        }

        public void anikashin_434()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 15", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud43.Content = sb.ToString();
        }



        public void anikashin_441()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 16";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor44.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet44.Content = sb.ToString();
        }

        public void anikashin_442()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 16", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups44.Content = sb.ToString();
        }


        public void anikashin_443()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 16", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio44.Content = sb.ToString();
        }

        public void anikashin_444()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 16", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud44.Content = sb.ToString();
        }








        public void anikashin_511()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 17";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor51.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet51.Content = sb.ToString();
        }

        public void anikashin_512()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 17", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups51.Content = sb.ToString();
        }


        public void anikashin_513()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 17", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio51.Content = sb.ToString();
        }

        public void anikashin_514()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 17", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud51.Content = sb.ToString();
        }

        public void anikashin_521()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 18";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor52.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet52.Content = sb.ToString();
        }

        public void anikashin_522()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 18", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups52.Content = sb.ToString();
        }


        public void anikashin_523()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 18", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio52.Content = sb.ToString();
        }

        public void anikashin_524()
        {
            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 18", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud52.Content = sb.ToString();
        }




        public void anikashin_531()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 19";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor53.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet53.Content = sb.ToString();
        }

        public void anikashin_532()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 19", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups53.Content = sb.ToString();
        }


        public void anikashin_533()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 19", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio53.Content = sb.ToString();
        }

        public void anikashin_534()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 19", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud53.Content = sb.ToString();
        }



        public void anikashin_541()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM anikashin where id = 20 ";
            SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                string colorId = Convert.ToString(table.Rows[0]["podmena"]);
                if (colorId == "Yes")
                {
                    testcolor54.Fill = new SolidColorBrush(Colors.Red);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            predmet54.Content = sb.ToString();
        }

        public void anikashin_542()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM anikashin where id = 20", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            grups54.Content = sb.ToString();
        }


        public void anikashin_543()
        {
            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM anikashin where id = 20", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            fio54.Content = sb.ToString();
        }

        public void anikashin_544()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM anikashin where id = 20", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            aud54.Content = sb.ToString();
        }








        private void Uroki_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Raspisanie4u raspisanie4U = new Raspisanie4u();
            raspisanie4U.Show();
            Close();
        }

        private void Vixos_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
    }
}
