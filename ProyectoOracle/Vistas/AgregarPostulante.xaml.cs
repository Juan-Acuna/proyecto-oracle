using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ProyectoOracle.Modelos;
using ProyectoOracle.Controlador;


namespace ProyectoOracle.Vistas
{
    /// <summary>
    /// Lógica de interacción para AgregarPostulante.xaml
    /// </summary>
    public partial class AgregarPostulante : Page
    {
        MainWindow window;
        public AgregarPostulante(MainWindow w)
        {
            InitializeComponent();
            spContenedor.IsEnabled = false;
            spContenedor.Opacity = 0;
            window = w;
        }

        private void ChkConyuge_Checked(object sender, RoutedEventArgs e)
        {
            ControlPanel(true);
        }

        private void ChkConyuge_Unchecked(object sender, RoutedEventArgs e)
        {
            ControlPanel(false);
        }
        private void ControlPanel(bool b)
        {
            double d = 0;
            if (b)
            {
                d = 1;
            }
            spContenedor.IsEnabled = b;
            spContenedor.Opacity = d;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            window.NavFrame.GoBack();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            //primero se insertan los objetos.
            //luego se retorna a la pagina anterior
            window.NavFrame.GoBack();
        }
    }
}
