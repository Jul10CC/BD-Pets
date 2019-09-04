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
    /// Lógica de interacción para UserControlEmpleado.xaml
    /// </summary>
    public partial class UserControlEmpleado : UserControl
    {
        public UserControlEmpleado()
        {
            InitializeComponent();
        }

        private void TextApellidoCliente_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonAgregar_Click(object sender, RoutedEventArgs e)
        {
            buttonAgregar.Visibility = Visibility.Hidden;
            buttonGrabar.Visibility = Visibility.Visible;
            buttonEditar.IsEnabled = false;
            buttonListar.IsEnabled = false;
            buttonCancelar.IsEnabled = true;
            dataGrid1.ItemsSource = null;
        }

        private void ButtonGrabar_Click(object sender, RoutedEventArgs e)
        {
            ClassEmpleado Logica = new ClassEmpleado();
            string resp = Logica.NuevoEmpleado(TextNombre.Text, TextApellido.Text, TextCorreo.Text, TextTel1.Text, TextTel2.Text);
            if (resp.ToUpper().Contains("ERROR"))
                MessageBox.Show(resp, "Error al grabar", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBox.Show(resp);
                buttonAgregar.Visibility = Visibility.Visible;
                buttonGrabar.Visibility = Visibility.Hidden;
                buttonListar.IsEnabled = true;
                buttonCancelar.IsEnabled = false;
            }
        }

        private void ButtonEditar_Click(object sender, RoutedEventArgs e)
        {
            if (TextEmpleadoId.Text != "")
            {
                string resp = "";
                ClassEmpleado Logica = new ClassEmpleado();
                Empleado EMP = new Empleado();
                EMP.EmpleadoID = Convert.ToInt32(this.TextEmpleadoId.Text);
                EMP.Nombre = this.TextNombre.Text;
                EMP.Apellido = this.TextApellido.Text;
                EMP.Correo = this.TextCorreo.Text;
                EMP.Telefono1 = this.TextTel1.Text;
                EMP.Telefono2 = this.TextTel2.Text;
                resp = Logica.ActualizarEmpleado(EMP);
                MessageBox.Show(resp);

            }
            else
            {
                MessageBox.Show("Marque el registro a modificar", "Error al Editar",
                MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        private void ButtonListar_Click(object sender, RoutedEventArgs e)
        {
            ClassEmpleado Logica = new ClassEmpleado();
            dataGrid1.ItemsSource = Logica.ListarEmpleados();
            buttonEditar.IsEnabled = true;
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            buttonAgregar.Visibility = Visibility.Visible;
            buttonGrabar.Visibility = Visibility.Hidden;
            buttonEditar.IsEnabled = false;
            buttonCancelar.IsEnabled = false;
            buttonListar.IsEnabled = true;
        }
    }
}
