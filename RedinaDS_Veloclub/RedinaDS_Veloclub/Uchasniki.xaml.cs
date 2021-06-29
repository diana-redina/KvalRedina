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

namespace RedinaDS_Veloclub
{
    /// <summary>
    /// Логика взаимодействия для Uchasniki.xaml
    /// </summary>
    public partial class Uchasniki : Page
    {
        veloclubEntities db = new veloclubEntities();
        public Uchasniki()
        {
            InitializeComponent();
            UchasnikiGrid.ItemsSource = db.ychastnik.ToList();
        }

        private void Button_dob_Click(object sender, RoutedEventArgs e)
        {
            int Id_chelovek = Convert.ToInt32((sender as Button).Uid);
            NavigationService.Navigate(new dobavlenie(Id_chelovek));
        }

        private void Button_nazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_redact_Click(object sender, RoutedEventArgs e)
        {
            int Id_chelovek = Convert.ToInt32((sender as Button).Uid);
            NavigationService.Navigate(new redact(Id_chelovek));
        }

        private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            var num = Convert.ToInt32((sender as Button).Uid);
            var delchel = db.ychastnik.Where(o => o.cod_ucastnika == num).FirstOrDefault();
            db.ychastnik.Remove(delchel);

            NavigationService.Navigate(new Uchasniki());
            db.SaveChanges();
        }
    }
}
