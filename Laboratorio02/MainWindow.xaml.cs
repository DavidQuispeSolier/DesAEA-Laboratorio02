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

namespace Laboratorio02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Close();
            window1.Show();
       
            // Obtén el nombre de usuario y la contraseña ingresados por el usuario
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Aquí deberías realizar la lógica de autenticación, por ejemplo, verificar en una base de datos
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Si las credenciales son válidas, redirige al usuario a la siguiente ventana
                MainWindow main = new MainWindow(); // Reemplaza "MainWindow" con el nombre de tu ventana principal
                window1.Show();
                this.Close(); // Cierra la ventana de inicio de sesión
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Aquí debes implementar la lógica de autenticación.
            // Esto puede implicar verificar las credenciales en una base de datos o en otro lugar seguro.
            // Devuelve true si el usuario es autenticado exitosamente; de lo contrario, devuelve false.
            // Este es solo un ejemplo simple, debes implementar tu propia lógica de autenticación.

            // Por ejemplo, aquí asumimos que el usuario y la contraseña son "admin".
            return (username == "admin" && password == "admin");
        }
    }
}


