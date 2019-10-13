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
using System.Data;
using System.Collections;
namespace UI.Mantenimientos
{
    /// <summary>
    /// Lógica de interacción para UserControlLogin.xaml
    /// </summary>
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void ButtonAcceder_Click(object sender, RoutedEventArgs e)
        {
            ClassEmpleado Logica = new ClassEmpleado();
            string resp = Logica.Verificacion(textBoxLoginUsuario.Text, textBoxLoginPassword.Password.ToString());
            if (resp.ToUpper().Contains("ERROR"))
            {
                MessageBox.Show(resp, "No existe el usuario o la contraseña", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //if(b1==true)
                //{
                    UI.MainWindow inicio = new UI.MainWindow();
                    inicio.Show();
                    //b1 = false;
                    //b2 = false;
                  //  b3 = false;
                //}
                //if (b2 ==true)
                //{
                  //  UI.Window1 inicio2 = new UI.Window1();
                   // inicio2.Show();
                    //Application.Current.Windows[0].Close();
                    //b1 = false;
                    //b2 = false;
                    //b3 = false;
                //}
            }
        }
    }
}
