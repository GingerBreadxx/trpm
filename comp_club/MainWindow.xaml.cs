using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;


namespace comp_club
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();




        }

        private void login_in_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sidorov;Integrated Security=True";
            string logins = login.Text;
            string passwords = password.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM user_A WHERE login = @logins AND password = @passwords";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", logins);
                    command.Parameters.AddWithValue("@password", passwords);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // Пользователь успешно вошел в систему
                        MainWindow mainWindow = new MainWindow(); // Создайте новый экземпляр главного окна
                        mainWindow.Show(); // Откройте главное окно
                        this.Close(); // Закройте текущее окно (окно входа в систему)
                    }
                    else
                    {
                        // Неверное имя пользователя или пароль
                        MessageBox.Show("Неверное имя пользователя или пароль");
                    }
                }
            }
        }




        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (login.Text == null)
            {
            }
            else
            {
            }

        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (password.Text == null)
            {
            }
            else
            {
            }
        }

        private void reg_in_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu reg = new AdminMenu();
            this.Close();
            reg.Show();
        }
    }
}
