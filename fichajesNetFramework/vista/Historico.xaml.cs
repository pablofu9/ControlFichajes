using fichajesNetFramework.CRUD;
using ProgramaFichajes.Vista;
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

namespace fichajesNetFramework.vista
{
    /// <summary>
    /// Lógica de interacción para Historico.xaml
    /// </summary>
    public partial class Historico : Window
    {
        public Historico()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fichar m1 = new Fichar();
            m1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ajustes j1 = new Ajustes();
            j1.Show();
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
            this.Close();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            /**
             * Aqui tenemos el menu lateral, se quita y se pone segun le damos a la hamburguesa
             * si esta oculto, el grid donde estan las tablas se desplaza al centro de la pantalla
             */
            if (menuVertical.IsVisible)
            {
                menuVertical.Visibility = Visibility.Collapsed;
                TranslateTransform myTransform = new TranslateTransform();
                myTransform.X -= 100;
                gridTablas.RenderTransform = myTransform;



            }
            else
            {
                TranslateTransform myTransform = new TranslateTransform();
                myTransform.X += 20;
                menuVertical.Visibility = Visibility.Visible;
                gridTablas.RenderTransform = myTransform;


            }
        }

        /**
         * Metodo de la tabla donde cargamos la lista de la clase CRUD, siempre usando linq
         */
        private void tabla_Loaded(object sender, RoutedEventArgs e)
        {
            
            tabla.DataContext = CRUD_User.listarUsers();
        }

        //Metodo para cargar la tabla de fichajes
        private void tablaFichajes_Loaded(object sender, RoutedEventArgs e)
        {
            tablaFichajes.DataContext = CRUD_User.listarFichajes();
        }
    }
}
