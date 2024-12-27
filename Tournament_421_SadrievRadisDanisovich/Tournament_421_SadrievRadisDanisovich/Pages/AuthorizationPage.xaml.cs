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

namespace Tournament_421_SadrievRadisDanisovich.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (App.db.User.Where(x => (x.Email == LoginTb.Text || x.Phone == LoginTb.Text) && x.Password == PassTb.Password).Any())
            {
                App.currentUser = App.db.User.Where(x => (x.Email == LoginTb.Text || x.Phone == LoginTb.Text) && x.Password == PassTb.Password).FirstOrDefault();
                if (App.currentUser.Id_Role == 3) NavigationService.Navigate(new TournamentList());
            }
            else MessageBox.Show("Неправильный логин или пароль");
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
