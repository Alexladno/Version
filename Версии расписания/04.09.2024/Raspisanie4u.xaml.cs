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
using System.Data.Entity;

namespace Регистрация
{
    /// <summary>
    /// Логика взаимодействия для Raspisanie4u.xaml
    /// </summary>
    public partial class Raspisanie4u : Window
    {

        DataBase DataBase = new DataBase();

        public Raspisanie4u()
        {
            InitializeComponent();
            pari.MouseDown += Pari_MouseDown;
            Vixod_Click.MouseDown += Vixod_Click_MouseDown;
            Admin.MouseDown += Admin_MouseDown;
            rezimur.MouseDown += Rezimur_MouseDown;
            rezimtwour.MouseDown += Rezimtwour_MouseDown;
            Datasource.MouseDown += Datasource_MouseDown;
            otchet.MouseDown += Otchet_MouseDown1;


            time.MouseDown += Time_MouseDown;
            time1.MouseDown += Time1_MouseDown;

            label1.Content = "8:00";
            label2.Content = "8:45";
            label3.Content = "8:55";
            label4.Content = "9:40";
            label5.Content = "9:55";
            label6.Content = "10:40";
            label7.Content = "10:55";
            label8.Content = "11:40";
            label9.Content = "11:50";
            label10.Content = "12:35";
            label11.Content = "12:45";
            label12.Content = "13:30";
            label13.Content = "13:40";
            label14.Content = "14:25";
            label15.Content = "14:35";
            label16.Content = "15:20";




            //oneisip22_111(); 
            //oneisip22_112();  
            //oneisip22_113(); 
            //oneisip22_114();

            //oneisip22_121(); 
            //oneisip22_122();  
            //oneisip22_123(); 
            //oneisip22_124();

            //oneisip22_131(); 
            //oneisip22_132();  
            //oneisip22_133(); 
            //oneisip22_134();
            
            //oneisip22_141(); 
            //oneisip22_142();  
            //oneisip22_143(); 
            //oneisip22_144();

            
            //oneisip22_151(); 
            //oneisip22_152(); 
            //oneisip22_153();  
            //oneisip22_154();

            //oneisip22_161(); 
            //oneisip22_162(); 
            //oneisip22_163(); 
            //oneisip22_164();

            //oneisip22_171(); 
            //oneisip22_172(); 
            //oneisip22_173(); 
            //oneisip22_174();


            //oneisip22_181(); 
            //oneisip22_182(); 
            //oneisip22_183(); 
            //oneisip22_184();





            //oneisip22_211();
            //oneisip22_212();
            //oneisip22_213();
            //oneisip22_214();

            //oneisip22_221();
            //oneisip22_222();
            //oneisip22_223();
            //oneisip22_224();

            //oneisip22_231();
            //oneisip22_232();
            //oneisip22_233();
            //oneisip22_234();


            //oneisip22_241();
            //oneisip22_242();
            //oneisip22_243();
            //oneisip22_244();


            //oneisip22_251();
            //oneisip22_252();
            //oneisip22_253();
            //oneisip22_254();

            //oneisip22_261();
            //oneisip22_262();
            //oneisip22_263();
            //oneisip22_264();
       
            //oneisip22_271();
            //oneisip22_272();
            //oneisip22_273();
            //oneisip22_274();


            //oneisip22_281();
            //oneisip22_282();
            //oneisip22_283();
            //oneisip22_284();





            //oneisip22_311();    //норм
            //oneisip22_312();    //норм
            //oneisip22_313();    //норм
            //oneisip22_314();    //норм

            //oneisip22_321();
            //oneisip22_322();
            //oneisip22_323();
            //oneisip22_324();

            //oneisip22_331();
            //oneisip22_332();
            //oneisip22_333();
            //oneisip22_334();


            //oneisip22_341();
            //oneisip22_342();
            //oneisip22_343();
            //oneisip22_344();


            //oneisip22_351();
            //oneisip22_352();
            //oneisip22_353();
            //oneisip22_354();

            //oneisip22_361();
            //oneisip22_362();
            //oneisip22_363();
            //oneisip22_364();

            //oneisip22_371();
            //oneisip22_372();
            //oneisip22_373();
            //oneisip22_374();


            //oneisip22_381();
            //oneisip22_382();
            //oneisip22_383();
            //oneisip22_384();




            //oneisip22_411();
            //oneisip22_412();
            //oneisip22_413();
            //oneisip22_414();

            //oneisip22_421();
            //oneisip22_422();
            //oneisip22_423();
            //oneisip22_424();

            //oneisip22_431();
            //oneisip22_432();
            //oneisip22_433();
            //oneisip22_434();


            //oneisip22_441();
            //oneisip22_442();
            //oneisip22_443();
            //oneisip22_444();


            //oneisip22_451();
            //oneisip22_452();
            //oneisip22_453();
            //oneisip22_454();

            //oneisip22_461();
            //oneisip22_462();
            //oneisip22_463();
            //oneisip22_464();

            //oneisip22_471();
            //oneisip22_472();
            //oneisip22_473();
            //oneisip22_474();


            //oneisip22_481();
            //oneisip22_482();
            //oneisip22_483();
            //oneisip22_484();







            //oneisip22_511();
            //oneisip22_512();
            //oneisip22_513();
            //oneisip22_514();

            //oneisip22_521();
            //oneisip22_522();
            //oneisip22_523();
            //oneisip22_524();

            //oneisip22_531();
            //oneisip22_532();
            //oneisip22_533();
            //oneisip22_534();


            //oneisip22_541();
            //oneisip22_542();
            //oneisip22_543();
            //oneisip22_544();


            //oneisip22_551();
            //oneisip22_552();
            //oneisip22_553();
            //oneisip22_554();

            //oneisip22_561();
            //oneisip22_562();
            //oneisip22_563();
            //oneisip22_564();

            //oneisip22_571();
            //oneisip22_572();
            //oneisip22_573();
            //oneisip22_574();


            //oneisip22_581();
            //oneisip22_582();
            //oneisip22_583();
            //oneisip22_584();




        }

