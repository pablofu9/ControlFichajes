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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
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
        private void btnFichar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnAjustes_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnListado_Click(object sender, RoutedEventArgs e)
        {
        }

        //Boton de arriba del menu, muestra o esconde el menu vertical, segun como este
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {

            if (menuVertical.IsVisible)
            {
                menuVertical.Visibility = Visibility.Collapsed;
                TranslateTransform myTransform = new TranslateTransform();
                myTransform.X -= 100;
                pantallaDesplazar.RenderTransform = myTransform;


            }else
                {
                    menuVertical.Visibility = Visibility.Visible;
                TranslateTransform myTransform = new TranslateTransform();
                myTransform.X += 30;
                pantallaDesplazar.RenderTransform = myTransform;

            }

            
            
        }

        //BOTONES DE LA BARRA LATERAL PARA CAMBIAR DE VISTA
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fichar m1 = new Fichar();
            m1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ajustes m1 = new Ajustes();
            m1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Perfil p1 = new Perfil();
            p1.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Historico h1 = new Historico();
            h1.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
