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
    /// Логика взаимодействия для redact_merop.xaml
    /// </summary>
    public partial class redact_merop : Page
    {
        veloclubEntities db = new veloclubEntities();
        int Code;
       
            public redact_merop(int cod)
        {
            InitializeComponent();
                Code = cod;
            }

        private void Button_sozdast_Click(object sender, RoutedEventArgs e)
        {
            var ism = db.pokatyshki.Where(o => o.cod_pokatyshek == Code).FirstOrDefault();

            ism.nazvanie = TB_imy.Text;
            ism.col_vo_km = Convert.ToInt32(TB_km.Text);
            ism.data = Convert.ToDateTime(TB_data.Text);
            ism.sred_skorosti = Convert.ToInt32(TB_skor.Text);
         


            db.SaveChanges();
        }

        private void Button_BACK2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
