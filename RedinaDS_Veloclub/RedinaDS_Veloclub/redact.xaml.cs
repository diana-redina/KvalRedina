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
    /// Логика взаимодействия для redact.xaml
    /// </summary>
    public partial class redact : Page
    {
        veloclubEntities db = new veloclubEntities();
        int Code;
        public redact(int cod)
        {

            InitializeComponent();
            Code = cod;
            TB_familia.Text = db.ychastnik.Where(t => t.cod_ucastnika == cod).Select(t => t.familia).FirstOrDefault().ToString();
            TB_imy.Text = db.ychastnik.Where(t => t.cod_ucastnika == cod).Select(t => t.name).FirstOrDefault().ToString();
            TB_otchestvo.Text = db.ychastnik.Where(t => t.cod_ucastnika == cod).Select(t => t.otchestvo).FirstOrDefault().ToString();
            TB_stag.Text = db.ychastnik.Where(t => t.cod_ucastnika == cod).Select(t => t.stagh).FirstOrDefault().ToString();
            TB_tip.Text = db.ychastnik.Where(t => t.cod_ucastnika == cod).Select(t => t.tip_velo).FirstOrDefault().ToString();
         
        }

        private void Button_BACK2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_sozdast_Click(object sender, RoutedEventArgs e)
        {
            var ism = db.ychastnik.Where(o => o.cod_ucastnika == Code).FirstOrDefault();
            ism.familia = TB_familia.Text;
            ism.name = TB_imy.Text;
            ism.stagh = Convert.ToInt32(TB_stag.Text);
            ism.otchestvo = TB_otchestvo.Text;
            ism.tip_velo = TB_tip.Text;
         

            db.SaveChanges();
        }
    }
}
