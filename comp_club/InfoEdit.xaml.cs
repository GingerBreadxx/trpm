using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для InfoEdit.xaml
    /// </summary>
    public partial class InfoEdit : Window
    {
        private user_A _currentUser = new user_A();

        public InfoEdit()
        {
            InitializeComponent();
            DataContext = _currentUser;
            comboUser.ItemsSource = SidorovEntities.GetContext().user_A.ToList();

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrEmpty(_currentUser.login))
            {
                MessageBox.Show("Поле не введено");
            }
            if (string.IsNullOrEmpty(_currentUser.password))
            {
                MessageBox.Show("Поле не введено");

            }
            if (_currentUser.id == 0)
                SidorovEntities.GetContext().user_A.Add(_currentUser);
            try
            {
                SidorovEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешно!!");
                AdminMenu admin = new AdminMenu();
                this.Close();
                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
