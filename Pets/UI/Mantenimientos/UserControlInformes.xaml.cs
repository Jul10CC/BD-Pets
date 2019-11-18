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
using BLL;
namespace UI.Mantenimientos
{
    /// <summary>
    /// Lógica de interacción para UserControlInformes.xaml
    /// </summary>
    public partial class UserControlInformes : UserControl
    {
        public UserControlInformes()
        {
            InitializeComponent();
        }

        private void ButtonInforme_Click(object sender, RoutedEventArgs e)
        {
            //Reporte 1
            ClassConsultas Lg = new ClassConsultas();
            this.dataGrid1.ItemsSource = Lg.sp_informe1(this.dateFecha1.Text);
            this.dataGrid1.ItemsSource = Lg.sp_informe1(this.dateFecha2.Text);
        }

        private void ButtonInforme_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonInforme_Copy_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonInforme_Copy_Click_2(object sender, RoutedEventArgs e)
        {
            //Reporte 2
            ClassConsultas Lg = new ClassConsultas();
            this.dataGrid1.ItemsSource = Lg.sp_informe2(this.dateFecha1.Text);
            this.dataGrid1.ItemsSource = Lg.sp_informe2(this.dateFecha2.Text);
        }

        private void ButtonInforme_Copy1_Click(object sender, RoutedEventArgs e)
        {
            //Reporte 3
            ClassConsultas Lg = new ClassConsultas();
            this.dataGrid1.ItemsSource = Lg.sp_informe3(this.dateFecha1.Text);
            this.dataGrid1.ItemsSource = Lg.sp_informe3(this.dateFecha2.Text);
        }

        private void ButtonInforme_Copy2_Click(object sender, RoutedEventArgs e)
        {
            //Reporte4
            ClassConsultas Lg = new ClassConsultas();
            this.dataGrid1.ItemsSource = Lg.sp_informe4(this.TextCantidad.Text);

        }
    }
}
