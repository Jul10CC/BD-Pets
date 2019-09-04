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
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;


namespace UI.Mantenimientos
{
    /// <summary>
    /// Lógica de interacción para UserControlUsuario.xaml
    /// </summary>
    public partial class UserControlUsuario : UserControl
    {
        public UserControlUsuario()
        {
            InitializeComponent();
            ClassEmpleado logica = new ClassEmpleado();
            comboBoxEmpleado.ItemsSource = logica.ListarEmpleados();
            comboBoxEmpleado.DisplayMemberPath = "Nombre";
            comboBoxEmpleado.SelectedValuePath = "EmpleadoID";
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
            ClassUsuario Logica = new ClassUsuario();
            ClassEmpleadoCargo Logica2 = new ClassEmpleadoCargo();
            string resp = Logica.NuevoUsuario(TextUsuario.Text, textBoxPassword.Password, Convert.ToInt32(comboBoxEmpleado.SelectedValue));
        
            if (resp.ToUpper().Contains("ERROR"))
                MessageBox.Show(resp, "Error al grabar ", MessageBoxButton.OK, MessageBoxImage.Error);
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
            if (TextId.Text != "")
            {
                string resp = "";
                ClassUsuario logica = new ClassUsuario();
                Usuario us = new Usuario();
                us.UsuarioID = Convert.ToInt32(this.TextId.Text);
                us.Username = this.TextUsuario.Text;
                us.Password = this.textBoxPassword.Password;
                us.EmpleadoID = Convert.ToInt32(this.comboBoxEmpleado.SelectedValue);
                resp = logica.Actualizar(us);
                MessageBox.Show(resp);
            }
            else
            {
                MessageBox.Show("Marque el registro a modificar", "Error al editar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonListar_Click(object sender, RoutedEventArgs e)
        {
            ClassUsuario logica = new ClassUsuario();
            dataGrid1.ItemsSource = logica.ListarUsuario();
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
