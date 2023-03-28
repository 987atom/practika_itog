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
using System.Windows.Navigation;
using System.Windows.Shapes;

using PRAktika_itog.praktika2DataSetTableAdapters;

namespace PRAktika_itog
{
    public partial class MainWindow : Window
    {
        animalsTableAdapter animals = new animalsTableAdapter();
        AviaryTableAdapter Aviary = new AviaryTableAdapter();
        benefitsTableAdapter benefits = new benefitsTableAdapter();
        environmentTableAdapter environment = new environmentTableAdapter();
        postTableAdapter post = new postTableAdapter();
        rateTableAdapter rate = new rateTableAdapter();
        tiketTableAdapter tiket = new tiketTableAdapter();
        tillTableAdapter till = new tillTableAdapter();
        type_of_animalsTableAdapter type_of_Animals = new type_of_animalsTableAdapter();
        usersTableAdapter users = new usersTableAdapter();
        workersTableAdapter workers = new workersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_ClickWhod(object sender, RoutedEventArgs e)
        {
            string pas = pswrdChck.Password;
            string log = LoginTXT.Text;
            string rol = RollTXT.Text;

            var elem = users.GetData().FirstOrDefault(element => element.loginn == log && element.passwordd == pas && element.rol == rol);
            if (elem != null)
            {
                PageFrame.Visibility = Visibility.Visible;

                if (rol == "admin")
                {
                    PageFrame.Content = new animalsPage();
                }
                else if (rol == "user")
                {
                    PageFrame.Content = new tiketPage1();
                }
            }
            else
            {
                MessageBox.Show("Были введены не верные данные");
            }
        }
    }
}
