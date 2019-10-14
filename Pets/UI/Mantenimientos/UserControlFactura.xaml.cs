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
using System.Xml.Linq;

namespace UI.Mantenimientos
{
    /// <summary>
    /// Lógica de interacción para UserControlFactura.xaml
    /// </summary>
    public partial class UserControlFactura : UserControl
    {
        //Detalle
        XElement deta1 = new XElement("Cantidad", "--");
        XElement deta2 = new XElement("Precio", "--");
        XElement deta3 = new XElement("ProductosID", "--");
        //Factura
        XElement fac1;
        XElement fac2;
        XElement fac3;
        XElement fac4;
        XElement fac5;
        //Pago
        XElement pago1;
        XElement pago2;
        XElement contactoxml;
        //Variables
        bool b1 = false;
        int total = 0;
        int mul1 = 0;
        int mul2 = 0;
        int pag0 = 0;
        int resta = 0;
        string mensaje1 = "Se ha completado el pago";
        string mensaje2 = "No se ha completado el pago, faltan: Q";
        public UserControlFactura()
        {
            InitializeComponent();
            //Cliente
            ClassCliente Logica = new ClassCliente();
            comboBoxCliente.ItemsSource = Logica.ListarClientes();
            comboBoxCliente.DisplayMemberPath = "Nombre";
            comboBoxCliente.SelectedValuePath = "ClienteID";
            //Empleado
            ClassEmpleado Logica2 = new ClassEmpleado();
            comboBoxEmpleado.ItemsSource = Logica2.ListarEmpleados();
            comboBoxEmpleado.DisplayMemberPath = "Nombre";
            comboBoxEmpleado.SelectedValuePath = "EmpleadoID";
            //Producto
            ClassProductos Logica3 = new ClassProductos();
            comboBoxProducto.ItemsSource = Logica3.ListarProductos();
            comboBoxProducto.DisplayMemberPath = "Nombre";
            comboBoxProducto.SelectedValuePath = "ProductosID";
        }

        private void ComboBoxEmpleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonAgregarFactura_Click(object sender, RoutedEventArgs e)
        {
            fac1 = new XElement("ClienteID", Convert.ToInt32(comboBoxCliente.SelectedValue));
            fac2 = new XElement("EmpleadoID", Convert.ToInt32(comboBoxEmpleado.SelectedValue));
            fac3 = new XElement("Fecha", Convert.ToDateTime(dateFecha.Text));
            fac4 = new XElement("Estado", Convert.ToByte(TextEstado.Text));
            fac5 = new XElement("Total", Convert.ToDecimal(TextTotal.Text));
            if (b1 == false)
            {
                contactoxml = new XElement("Informacion", new XElement("Factura", fac1, fac2, fac3, fac4, fac5));
                b1 = true;
            }
            else
            {
                contactoxml.Add(new XElement("Factura", fac1, fac2, fac3, fac4, fac5));
            }
            this.Texto.Text = contactoxml.ToString();
        }

        private void ButtonConfirmar_Click(object sender, RoutedEventArgs e)
        {
            if (pag0 == total)
            {
                ClassConsultas Logica = new ClassConsultas();
                this.dataGrid1.ItemsSource = Logica.SP_XML(contactoxml.ToString());
            }
            else
            {
                MessageBox.Show("No se ha completado el pago");
            }         
        }

        private void ButtonAgregar_Click(object sender, RoutedEventArgs e)
        {
            deta1 = new XElement("Cantidad", Convert.ToInt32(TextCantidad.Text));
            deta2 = new XElement("Precio", Convert.ToInt32(TextPrecio.Text));
            deta3 = new XElement("ProductosID", Convert.ToInt32(comboBoxProducto.SelectedValue));
            if (b1 == false)
            {
                contactoxml = new XElement("Informacion", new XElement("Detalle", deta1, deta2, deta3));
                b1 = true;
            }
            else
            {
                contactoxml.Add(new XElement("Detalle", deta1, deta2, deta3));
            }
            
            this.Texto.Text = contactoxml.ToString();
            mul1 = Convert.ToInt32(TextCantidad.Text);
            mul2 = Convert.ToInt32(TextPrecio.Text);
            total += Convert.ToInt32(mul1*mul2);
           this.TextTotal.Text=total.ToString();
        }

        private void ComboBoxCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonAgregarPago_Click(object sender, RoutedEventArgs e)
        {
            pago1 = new XElement("ModoPago", TextModoPago.Text);
            pago2 = new XElement("Pago", Convert.ToInt32(TextPago.Text));
            if (b1 == false)
            {
                contactoxml = new XElement("Informacion", new XElement("Pagos", pago1, pago2));
                b1 = true;
            }
            else
            {
                contactoxml.Add(new XElement("Pagos", pago1, pago2));
            }
            this.Texto.Text = contactoxml.ToString();
            pag0 += Convert.ToInt32(TextPago.Text);
            resta = total - pag0;
            if (pag0==total)
            {
              this.TextMensaje.Text = mensaje1;
            }
            else if(pag0<total)
            {
                this.TextMensaje.Text = mensaje2 + resta ;
            }
        }
    }
}
