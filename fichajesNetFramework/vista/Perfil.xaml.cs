
using fichajesNetFramework.CRUD;
using fichajesNetFramework.modelo;
using fichajesNetFramework.vista;
using System;
using System.Collections.Generic;
using System.Configuration;
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
using MaterialDesignThemes.Wpf;
using fichajesNetFramework.validaciones;

namespace ProgramaFichajes.Vista
{
    /// <summary>
    /// Lógica de interacción para Perfil.xaml
    /// </summary>
    public partial class Perfil : Window
    {
        ModelDatosDataContext datos;
        

        public Perfil()
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["fichajesNetFramework.Properties.Settings.fichajesConnectionString"].ConnectionString;
            datos = new ModelDatosDataContext(connectionString);
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            if (menuVertical.IsVisible)
            {
                menuVertical.Visibility = Visibility.Collapsed;
                TranslateTransform myTransform = new TranslateTransform();
                myTransform.X -= 100;
                gridAnadir.RenderTransform = myTransform;

            }
            else
            {
                TranslateTransform myTransform = new TranslateTransform();
                myTransform.X += 30;
                menuVertical.Visibility = Visibility.Visible;
                gridAnadir.RenderTransform = myTransform;


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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Fichar f1 = new Fichar();
            f1.Show();
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

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            users u1 = new users();
            //Comprobamos si los campos estan vacios antes de insertar
            if(string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellidos.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Rellena todos los campos para insertar");

            }
            else if (!Validar.validateEmail(txtEmail.Text))
            {
                MessageBox.Show("El formato del email no es correcto");
            }
            else if (!Validar.validarTelefono(txtTelefono.Text)){
                MessageBox.Show("Introduce un numero de telefono correcto");
            }
            else
            {
                /**
                * Si los campos no estan vacios hacemos la inserción y borramos despues
                * SIempre comprobamos el formato del email y del telefono
                * El id no se mete porque es autoincrement
                */
                try
                {
                    u1.nombre = txtNombre.Text;
                    u1.apellidos = txtApellidos.Text;
                    u1.email = txtEmail.Text;
                    u1.telefono = txtTelefono.Text;
                    CRUD_User.insertUser(u1);
                    MessageBox.Show("Usuario insertado con exito ->id: " + u1.Id_user + " name : " + u1.nombre);
                }
                catch (Exception)
                {
                    MessageBox.Show("Algo ha salido mal");
                }

                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtEmail.Text = "";
                txtTelefono.Text = "";
            }
            
        }
    }
}
