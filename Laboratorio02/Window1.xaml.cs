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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            operaciones ope = new operaciones();
            ope.Show();

        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            // Abre la ventana o realiza la lógica correspondiente para Salida
        }

        // Implementa controladores de eventos similares para las otras opciones del menú
        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            mantenimiento.Show();
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes escribir el código para la opción "Transportistas" en Mantenimientos
            // Abre una ventana para gestionar transportistas, por ejemplo.
            // Ejemplo: Abre una nueva ventana para agregar o editar transportistas.
            //TransportistasWindow transportistasWindow = new TransportistasWindow();
            //transportistasWindow.ShowDialog();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes escribir el código para la opción "Camiones" en Mantenimientos
            // Abre una ventana para gestionar camiones, por ejemplo.
            // Ejemplo: Abre una nueva ventana para agregar o editar camiones.
            //CamionesWindow camionesWindow = new CamionesWindow();
            //camionesWindow.ShowDialog();
        }

        private void Productos_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes escribir el código para la opción "Productos" en Mantenimientos
            // Abre una ventana para gestionar productos, por ejemplo.
            // Ejemplo: Abre una nueva ventana para agregar o editar productos.
            //ProductosWindow productosWindow = new ProductosWindow();
            //productosWindow.ShowDialog();
        }
        private void Cargas_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes escribir el código para la opción "Cargas" en Reportes
            // Abre una ventana para generar reportes de cargas, por ejemplo.
            // Ejemplo: Abre una nueva ventana de reporte de cargas.
            //CargasReportWindow cargasReportWindow = new CargasReportWindow();
            //cargasReportWindow.ShowDialog();
        }

        private void ReporteIngresos_Click(object sender, RoutedEventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void ReporteSalidas_Click(object sender, RoutedEventArgs e)
        {
            // Aquí puedes escribir el código para la opción "Salidas" en Reportes
            // Abre una ventana para generar reportes de salidas, por ejemplo.
            // Ejemplo: Abre una nueva ventana de reporte de salidas.
            //SalidasReportWindow salidasReportWindow = new SalidasReportWindow();
            //salidasReportWindow.ShowDialog();
        }


    }
}
