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

namespace Laboratorio02
{
    /// <summary>
    /// Lógica de interacción para Mantenimiento.xaml
    /// </summary>
    public partial class Mantenimiento : Window
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }



        private void GuardarConductor_Click(object sender, RoutedEventArgs e)
        {
            Registrocon registro = new Registrocon();
            this.Close();
            registro.Show();
        }
        private void IrAListaConductores_Click(object sender, RoutedEventArgs e)
        {
            Listacon listacon = new Listacon();
            this.Close();
            listacon.Show();
        }
    }
}
