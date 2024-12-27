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
    /// Логика взаимодействия для AddRequestPage.xaml
    /// </summary>
    public partial class AddRequestPage : Page
    {
        Tournament tour;
        TornamentMembers tm = new TornamentMembers();
        public AddRequestPage(Tournament _tour)
        {
            InitializeComponent();
            tour = _tour;
            TournamentName.Text = tour.Name;
            if (tour.Id_Category != 2) CrewList.Visibility = Visibility.Collapsed;

        }

        private void AddCompetitor_Click(object sender, RoutedEventArgs e)
        {
            if (tour.Id == 0) App.db.TornamentMembers.Add(tm);
            MembersCrew mc = new MembersCrew();
            mc.Id_TournamentMember = tm.Id;
            mc.FIO = FIOTb.Text;
            App.db.MembersCrew.Add(mc);
            App.db.SaveChanges();
            CompetitorsList.ItemsSource = App.db.MembersCrew.Where(x=>x.Id_TournamentMember == tm.Id).ToList();
        }

        private void AddRequestBtn_Click(object sender, RoutedEventArgs e)
        {
            tm.Id_Tournament = tour.Id;
            tm.Id_Competitor = App.currentUser.Id;
            tm.Id_Status = 1;
            if (tour.Id == 0) App.db.TornamentMembers.Add(tm);
            App.db.SaveChanges();
            MessageBox.Show("Заявка отправлена");
            NavigationService.Navigate(new TournamentList());
        }

        private void BacktBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TournamentList());
        }
    }
}
