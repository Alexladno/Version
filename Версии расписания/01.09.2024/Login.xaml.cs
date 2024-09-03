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
using System.IO;

namespace Регистрация
{
    public partial class Login : Window
    {
        DataBase DataBase = new DataBase();
        Rasp_stud rasp_stud = new Rasp_stud();
        Rasp_prepod rasp_prepod = new Rasp_prepod();
        public Login()
        {
            InitializeComponent();

            Registr_CLick.MouseDown += Registr_CLick_MouseDown;
            Voiti_Click.MouseDown += Voiti_Click_MouseDown;
            LoadConfiguration();
        }


        // Метод для загрузки конфигурации из файла
        private void LoadConfiguration()
        {
            try
            {
                string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "config.txt");

                if (File.Exists(configPath))
                {

                    var configLines = File.ReadAllLines(configPath);
                    foreach (var line in configLines)
                    {
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            switch (parts[0].Trim())
                            {
                                case "Email":
                                    emailbox.Text = parts[1].Trim();
                                    break;
                                case "Pass":
                                    passbox.Text = parts[1].Trim();
                                    break;
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Некорректная строка в конфигурации: {line}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Файл конфигурации не найден.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке конфигурации: {ex.Message}");
            }
        }

        private void Voiti_Click_MouseDown(object sender, MouseButtonEventArgs e)
        {

            var emailUser = emailbox.Text;
            var passUser = passbox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_users, pass_users, fio_users, email_users, role_users, grups_and_fio, verification_users from users where email_users = '{emailUser}' and pass_users = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, DataBase.ConnectToDatabase());

            adapter.SelectCommand = command;
            adapter.Fill(table);

         int verificator = Convert.ToInt32(table.Rows[0]["verification_users"]);
            if (verificator == 0)
            {
                MessageBox.Show("Ваша заявка на регистрацию еще не одобрена.");
            }
            else
            {





                if (table.Rows.Count == 1)
                {

                    string roleId = Convert.ToString(table.Rows[0]["role_users"]);
                    if (roleId == "студент")
                    {

                        string grupsId = Convert.ToString(table.Rows[0]["grups_and_fio"]);
                        if (grupsId == "1исип-22")
                        {
                            MessageBox.Show("Вы успешно вошли как студент группы 1ИСиП-22!");
                            rasp_stud.Show();
                            rasp_stud.oneisip22_111();
                            rasp_stud.oneisip22_112();
                            rasp_stud.oneisip22_113();
                            rasp_stud.oneisip22_114();
                            rasp_stud.oneisip22_121();
                            rasp_stud.oneisip22_122();
                            rasp_stud.oneisip22_123();
                            rasp_stud.oneisip22_124();
                            rasp_stud.oneisip22_131();
                            rasp_stud.oneisip22_132();
                            rasp_stud.oneisip22_133();
                            rasp_stud.oneisip22_134();
                            rasp_stud.oneisip22_141();
                            rasp_stud.oneisip22_142();
                            rasp_stud.oneisip22_143();
                            rasp_stud.oneisip22_144();

                            rasp_stud.oneisip22_211();
                            rasp_stud.oneisip22_212();
                            rasp_stud.oneisip22_213();
                            rasp_stud.oneisip22_214();
                            rasp_stud.oneisip22_221();
                            rasp_stud.oneisip22_222();
                            rasp_stud.oneisip22_223();
                            rasp_stud.oneisip22_224();
                            rasp_stud.oneisip22_231();
                            rasp_stud.oneisip22_232();
                            rasp_stud.oneisip22_233();
                            rasp_stud.oneisip22_234();
                            rasp_stud.oneisip22_241();
                            rasp_stud.oneisip22_242();
                            rasp_stud.oneisip22_243();
                            rasp_stud.oneisip22_244();


                            rasp_stud.oneisip22_311();
                            rasp_stud.oneisip22_312();
                            rasp_stud.oneisip22_313();
                            rasp_stud.oneisip22_314();
                            rasp_stud.oneisip22_321();
                            rasp_stud.oneisip22_322();
                            rasp_stud.oneisip22_323();
                            rasp_stud.oneisip22_324();
                            rasp_stud.oneisip22_331();
                            rasp_stud.oneisip22_332();
                            rasp_stud.oneisip22_333();
                            rasp_stud.oneisip22_334();
                            rasp_stud.oneisip22_341();
                            rasp_stud.oneisip22_342();
                            rasp_stud.oneisip22_343();
                            rasp_stud.oneisip22_344();


                            rasp_stud.oneisip22_411();
                            rasp_stud.oneisip22_412();
                            rasp_stud.oneisip22_413();
                            rasp_stud.oneisip22_414();
                            rasp_stud.oneisip22_421();
                            rasp_stud.oneisip22_422();
                            rasp_stud.oneisip22_423();
                            rasp_stud.oneisip22_424();
                            rasp_stud.oneisip22_431();
                            rasp_stud.oneisip22_432();
                            rasp_stud.oneisip22_433();
                            rasp_stud.oneisip22_434();
                            rasp_stud.oneisip22_441();
                            rasp_stud.oneisip22_442();
                            rasp_stud.oneisip22_443();
                            rasp_stud.oneisip22_444();



                            rasp_stud.oneisip22_511();
                            rasp_stud.oneisip22_512();
                            rasp_stud.oneisip22_513();
                            rasp_stud.oneisip22_514();
                            rasp_stud.oneisip22_521();
                            rasp_stud.oneisip22_522();
                            rasp_stud.oneisip22_523();
                            rasp_stud.oneisip22_524();
                            rasp_stud.oneisip22_531();
                            rasp_stud.oneisip22_532();
                            rasp_stud.oneisip22_533();
                            rasp_stud.oneisip22_534();
                            rasp_stud.oneisip22_541();
                            rasp_stud.oneisip22_542();
                            rasp_stud.oneisip22_543();
                            rasp_stud.oneisip22_544();

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

                        string fioId = Convert.ToString(table.Rows[0]["grups_and_fio"]);
                        if (fioId == "anikashin")
                        {
                            MessageBox.Show("Аникашин Д.И. вы успешно вошли как преподаватель !");
                            rasp_prepod.Show();
                            rasp_prepod.anikashin_111();
                            rasp_prepod.anikashin_112();
                            rasp_prepod.anikashin_113();
                            rasp_prepod.anikashin_114();
                            rasp_prepod.anikashin_121();
                            rasp_prepod.anikashin_122();
                            rasp_prepod.anikashin_123();
                            rasp_prepod.anikashin_124();
                            rasp_prepod.anikashin_131();
                            rasp_prepod.anikashin_132();
                            rasp_prepod.anikashin_133();
                            rasp_prepod.anikashin_134();
                            rasp_prepod.anikashin_141();
                            rasp_prepod.anikashin_142();
                            rasp_prepod.anikashin_143();
                            rasp_prepod.anikashin_144();

                            rasp_prepod.anikashin_211();
                            rasp_prepod.anikashin_212();
                            rasp_prepod.anikashin_213();
                            rasp_prepod.anikashin_214();
                            rasp_prepod.anikashin_221();
                            rasp_prepod.anikashin_222();
                            rasp_prepod.anikashin_223();
                            rasp_prepod.anikashin_224();
                            rasp_prepod.anikashin_231();
                            rasp_prepod.anikashin_232();
                            rasp_prepod.anikashin_233();
                            rasp_prepod.anikashin_234();
                            rasp_prepod.anikashin_241();
                            rasp_prepod.anikashin_242();
                            rasp_prepod.anikashin_243();
                            rasp_prepod.anikashin_244();

                            rasp_prepod.anikashin_311();
                            rasp_prepod.anikashin_312();
                            rasp_prepod.anikashin_313();
                            rasp_prepod.anikashin_314();
                            rasp_prepod.anikashin_321();
                            rasp_prepod.anikashin_322();
                            rasp_prepod.anikashin_323();
                            rasp_prepod.anikashin_324();
                            rasp_prepod.anikashin_331();
                            rasp_prepod.anikashin_332();
                            rasp_prepod.anikashin_333();
                            rasp_prepod.anikashin_334();
                            rasp_prepod.anikashin_341();
                            rasp_prepod.anikashin_342();
                            rasp_prepod.anikashin_343();
                            rasp_prepod.anikashin_344();



                            rasp_prepod.anikashin_411();
                            rasp_prepod.anikashin_412();
                            rasp_prepod.anikashin_413();
                            rasp_prepod.anikashin_414();
                            rasp_prepod.anikashin_421();
                            rasp_prepod.anikashin_422();
                            rasp_prepod.anikashin_423();
                            rasp_prepod.anikashin_424();
                            rasp_prepod.anikashin_431();
                            rasp_prepod.anikashin_432();
                            rasp_prepod.anikashin_433();
                            rasp_prepod.anikashin_434();
                            rasp_prepod.anikashin_441();
                            rasp_prepod.anikashin_442();
                            rasp_prepod.anikashin_443();
                            rasp_prepod.anikashin_444();

                            rasp_prepod.anikashin_511();
                            rasp_prepod.anikashin_512();
                            rasp_prepod.anikashin_513();
                            rasp_prepod.anikashin_514();
                            rasp_prepod.anikashin_521();
                            rasp_prepod.anikashin_522();
                            rasp_prepod.anikashin_523();
                            rasp_prepod.anikashin_524();
                            rasp_prepod.anikashin_531();
                            rasp_prepod.anikashin_532();
                            rasp_prepod.anikashin_533();
                            rasp_prepod.anikashin_534();
                            rasp_prepod.anikashin_541();
                            rasp_prepod.anikashin_542();
                            rasp_prepod.anikashin_543();
                            rasp_prepod.anikashin_544();
                        }
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

        private void Registr_CLick_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Registration login = new Registration();
            login.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBases dataBases = new DataBases();
            dataBases.Show();
        }
    }
}