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
using MODELS;
using BLL;
using System.Collections;
namespace UI.Mantenimientos
{
    /// <summary>
    /// Lógica de interacción para UserControlAnulacion.xaml
    /// </summary>
    public partial class UserControlAnulacion : UserControl
    {
        public UserControlAnulacion()
        {
            InitializeComponent();
        }

        private void Texto_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonConfirmar_Click(object sender, RoutedEventArgs e)
        {
            //Anulacion
            ClassConsultas anulacion = new ClassConsultas();
            anulacion.sp_anularfacturas(TextID.Text);
            MessageBox.Show("La Factura Seleccionada fue Anulada");
            //ClassConsultas consulta = new ClassConsultas();
            //dataGrid1.ItemsSource = consulta.SP_MostrarFactura().Cast<sp_MostrarFactura_Result>().Where(s => s.Total > 0).ToList();
            //buttonAnular.IsEnabled = false;
        }

        private void ButtonAnular_Copy_Click(object sender, RoutedEventArgs e)
        {
            //Buscar Factura
            try
            {
                ClassConsultas consulta = new ClassConsultas();
                dataGrid1.ItemsSource = consulta.sp_informe5(TextID.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("No se encontro la factura ingresada");
            }
        }

        private void TextID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
