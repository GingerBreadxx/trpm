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

namespace comp_club
{
    /// <summary>
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        public registration()
        {
            InitializeComponent();
        }

        private void login_in_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logbut = new MainWindow();
            logbut.Show();
        }

        private void reg_in_Click(object sender, RoutedEventArgs e)
        {
            string logins = login.Text; // Получение имени пользователя из TextBox
            string passwords = password.Text; // Получение пароля из PasswordBox
            string phones = phone.Text;
            string fios = fio.Text;

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sidorov;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO user_A (login, password, fio , phone) VALUES (@login, @password, @fio, @phone)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", logins);
                    command.Parameters.AddWithValue("@password", passwords);
                    command.Parameters.AddWithValue("fio", fios);
                    command.Parameters.AddWithValue("@phone", phones);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Пользователь успешно зарегистрирован!");
        }
    }
    }

