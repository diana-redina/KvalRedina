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
    /// Логика взаимодействия для grunt.xaml
    /// </summary>
    public partial class grunt : Page
    {
        veloclubEntities db = new veloclubEntities();
        public grunt(int Id_merop)
        {
            InitializeComponent();
            TB_grunt.Text = db.poverhnosti.Where(t => t.cod_poverhnosti == Id_merop).Select(t => t.tip_poverhnosti).FirstOrDefault().ToString();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {

        }
    }
}
