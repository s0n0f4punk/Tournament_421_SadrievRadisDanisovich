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
using Tournament_421_SadrievRadisDanisovich.Components;

namespace Tournament_421_SadrievRadisDanisovich.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            RoleCbx.ItemsSource = App.db.Role.Where(x=>x.Id != 3).ToList();
            RoleCbx.DisplayMemberPath = "Role1";

            PlayingRoleCbx.ItemsSource = App.db.PlayingRole.ToList();
            PlayingRoleCbx.DisplayMemberPath = "Name";
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = new User();
                user.Surname = SurnameTb.Text;
                user.Name = NameTb.Text;
                user.Patronymic = PatronymicTb.Text;
                user.Email = EmailTb.Text;
                user.Phone = PhoneTb.Text;
                user.Password = PasswordTb.Password;
                user.Id_Role = (RoleCbx.SelectedItem as Role).Id;
                if (user.Id_Role == 1)
                {
                    user.Id_PlayingRole = (PlayingRoleCbx.SelectedItem as PlayingRole).Id;
                    user.IsCrew = CrewCheck.IsChecked;
                    if (CrewCheck.IsChecked == true)
                        user.CrewName = CrewName.Text;
                }
                App.db.User.Add(user);
                App.db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так. Ошибка" + ex.Message);
            }
            finally 
            {
                NavigationService.Navigate(new AuthorizationPage());
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void RoleCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((RoleCbx.SelectedItem as Role).Role1 == "Участник")
            {
                PlayingRoleSP.Visibility = Visibility.Visible;
                CrewCheckSP.Visibility = Visibility.Visible;
            }
            else
            {
                PlayingRoleSP.Visibility = Visibility.Collapsed;
                PlayingRoleCbx.SelectedIndex = -1;
                CrewCheckSP.Visibility = Visibility.Collapsed;
                CrewCheck.IsChecked = false;
            }
        }

        private void CrewCheck_Checked(object sender, RoutedEventArgs e)
        {
            CrewNameSP.Visibility = Visibility.Visible;
        }

        private void CrewCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            CrewNameSP.Visibility = Visibility.Collapsed;
            CrewName.Text = string.Empty;
        }
    }
}
