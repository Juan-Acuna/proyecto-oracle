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
    /// Lógica de interacción para Postulaciones.xaml
    /// </summary>
    public partial class Postulaciones : Page
    {
        Solicitud p;
        MainWindow win;
        ConexionOracle con = ConexionOracle.Conexion;
        List<Solicitud> lista;
        public Postulaciones(MainWindow w)
        {
            InitializeComponent();
            win = w;
            Refresh();
        }

        private void Refresh()
        {
            lista = con.GetAll<Solicitud>();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            //win.GoTo(new AgregarPostulacion(win));
            Refresh();
        }

        private void BtnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (!con.Update(p))
            {
                //error
                return;
            }
            Refresh();
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (!con.Delete(p))
            {
                //error
                return;
            }
            Refresh();
        }

        private void BtnVolver_Click(object sender, RoutedEventArgs e)
        {
            win.Back();
        }

        private void Tabla_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            p = ((Solicitud)e.Row.Item);
        }
    }
}
