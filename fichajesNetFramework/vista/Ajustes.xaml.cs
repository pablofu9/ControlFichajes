using fichajesNetFramework.vista;
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
using System.Windows.Shapes;

namespace ProgramaFichajes.Vista
{
    /// <summary>
    /// Lógica de interacción para Ajustes.xaml
    /// </summary>
    public partial class Ajustes : Window
    {
        public Ajustes()
        {
            InitializeComponent();
        }
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {

            if (menuVertical.IsVisible)
            {
                menuVertical.Visibility = Visibility.Collapsed;
                

            }
            else
            {
                menuVertical.Visibility = Visibility.Visible;

            }


        }
        private void btnMinimizar_Click(Object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }
        private void btnPerfil_Click(object sender, RoutedEventArgs e)
        {
            Perfil p1 = new Perfil();
            p1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fichar p1 = new Fichar();
            p1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ajustes a1 = new Ajustes();
            a1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Historico h1 = new Historico();
            h1.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
