using ProyectoOracle.Controlador;
using ProyectoOracle.Modelos;
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
        Postulante p;
        MainWindow win;
        ConexionOracle con = ConexionOracle.Conexion;
        List<Postulante> lista;
        public Postulantes(MainWindow w)
        {
            InitializeComponent();
            win = w;
            Refresh();
        }

        private void Refresh()
        {
            lista = con.GetAll<Postulante>();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            win.GoTo(new AgregarPostulante(win));
            Refresh();
        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (!con.Update(p))
            {
                //error
            }
            Refresh();
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (!con.Delete(p))
            {
                //error
            }
            Refresh();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            win.Back();
        }

        private void Tabla_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Tabla_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            p = ((Postulante)e.Row.Item);
        }
    }
}
