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
    /// Lógica de interacción para UserControlCategoria.xaml
    /// </summary>
    public partial class UserControlCategoria : UserControl
    {
        public UserControlCategoria()
        {
            InitializeComponent();
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
            ClassCategoriaProducto Logica = new ClassCategoriaProducto();
            string resp = Logica.NuevaCategoria(TextNombre.Text);
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
            if (TextCategoriaId.Text != "")
            {
                string resp = "";
                ClassCategoriaProducto logica = new ClassCategoriaProducto();
                CategoriaProductos cp = new CategoriaProductos();
                cp.CategoriaProductosID = Convert.ToInt32(this.TextCategoriaId.Text);
                cp.Nombre = this.TextNombre.Text;
                resp = logica.Actualizar(cp);
                MessageBox.Show(resp);
            }
        }

        private void ButtonListar_Click(object sender, RoutedEventArgs e)
        {
            ClassCategoriaProducto logica = new ClassCategoriaProducto();
            dataGrid1.ItemsSource = logica.ListarCategoria();
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
