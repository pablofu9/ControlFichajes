
using fichajesNetFramework.CRUD;
using fichajesNetFramework.modelo;
using fichajesNetFramework.vista;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
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
    /// Lógica de interacción para Fichar.xaml
    /// </summary>
    public partial class Fichar : Window
    {
        ModelDatosDataContext datos;
        public Fichar()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["fichajesNetFramework.Properties.Settings.fichajesConnectionString"].ConnectionString;
            datos = new ModelDatosDataContext(connectionString);
            InitializeComponent();
        }
        private void btnMinimizar_Click(Object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnCerrar_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Mostramos los paneles y la flecha, segun pulsamos o no el menu de hamburguesa
        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {

            if (menuVertical.IsVisible)
            {
                menuVertical.Visibility = Visibility.Collapsed;
                panelFichar.Visibility = Visibility.Visible;
                flecha.Visibility = Visibility.Visible;

            }
            else
            {
                menuVertical.Visibility = Visibility.Visible;
                panelFichar.Visibility = Visibility.Hidden;
                flecha.Visibility = Visibility.Hidden;

            }


        }

        private void btnFichar_Click(object sender, RoutedEventArgs e)
        {
            
           
            DateTime today = DateTime.Now;
           
            var fechaHoy = today.ToShortDateString();
            DateTime fecha = DateTime.Parse(fechaHoy);

            var horaEntrada=today.ToLongTimeString();
            TimeSpan hora = TimeSpan.Parse(horaEntrada);

            //Si encuentra el id en la tabla users, va a generar un nuevo fichaje con ese id
            /**
             * Ya hemos parseado el time y el date para poder introducirlo
             * El formato sera de la siguiente manera
             * Cuando introducimos un nuevo fichaje, la hora de salida sera 00:00:00
             * Pero cuando encontramos el id del usuario en la tabla y la fecha coincide
             * Lo que haremos sera hacer un update de esa row de la hora de salida
             */
            
                //Introducimos un nuevo fichaje
                fichajes f = new fichajes();
                f.fecha = fecha;
                f.hora_entrada = hora;
                f.Id_usuario = Int32.Parse(txtID.Text);

            CRUD_User.buscarFichaje(f, Int32.Parse(txtID.Text));
              
            
            

            //NOS FALTA PARSEAR LA FECHA PARA QUE NO SALGA LA HORA TAMBIEN
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ajustes m1 = new Ajustes();
            m1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Historico h1 = new Historico();
            h1.Show();
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
    }
}
