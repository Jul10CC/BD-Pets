﻿using System;
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
namespace UI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BotonSalir_Click(object sender, RoutedEventArgs e) { Application.Current.Shutdown(); }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex; MoverPestaña(index);
            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear(); MessageBox.Show("INICIO"); break;
                case 1: GridPrincipal.Children.Clear(); GridPrincipal.Children.Add(new Mantenimientos.UserControl1()); break;
                case 2: MessageBox.Show("OPCIÓN 2"); break;
                default: break;
            }
        }
        private void MoverPestaña(int opcion_seleccionada)
        {
            TrainsitionigContentSlide.OnApplyTemplate(); GridCursor.Margin = new Thickness(0, (150 + (60 * opcion_seleccionada)),
0, 0);
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e) { ButtonCloseMenu.Visibility = Visibility.Visible; ButtonOpenMenu.Visibility = Visibility.Collapsed; }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e) { ButtonCloseMenu.Visibility = Visibility.Collapsed; ButtonOpenMenu.Visibility = Visibility.Visible; }

    }
}