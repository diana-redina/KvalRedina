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
    /// Логика взаимодействия для meropriatia.xaml
    /// </summary>
    public partial class meropriatia : Page
    {
        veloclubEntities db = new veloclubEntities();
        
            
            public meropriatia()
        {
            InitializeComponent();
            meropGrid.ItemsSource = db.pokatyshki.ToList();
        }

        private void Button_tip_Click(object sender, RoutedEventArgs e)
        {
            int Id_merop = Convert.ToInt32((sender as Button).Uid);
            NavigationService.Navigate(new grunt(Id_merop));
        }

        private void Button_redact_Click(object sender, RoutedEventArgs e)
        {
            int Id_merop = Convert.ToInt32((sender as Button).Uid);
            NavigationService.Navigate(new redact_merop(Id_merop));
        }

        private void Button_nazad_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
