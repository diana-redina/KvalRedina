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
    /// Логика взаимодействия для dobavlenie.xaml
    /// </summary>
    public partial class dobavlenie : Page
    {
        veloclubEntities db = new veloclubEntities();
        int Code;
        public dobavlenie(int cod)
        {
            InitializeComponent();
            Code = cod;

        }

        private void Button_sozdast_Click(object sender, RoutedEventArgs e)
        {
            var newChel = new ychastnik();

            newChel.familia = TB_familia.Text;
            newChel.name = TB_imy.Text;
            newChel.otchestvo = TB_otchestvo.Text;
            newChel.tip_velo = TB_tip.Text;
            newChel.stagh = Convert.ToInt32( TB_stag.Text);
        

            db.ychastnik.Add(newChel);
            db.SaveChanges();
            MessageBox.Show(" Сохранено ");
            NavigationService.GoBack();
        }

        private void Button_BACK2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
    }