        private void Otchet_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            Otchety otchety = new Otchety();
            otchety.Show();
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
            string query = "SELECT TOP 8 name_predmet, fio_prepod, name_class, number_aud " +
               "FROM ninea " + // Пробел добавлен после имени таблицы
               "WHERE CONVERT(date, data_yroka, 104) = @date";


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
                            row["name_class"].ToString(),
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
                for (int i = 1; i <= 8; i++)
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



        private void Time_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "8:00";
            label2.Content = "8:45";
            label3.Content = "8:55";
            label4.Content = "9:40";
            label5.Content = "9:55";
            label6.Content = "10:40";
            label7.Content = "10:55";
            label8.Content = "11:40";
            label9.Content = "11:50";
            label10.Content = "12:35";
            label11.Content = "12:45";
            label12.Content = "13:30";
            label13.Content = "13:40";
            label14.Content = "14:25";
            label15.Content = "14:35";
            label16.Content = "15:20";
        }

        private void Time1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "8:00";
            label2.Content = "8:30";
            label3.Content = "8:40";
            label4.Content = "9:10";
            label5.Content = "9:20";
            label6.Content = "9:50";
            label7.Content = "10:00";
            label8.Content = "10:30";
            label9.Content = "10:40";
            label10.Content = "11:10";
            label11.Content = "11:40";
            label12.Content = "12:10";
            label13.Content = "12:40";
            label14.Content = "13:10";
            label15.Content = "13:40";
            label16.Content = "14:10";

        }

        

        private void Datasource_MouseDown(object sender, MouseButtonEventArgs e)
        {
           DataBases dataBases = new DataBases();
            dataBases.Show();
        }


        private void Admin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Admin admintwo = new Admin();
            admintwo.Show();
            Close();
        }

        private void Vixod_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void Pari_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Raspisanie raspisanie = new Raspisanie();
            raspisanie.Show();
            Close();
        }

        private void Rezimur_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rezimur rezimur = new Rezimur();
            rezimur.Show();
        }

        private void Rezimtwour_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Rezimtwour rezimur1 = new Rezimtwour();
            rezimur1.Show();
        }



        //private void oneisip22_111()
        //{


        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 1";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor11.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet11.Content = sb.ToString();
        //}

        //private void oneisip22_112()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 1", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas11.Content = sb.ToString();
        //}


        //private void oneisip22_113()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 1", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio11.Content = sb.ToString();
        //}

        //private void oneisip22_114()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 1", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud11.Content = sb.ToString();
        //}









        //private void oneisip22_121()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 2";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor12.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet12.Content = sb.ToString();
        //}

        //private void oneisip22_122()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 2", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas12.Content = sb.ToString();
        //}


        //private void oneisip22_123()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 2", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio12.Content = sb.ToString();
        //}

        //private void oneisip22_124()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 2", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud12.Content = sb.ToString();
        //}








        //private void oneisip22_131()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 3";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor13.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet13.Content = sb.ToString();
        //}

        //private void oneisip22_132()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 3", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas13.Content = sb.ToString();
        //}


        //private void oneisip22_133()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 3", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio13.Content = sb.ToString();
        //}

        //private void oneisip22_134()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 3", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud13.Content = sb.ToString();
        //}










        //private void oneisip22_141()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 4";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor14.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet14.Content = sb.ToString();
        //}

        //private void oneisip22_142()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 4", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas14.Content = sb.ToString();
        //}


        //private void oneisip22_143()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 4", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio14.Content = sb.ToString();
        //}

        //private void oneisip22_144()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 4", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud14.Content = sb.ToString();
        //}
















        //private void oneisip22_151()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 5";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor15.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet15.Content = sb.ToString();
        //}

        //private void oneisip22_152()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 5", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas15.Content = sb.ToString();
        //}


        //private void oneisip22_153()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 5", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio15.Content = sb.ToString();
        //}

        //private void oneisip22_154()
        //{
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 5", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud15.Content = sb.ToString();
        //}









        //private void oneisip22_161()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 6";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor16.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet16.Content = sb.ToString();
        //}

        //private void oneisip22_162()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 6", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas16.Content = sb.ToString();
        //}


        //private void oneisip22_163()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 6", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio16.Content = sb.ToString();
        //}

        //private void oneisip22_164()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 6", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud16.Content = sb.ToString();
        //}








        //private void oneisip22_171()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 7";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor17.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet17.Content = sb.ToString();
        //}

        //private void oneisip22_172()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 7", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas17.Content = sb.ToString();
        //}


        //private void oneisip22_173()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 7", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio17.Content = sb.ToString();
        //}

        //private void oneisip22_174()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 7", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud13.Content = sb.ToString();
        //}



        //private void oneisip22_181()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 8";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor18.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet18.Content = sb.ToString();
        //}

        //private void oneisip22_182()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 8", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas18.Content = sb.ToString();
        //}


        //private void oneisip22_183()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 8", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio18.Content = sb.ToString();
        //}

        //private void oneisip22_184()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 8", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud18.Content = sb.ToString();
        //}



















        //private void oneisip22_211()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 9";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor21.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet21.Content = sb.ToString();
        //}

        //private void oneisip22_212()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 9", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas21.Content = sb.ToString();
        //}


        //private void oneisip22_213()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 9", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio21.Content = sb.ToString();
        //}

        //private void oneisip22_214()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 9", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud21.Content = sb.ToString();
        //}









        //private void oneisip22_221()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 10";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor22.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet22.Content = sb.ToString();
        //}

        //private void oneisip22_222()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 10", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas22.Content = sb.ToString();
        //}


        //private void oneisip22_223()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 10", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio22.Content = sb.ToString();
        //}

        //private void oneisip22_224()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 10", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud22.Content = sb.ToString();
        //}








        //private void oneisip22_231()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 11";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor23.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet23.Content = sb.ToString();
        //}

        //private void oneisip22_232()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 11", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas23.Content = sb.ToString();
        //}


        //private void oneisip22_233()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 11", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio23.Content = sb.ToString();
        //}

        //private void oneisip22_234()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 11", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud23.Content = sb.ToString();
        //}










        //private void oneisip22_241()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 12";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor24.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet24.Content = sb.ToString();
        //}

        //private void oneisip22_242()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 12", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas24.Content = sb.ToString();
        //}


        //private void oneisip22_243()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 12", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio24.Content = sb.ToString();
        //}

        //private void oneisip22_244()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 12", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud24.Content = sb.ToString();
        //}
















        //private void oneisip22_251()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 13";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor25.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet25.Content = sb.ToString();
        //}

        //private void oneisip22_252()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 13", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas25.Content = sb.ToString();
        //}


        //private void oneisip22_253()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 13", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio25.Content = sb.ToString();
        //}

        //private void oneisip22_254()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 13", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud25.Content = sb.ToString();
        //}









        //private void oneisip22_261()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 14";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor26.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet26.Content = sb.ToString();
        //}

        //private void oneisip22_262()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 14", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas26.Content = sb.ToString();
        //}


        //private void oneisip22_263()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 14", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio26.Content = sb.ToString();
        //}

        //private void oneisip22_264()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 14", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud26.Content = sb.ToString();
        //}








        //private void oneisip22_271()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 15";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor27.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet27.Content = sb.ToString();
        //}

        //private void oneisip22_272()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 15", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas27.Content = sb.ToString();
        //}


        //private void oneisip22_273()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 15", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio27.Content = sb.ToString();
        //}

        //private void oneisip22_274()
        //{
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id =15", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud27.Content = sb.ToString();
        //}



        //private void oneisip22_281()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 16";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor28.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet28.Content = sb.ToString();
        //}

        //private void oneisip22_282()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 16", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas28.Content = sb.ToString();
        //}


        //private void oneisip22_283()
        //{ 

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 16", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio28.Content = sb.ToString();
        //}

        //private void oneisip22_284()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 16", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud28.Content = sb.ToString();
        //}














        //private void oneisip22_311()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 17";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor31.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet31.Content = sb.ToString();
        //}

        //private void oneisip22_312()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 17", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas31.Content = sb.ToString();
        //}


        //private void oneisip22_313()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 17", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio31.Content = sb.ToString();
        //}

        //private void oneisip22_314()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 17", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud31.Content = sb.ToString();
        //}









        //private void oneisip22_321()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 18";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor32.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet32.Content = sb.ToString();
        //}

        //private void oneisip22_322()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 18", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas32.Content = sb.ToString();
        //}


        //private void oneisip22_323()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 18", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio32.Content = sb.ToString();
        //}

        //private void oneisip22_324()
        //{
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 18", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud32.Content = sb.ToString();
        //}








        //private void oneisip22_331()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 19";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor33.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet33.Content = sb.ToString();
        //}

        //private void oneisip22_332()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 19", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas33.Content = sb.ToString();
        //}


        //private void oneisip22_333()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 19", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio33.Content = sb.ToString();
        //}

        //private void oneisip22_334()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 19", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud33.Content = sb.ToString();
        //}










        //private void oneisip22_341()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 20";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor34.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet34.Content = sb.ToString();
        //}

        //private void oneisip22_342()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 20", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas34.Content = sb.ToString();
        //}


        //private void oneisip22_343()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 20", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio34.Content = sb.ToString();
        //}

        //private void oneisip22_344()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 20", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud34.Content = sb.ToString();
        //}
















        //private void oneisip22_351()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 21";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor35.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet35.Content = sb.ToString();
        //}

        //private void oneisip22_352()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 21", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas35.Content = sb.ToString();
        //}


        //private void oneisip22_353()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 21", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio35.Content = sb.ToString();
        //}

        //private void oneisip22_354()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 21", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud35.Content = sb.ToString();
        //}









        //private void oneisip22_361()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 22";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor36.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet36.Content = sb.ToString();
        //}

        //private void oneisip22_362()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 22", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas36.Content = sb.ToString();
        //}


        //private void oneisip22_363()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 22", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio36.Content = sb.ToString();
        //}

        //private void oneisip22_364()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 22", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud36.Content = sb.ToString();
        //}








        //private void oneisip22_371()
        //{
           
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 23";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor37.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet37.Content = sb.ToString();
        //}

        //private void oneisip22_372()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 23", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas37.Content = sb.ToString();
        //}


        //private void oneisip22_373()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 23", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio37.Content = sb.ToString();
        //}

        //private void oneisip22_374()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 23", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud37.Content = sb.ToString();
        //}



        //private void oneisip22_381()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 24";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor38.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet38.Content = sb.ToString();
        //}

        //private void oneisip22_382()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 24", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas38.Content = sb.ToString();
        //}


        //private void oneisip22_383()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 24", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio38.Content = sb.ToString();
        //}

        //private void oneisip22_384()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 24", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud38.Content = sb.ToString();
        //}



















        //private void oneisip22_411()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 25";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor41.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet41.Content = sb.ToString();
        //}

        //private void oneisip22_412()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 25", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas41.Content = sb.ToString();
        //}


        //private void oneisip22_413()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 25", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio41.Content = sb.ToString();
        //}

        //private void oneisip22_414()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 25", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud41.Content = sb.ToString();
        //}









        //private void oneisip22_421()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 26";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor42.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet42.Content = sb.ToString();
        //}

        //private void oneisip22_422()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 26", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas42.Content = sb.ToString();
        //}


        //private void oneisip22_423()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 26", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio42.Content = sb.ToString();
        //}

        //private void oneisip22_424()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 26", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud42.Content = sb.ToString();
        //}








        //private void oneisip22_431()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 27";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor43.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet43.Content = sb.ToString();
        //}

        //private void oneisip22_432()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 27", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas43.Content = sb.ToString();
        //}


        //private void oneisip22_433()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 27", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio43.Content = sb.ToString();
        //}

        //private void oneisip22_434()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 27", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud43.Content = sb.ToString();
        //}










        //private void oneisip22_441()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 28";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor44.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet44.Content = sb.ToString();
        //}

        //private void oneisip22_442()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 28", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas44.Content = sb.ToString();
        //}


        //private void oneisip22_443()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 28", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio44.Content = sb.ToString();
        //}

        //private void oneisip22_444()
        //{
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 28", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud44.Content = sb.ToString();
        //}
















        //private void oneisip22_451()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 29";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor45.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet45.Content = sb.ToString();
        //}

        //private void oneisip22_452()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 29", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas45.Content = sb.ToString();
        //}


        //private void oneisip22_453()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 29", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio45.Content = sb.ToString();
        //}

        //private void oneisip22_454()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 29", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud45.Content = sb.ToString();
        //}









        //private void oneisip22_461()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 30";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor46.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet46.Content = sb.ToString();
        //}

        //private void oneisip22_462()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 30", DataBase.ConnectToDatabase()); 
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas46.Content = sb.ToString();
        //}


        //private void oneisip22_463()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 30", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio46.Content = sb.ToString();
        //}

        //private void oneisip22_464()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 30", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud46.Content = sb.ToString();
        //}








        //private void oneisip22_471()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 31";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor47.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet47.Content = sb.ToString();
        //}

        //private void oneisip22_472()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 31", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas47.Content = sb.ToString();
        //}


        //private void oneisip22_473()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 31", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio47.Content = sb.ToString();
        //}

        //private void oneisip22_474()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id =31", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud47.Content = sb.ToString();
        //}



        //private void oneisip22_481()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 32";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor48.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet48.Content = sb.ToString();
        //}

        //private void oneisip22_482()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 32", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas48.Content = sb.ToString();
        //}


        //private void oneisip22_483()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 32", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio48.Content = sb.ToString();
        //}

        //private void oneisip22_484()
        //{
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 32", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud48.Content = sb.ToString();
        //}
















        //private void oneisip22_511()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 33";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor51.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet51.Content = sb.ToString();
        //}

        //private void oneisip22_512()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 33", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas51.Content = sb.ToString();
        //}


        //private void oneisip22_513()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 33", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio51.Content = sb.ToString();
        //}

        //private void oneisip22_514()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 33", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud51.Content = sb.ToString();
        //}









        //private void oneisip22_521()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 34";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor52.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet52.Content = sb.ToString();
        //}

        //private void oneisip22_522()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 34", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas52.Content = sb.ToString();
        //}


        //private void oneisip22_523()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 34", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio52.Content = sb.ToString();
        //}

        //private void oneisip22_524()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 34", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud52.Content = sb.ToString();
        //}








        //private void oneisip22_531()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 35";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor53.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet53.Content = sb.ToString();
        //}

        //private void oneisip22_532()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 35", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas53.Content = sb.ToString();
        //}


        //private void oneisip22_533()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 35", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio53.Content = sb.ToString();
        //}

        //private void oneisip22_534()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 35", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud53.Content = sb.ToString();
        //}










        //private void oneisip22_541()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 36";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor54.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet54.Content = sb.ToString();
        //}

        //private void oneisip22_542()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 36", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas54.Content = sb.ToString();
        //}


        //private void oneisip22_543()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 36", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio54.Content = sb.ToString();
        //}

        //private void oneisip22_544()
        //{ 
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 36", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud54.Content = sb.ToString();
        //}
















        //private void oneisip22_551()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 37";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor55.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet55.Content = sb.ToString();
        //}

        //private void oneisip22_552()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 37", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas55.Content = sb.ToString();
        //}


        //private void oneisip22_553()
        //{
        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 37", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio55.Content = sb.ToString();
        //}

        //private void oneisip22_554()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 37", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud55.Content = sb.ToString();
        //}









        //private void oneisip22_561()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 38";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor56.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet56.Content = sb.ToString();
        //}

        //private void oneisip22_562()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 38", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas56.Content = sb.ToString();
        //}


        //private void oneisip22_563()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 38", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio56.Content = sb.ToString();
        //}

        //private void oneisip22_564()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 38", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud56.Content = sb.ToString();
        //}








        //private void oneisip22_571()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 39";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor57.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet57.Content = sb.ToString();
        //}

        //private void oneisip22_572()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 39", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas57.Content = sb.ToString();
        //}


        //private void oneisip22_573()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 39", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio57.Content = sb.ToString();
        //}

        //private void oneisip22_574()
        //{
        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id =39", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud57.Content = sb.ToString();
        //}



        //private void oneisip22_581()
        //{

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    DataTable table = new DataTable();
        //    string query = $"SELECT name_predmet, podmena FROM ninea where id = 40";
        //    SqlCommand command = new SqlCommand(query, DataBase.ConnectToDatabase());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);
        //    if (table.Rows.Count == 1)
        //    {
        //        string colorId = Convert.ToString(table.Rows[0]["podmena"]);
        //        if (colorId == "Yes")
        //        {
        //            testcolor58.Fill = new SolidColorBrush(Colors.Red);
        //        }
        //    }
        //    SqlDataReader reader = command.ExecuteReader();
        //    StringBuilder sb = new StringBuilder();
        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }
        //    predmet58.Content = sb.ToString();
        //}

        //private void oneisip22_582()
        //{
        //    SqlCommand command = new SqlCommand("SELECT name_class FROM ninea where id = 40", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    clas58.Content = sb.ToString();
        //}


        //private void oneisip22_583()
        //{

        //    SqlCommand command = new SqlCommand("SELECT fio_prepod FROM ninea where id = 40", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    fio58.Content = sb.ToString();
        //}

        //private void oneisip22_584()
        //{

        //    SqlCommand command = new SqlCommand("SELECT number_aud FROM ninea where id = 40", DataBase.ConnectToDatabase());
        //    SqlDataReader reader = command.ExecuteReader();

        //    StringBuilder sb = new StringBuilder();


        //    while (reader.Read())
        //    {
        //        // Assuming the table has only one column
        //        sb.AppendLine(reader[0].ToString());
        //    }


        //    aud58.Content = sb.ToString();
        //}



        

    }
}
