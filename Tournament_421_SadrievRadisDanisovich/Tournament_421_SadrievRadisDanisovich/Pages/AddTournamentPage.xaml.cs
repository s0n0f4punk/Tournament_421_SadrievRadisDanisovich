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
    /// Логика взаимодействия для AddTournamentPage.xaml
    /// </summary>
    public partial class AddTournamentPage : Page
    {
        Tournament tournament = new Tournament();
        public AddTournamentPage()
        {
            InitializeComponent();
            GameCbx.ItemsSource = App.db.Game.ToList();
            GameCbx.DisplayMemberPath = "Name";
            FormatCbx.ItemsSource = App.db.TournamentCategory.ToList();
            FormatCbx.DisplayMemberPath = "Name";
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
                tournament.Name = NameTb.Text;
                tournament.StartDate = StartDate.DisplayDate;
                tournament.StartTime = (TimeSpan.Parse($"{TimeStartHour.Text}:{TimeStartMinute.Text}"));
                tournament.Id_Category = (FormatCbx.SelectedItem as TournamentCategory).id;
                tournament.Id_Game = (GameCbx.SelectedItem as Game).Id;
                tournament.Prize = decimal.Parse(PrizeTb.Text);
                tournament.MinRange = decimal.Parse(MinRangeTb.Text);
                App.db.Tournament.Add(tournament);
                App.db.SaveChanges();
                MessageBox.Show("Турнир добавлен");
                NavigationService.Navigate(new TournamentList());

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Что-то пошло не так. Ошибка: " + ex.Message);
            //}
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TournamentList());
        }
    }
}
