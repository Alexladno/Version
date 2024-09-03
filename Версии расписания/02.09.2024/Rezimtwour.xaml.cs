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
    /// Логика взаимодействия для Rezimtwour.xaml
    /// </summary>
    public partial class Rezimtwour : Window
    {
        DataBase DataBase = new DataBase();

        public Rezimtwour()
        {
            InitializeComponent();

            sbros.MouseDown += Sbros_MouseDown;
            primenit.MouseDown += Primenit_MouseDown;
        }

        private void Primenit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            string selectedDay = (vibordnya.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedDay == null)
            {
                MessageBox.Show("Выберите день недели.");
                return;
            }


            string selectedUrok = (viboruroka.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedUrok == null)
            {
                MessageBox.Show("Выберите урок.");
                return;
            }

            string selectedAud = (viboraud.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedAud == null)
            {
                MessageBox.Show("Выберите класс.");
                return;
            }

            string selectedPredmet = (viborpredmet.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedPredmet == null)
            {
                MessageBox.Show("Выберите предмет.");
                return;
            }

            string selectedFio = (viborfio.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedFio == null)
            {
                MessageBox.Show("Выберите ФИО.");
                return;
            }

            string selectedTable = (vibortable.SelectedItem as ComboBoxItem)?.Content.ToString();
            if (selectedTable == null)
            {
                MessageBox.Show("Выберите день недели.");
                return;
            }


            {
              
                    string query = $"UPDATE {selectedTable} SET name_predmet = @name_predmet, number_aud = @number_aud, fio_prepod = @fio_prepod, podmena = 'No' WHERE name_day  = @name_day  and yrok = @yrok";
                    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
                command.Parameters.AddWithValue("@name_day", selectedDay);
                    command.Parameters.AddWithValue("@yrok", selectedUrok);
                    command.Parameters.AddWithValue("@number_aud", selectedAud);
                    command.Parameters.AddWithValue("@name_predmet", selectedPredmet);
                    command.Parameters.AddWithValue("@fio_prepod", selectedFio);
                    command.Parameters.AddWithValue("@name_table", selectedTable);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Расписание успешно обновлено.");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить расписание.");
                    }
                
            }
        }

        private void Sbros_MouseDown(object sender, MouseButtonEventArgs e)
        {
            vibordnya.SelectedItem = null;
            vibordnya.SelectedValue = null;
            vibordnya.SelectedIndex = -1;

            viboruroka.SelectedItem = null;
            viboruroka.SelectedValue = null;
            viboruroka.SelectedIndex = -1;


            vibortable.SelectedItem = null;
            vibortable.SelectedValue = null;
            vibortable.SelectedIndex = -1;

            viborpredmet.SelectedItem = null;
            viborpredmet.SelectedValue = null;
            viborpredmet.SelectedIndex = -1;

            viborfio.SelectedItem = null;
            viborfio.SelectedValue = null;
            viborfio.SelectedIndex = -1;

            viboraud.SelectedItem = null;
            viboraud.SelectedValue = null;
            viboraud.SelectedIndex = -1;
        }
    }
}
