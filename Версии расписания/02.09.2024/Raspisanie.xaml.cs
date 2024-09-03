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
    public partial class Raspisanie : Window
    {

        DataBase DataBase = new DataBase();



        public  Raspisanie()
        {
            InitializeComponent();
            Vixos_Click.MouseDown += Vixos_Click_MouseDown;
            Uroki.MouseDown += Uroki_MouseDown;
            Onerezim.MouseDown += Onerezim_MouseDown;
            Tworezim.MouseDown += Tworezim_MouseDown;
            Admin.MouseDown += Admin_MouseDown;
            oneisip22.MouseDown += Oneisip22_MouseDown;
            podklychenie.MouseDown += Podklychenie_MouseDown;
            otchet.MouseDown += Otchet_MouseDown;


            testcolor11.Fill = new SolidColorBrush(Colors.White);
            testcolor12.Fill = new SolidColorBrush(Colors.White);
            testcolor13.Fill = new SolidColorBrush(Colors.White);
            testcolor14.Fill = new SolidColorBrush(Colors.White);

            time.MouseDown += Time_MouseDown;
            time1.MouseDown += Time1_MouseDown;

            label.Content = "8:15";
            label1.Content = "9:50";
            label3.Content = "10:00";
            label4.Content = "11:35";
            label5.Content = "12:00";
            label6.Content = "13:35";
            label7.Content = "13:45";
            label8.Content = "15:20";





            oneisip22_111();
            oneisip22_112();
            oneisip22_113();
            oneisip22_114();
            oneisip22_121();
            oneisip22_122();
            oneisip22_123();
            oneisip22_124();
            oneisip22_131();
            oneisip22_132();
            oneisip22_133();
            oneisip22_134();
            oneisip22_141();
            oneisip22_142();
            oneisip22_143();
            oneisip22_144();

            oneisip22_211();
            oneisip22_212();
            oneisip22_213();
            oneisip22_214();
            oneisip22_221();
            oneisip22_222();
            oneisip22_223();
            oneisip22_224();
            oneisip22_231();
            oneisip22_232();
            oneisip22_233();
            oneisip22_234();
            oneisip22_241();
            oneisip22_242();
            oneisip22_243();
            oneisip22_244();


            oneisip22_311();
            oneisip22_312();
            oneisip22_313();
            oneisip22_314();
            oneisip22_321();
            oneisip22_322();
            oneisip22_323();
            oneisip22_324();
            oneisip22_331();
            oneisip22_332();
            oneisip22_333();
            oneisip22_334();
            oneisip22_341();
            oneisip22_342();
            oneisip22_343();
            oneisip22_344();


            oneisip22_411();
            oneisip22_412();
            oneisip22_413();
            oneisip22_414();
            oneisip22_421();
            oneisip22_422();
            oneisip22_423();
            oneisip22_424();
            oneisip22_431();
            oneisip22_432();
            oneisip22_433();
            oneisip22_434();
            oneisip22_441();
            oneisip22_442();
            oneisip22_443();
            oneisip22_444();



            oneisip22_511();
            oneisip22_512();
            oneisip22_513();
            oneisip22_514();
            oneisip22_521();
            oneisip22_522();
            oneisip22_523();
            oneisip22_524();
            oneisip22_531();
            oneisip22_532();
            oneisip22_533();
            oneisip22_534();
            oneisip22_541();
            oneisip22_542();
            oneisip22_543();
            oneisip22_544();
        }


        private bool calendarOpened = false;
        private void OpenCalendarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!calendarOpened)
            {
                ScheduleCalendar.Visibility = Visibility.Visible;
                LoadScheduleButton.Visibility = Visibility.Visible;
                calendarOpened = true;
            }
            else
            {
                ScheduleCalendar.Visibility = Visibility.Collapsed;
                LoadScheduleButton.Visibility = Visibility.Collapsed;
                calendarOpened = false;
            }
        }


        private void LoadScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduleCalendar.SelectedDate.HasValue)
            {
                DateTime selectedDate = ScheduleCalendar.SelectedDate.Value;
                LoadWeekSchedule(selectedDate);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите дату.", "Информация");
            }
        }

        private void LoadWeekSchedule(DateTime selectedDate)
        {
            DateTime startOfWeek = GetStartOfWeek(selectedDate);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            ClearLabels();

            HighlightSelectedDay(selectedDate.DayOfWeek);

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startOfWeek.AddDays(i);
                LoadScheduleForDay(currentDay);
            }
        }

        private DateTime GetStartOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff).Date;
        }

        private void LoadScheduleForDay(DateTime date)
        {
            string query = "SELECT TOP 4 name_predmet, fio_prepod, name_grup, number_aud " +
               "FROM oneisip22 " + // Пробел добавлен после имени таблицы
               "WHERE CONVERT(date, data_pari, 104) = @date";


            SqlParameter parameter = new SqlParameter("@date", date.ToString("dd.MM.yyyy"));

            try
            {
                DataTable dataTable = DataBase.ExecuteQuery(query, new SqlParameter[] { parameter });

                int lessonIndex = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    int numberAud;
                    if (int.TryParse(row["number_aud"].ToString(), out numberAud))
                    {
                        UpdateLabelsForDay(date.DayOfWeek, lessonIndex,
                            row["name_predmet"].ToString(),
                            row["fio_prepod"].ToString(),
                            row["name_grup"].ToString(),
                            numberAud);
                    }
                    lessonIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка");
            }
        }

        private void UpdateLabelsForDay(DayOfWeek dayOfWeek, int lessonIndex, string subject, string teacher, string group, int room)
        {
            string subjectLabelName = $"{dayOfWeek}Lesson{lessonIndex}SubjectLabel";
            string teacherLabelName = $"{dayOfWeek}Lesson{lessonIndex}TeacherLabel";
            string groupLabelName = $"{dayOfWeek}Lesson{lessonIndex}GroupLabel";
            string roomLabelName = $"{dayOfWeek}Lesson{lessonIndex}RoomLabel";

            Label subjectLabel = (Label)FindName(subjectLabelName);
            Label teacherLabel = (Label)FindName(teacherLabelName);
            Label groupLabel = (Label)FindName(groupLabelName);
            Label roomLabel = (Label)FindName(roomLabelName);

            if (subjectLabel != null) subjectLabel.Content = $"{subject}";
            if (teacherLabel != null) teacherLabel.Content = $"{teacher}";
            if (groupLabel != null) groupLabel.Content = $"{group}";
            if (roomLabel != null) roomLabel.Content = $"{room}";
        }

        private void ClearLabels()
        {
            foreach (DayOfWeek dayOfWeek in Enum.GetValues(typeof(DayOfWeek)))
            {
                for (int i = 1; i <= 4; i++)
                {
                    string subjectLabelName = $"{dayOfWeek}Lesson{i}SubjectLabel";
                    string teacherLabelName = $"{dayOfWeek}Lesson{i}TeacherLabel";
                    string groupLabelName = $"{dayOfWeek}Lesson{i}GroupLabel";
                    string roomLabelName = $"{dayOfWeek}Lesson{i}RoomLabel";

                    Label subjectLabel = (Label)FindName(subjectLabelName);
                    Label teacherLabel = (Label)FindName(teacherLabelName);
                    Label groupLabel = (Label)FindName(groupLabelName);
                    Label roomLabel = (Label)FindName(roomLabelName);

                    if (subjectLabel != null) subjectLabel.Content = string.Empty;
                    if (teacherLabel != null) teacherLabel.Content = string.Empty;
                    if (groupLabel != null) groupLabel.Content = string.Empty;
                    if (roomLabel != null) roomLabel.Content = string.Empty;
                }
            }
        }

        private void HighlightSelectedDay(DayOfWeek dayOfWeek)
        {
            MondayLabel.Fill = Brushes.Transparent;
            TuesdayLabel.Fill = Brushes.Transparent;
            WednesdayLabel.Fill = Brushes.Transparent;
            ThursdayLabel.Fill = Brushes.Transparent;
            FridayLabel.Fill = Brushes.Transparent;
            SaturdayLabel.Fill = Brushes.Transparent;
            SundayLabel.Fill = Brushes.Transparent;

            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    MondayLabel.Fill = Brushes.Yellow;
                    break;
                case DayOfWeek.Tuesday:
                    TuesdayLabel.Fill = Brushes.Yellow;
                    break;
                case DayOfWeek.Wednesday:
                    WednesdayLabel.Fill = Brushes.Yellow;
                    break;
                case DayOfWeek.Thursday:
                    ThursdayLabel.Fill = Brushes.Yellow;
                    break;
                case DayOfWeek.Friday:
                    FridayLabel.Fill = Brushes.Yellow;
                    break;
                case DayOfWeek.Saturday:
                    SaturdayLabel.Fill = Brushes.Yellow;
                    break;
                case DayOfWeek.Sunday:
                    SundayLabel.Fill = Brushes.Yellow;
                    break;
            }
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
        }

        private void Time_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label.Content  = "8:15";
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



        public void oneisip22_111()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 1";
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
            MondayLesson1SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_112()
        {
            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 1", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson1GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_113()
        {
            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 1", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson1TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_114()
        {
            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 1", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson1RoomLabel.Content = sb.ToString();
        }

        private void oneisip22_121()
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
            MondayLesson2SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_122()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 2", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson2GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_123()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 2", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson2TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_124()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 2", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson2RoomLabel.Content = sb.ToString();
        }




        private void oneisip22_131()
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
            MondayLesson3SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_132()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 3", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson3GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_133()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 3", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson3TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_134()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 3", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson3RoomLabel.Content = sb.ToString();
        }



        private void oneisip22_141()
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
            MondayLesson4SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_142()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 4", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson4GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_143()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 4", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson4TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_144()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 4", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            MondayLesson4RoomLabel.Content = sb.ToString();
        }















        private void oneisip22_211()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 5";
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
            TuesdayLesson1SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_212()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 5", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson1GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_213()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 5", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson1TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_214()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 5", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson1RoomLabel.Content = sb.ToString();
        }

        private void oneisip22_221()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 6";
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
            TuesdayLesson2SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_222()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 6", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson2GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_223()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 6", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson2TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_224()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 6", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson2RoomLabel.Content = sb.ToString();
        }




        private void oneisip22_231()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 7";
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
            TuesdayLesson3SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_232()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 7", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson3GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_233()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 7", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson3TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_234()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 7", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson3RoomLabel.Content = sb.ToString();
        }



        private void oneisip22_241()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 8";
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
            TuesdayLesson4SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_242()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 8", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson4GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_243()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 8", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            TuesdayLesson4TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_244()
        {
            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 8", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }
            TuesdayLesson4RoomLabel.Content = sb.ToString();
        }








        private void oneisip22_311()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 9";
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
            WednesdayLesson1SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_312()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 9", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson1GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_313()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 9", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson1TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_314()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 9", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson1RoomLabel.Content = sb.ToString();
        }

        private void oneisip22_321()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 10";
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
            WednesdayLesson2SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_322()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 10", DataBase.ConnectToDatabase()); ;
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson2GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_323()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 10", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson2TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_324()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 10", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson2RoomLabel.Content = sb.ToString();
        }




        private void oneisip22_331()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 11";
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
            WednesdayLesson3SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_332()
        {
            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 11", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson3GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_333()
        {
            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 11", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson3TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_334()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 11", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson3RoomLabel.Content = sb.ToString();
        }



        private void oneisip22_341()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 12";
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
            WednesdayLesson4SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_342()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 12", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson4GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_343()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 12", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson4TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_344()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 12", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            WednesdayLesson4RoomLabel.Content = sb.ToString();
        }














        private void oneisip22_411()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 13";
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
            ThursdayLesson1SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_412()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 13", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson1GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_413()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 13", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson1TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_414()
        {


            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 13", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson1RoomLabel.Content = sb.ToString();
        }

        private void oneisip22_421()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 14";
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
            ThursdayLesson2SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_422()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 14", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson2GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_423()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 14", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson2TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_424()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 14", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson2RoomLabel.Content = sb.ToString();
        }




        private void oneisip22_431()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 15";
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
            ThursdayLesson3SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_432()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 15", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson3GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_433()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 15", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson3TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_434()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 15", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson3RoomLabel.Content = sb.ToString();
        }



        private void oneisip22_441()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 16";
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
            ThursdayLesson4SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_442()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 16", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson4GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_443()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 16", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson4TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_444()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 16", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            ThursdayLesson4RoomLabel.Content = sb.ToString();
        }








        private void oneisip22_511()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 17";
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
            FridayLesson1SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_512()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 17", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson1GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_513()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 17", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson1TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_514()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 17", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson1RoomLabel.Content = sb.ToString();
        }

        private void oneisip22_521()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 18";
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
            FridayLesson2SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_522()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 18", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson2GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_523()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 18", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson2TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_524()
        {
            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 18", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson2RoomLabel.Content = sb.ToString();
        }




        private void oneisip22_531()
        {

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 19";
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
            FridayLesson3SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_532()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 19", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson3GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_533()
        {

            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 19", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson3TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_534()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 19", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson3RoomLabel.Content = sb.ToString();
        }



        private void oneisip22_541()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"SELECT name_predmet, podmena FROM oneisip22 where id = 20 ";
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
            FridayLesson4SubjectLabel.Content = sb.ToString();
        }

        private void oneisip22_542()
        {

            SqlCommand command = new SqlCommand("SELECT name_grup FROM oneisip22 where id = 20", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson4GroupLabel.Content = sb.ToString();
        }


        private void oneisip22_543()
        {
            SqlCommand command = new SqlCommand("SELECT fio_prepod FROM oneisip22 where id = 20", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson4TeacherLabel.Content = sb.ToString();
        }

        private void oneisip22_544()
        {

            SqlCommand command = new SqlCommand("SELECT number_aud FROM oneisip22 where id = 20", DataBase.ConnectToDatabase());
            SqlDataReader reader = command.ExecuteReader();

            StringBuilder sb = new StringBuilder();


            while (reader.Read())
            {
                // Assuming the table has only one column
                sb.AppendLine(reader[0].ToString());
            }


            FridayLesson4RoomLabel.Content = sb.ToString();
        }






        private void Admin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            Close();
        }

        private void Tworezim_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rezimtwo rezim1 = new Rezimtwo();
            rezim1.Show();
        }

        private void Onerezim_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rezim rezim = new Rezim();
            rezim.Show();
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
