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
    /// Логика взаимодействия для TournamentList.xaml
    /// </summary>
    public partial class TournamentList : Page
    {
        public List<Tournament> tournament;
        public TournamentList()
        {
            InitializeComponent();
            if (App.currentUser.Id_Role != 3) AddTour.Visibility = Visibility.Collapsed;
            tournament = App.db.Tournament.ToList();
            TournamentLV.ItemsSource = tournament;
        }

        private void AddTour_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTournamentPage());
        }
    }
}
