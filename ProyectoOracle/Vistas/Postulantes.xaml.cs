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

namespace ProyectoOracle.Vistas
{
    /// <summary>
    /// Lógica de interacción para Postulantes.xaml
    /// </summary>
    public partial class Postulantes : Page
    {
        MainWindow win;
        public Postulantes(MainWindow w)
        {
            InitializeComponent();
            win = w;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            win.Back();
        }

        private void Tabla_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
