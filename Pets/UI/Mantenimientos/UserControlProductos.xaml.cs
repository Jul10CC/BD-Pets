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
    /// Lógica de interacción para UserControlProductos.xaml
    /// </summary>
    public partial class UserControlProductos : UserControl
    {
        public UserControlProductos()
        {
            InitializeComponent();
            ClassCategoriaProducto logica = new ClassCategoriaProducto();
            comboBoxCategoria.ItemsSource = logica.ListarCategoria();
            comboBoxCategoria.DisplayMemberPath = "Nombre";
            comboBoxCategoria.SelectedValuePath = "categoriaID";
        }

        private void TextNombre_Copy_TextChanged(object sender, TextChangedEventArgs e)
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
            ClassProductos Logica = new ClassProductos();
            string resp = Logica.Nuevoproducto(TextNombre.Text, Convert.ToInt32(TextUnidades.Text), TextPresentacion.Text, TextDescripcion.Text, Convert.ToInt32(comboBoxCategoria.SelectedValue));
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
                ClassProductos logica = new ClassProductos();
                Productos info = new Productos();
                info.ProductosID = Convert.ToInt32(this.TextId.Text);
                info.Nombre = this.TextNombre.Text;
                info.Unidades = Convert.ToInt32(this.TextUnidades.Text);
                info.Presentacion = this.TextPresentacion.Text;
                info.Descripcion = this.TextDescripcion.Text;
                //info.CategoriaProductosID = Convert.ToInt32(this.comboBoxCategoria.SelectedValue);
                resp = logica.Actualizar(info);
                MessageBox.Show(resp);
            }
            else
            {
                MessageBox.Show("Marque el registro a modificar", "Error al editar", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ButtonListar_Click(object sender, RoutedEventArgs e)
        {
            ClassProductos logica = new ClassProductos();
            dataGrid1.ItemsSource = logica.ListarProductos();
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

        private void ComboBoxCategoriaP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxCategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
