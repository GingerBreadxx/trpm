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
using System.Data;
using System.Data.SqlClient;

namespace comp_club
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {

        public AdminMenu()
        {
            InitializeComponent();
            list.ItemsSource = SidorovEntities.GetContext().user_A.ToList();
        }
       

        private void down_data_Click(object sender, RoutedEventArgs e)
        {
     
            }

        private void addInfo_Click(object sender, RoutedEventArgs e)
        {
            InfoEdit infoEdit = new InfoEdit();
            infoEdit.ShowDialog();
            
        }


    }
    }
