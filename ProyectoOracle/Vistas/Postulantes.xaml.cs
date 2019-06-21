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
using System.Windows.Threading;

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
        bool status = false;
        public Postulantes(MainWindow w)
        {
            InitializeComponent();
            win = w;
            Refresh();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += (s, a) =>
            {
                if (status)
                {
                    if (MessageBox.Show("¿Desea Guardar los cambios efectuados?", "Postulante modificado", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {

                        Actualizar();
                        Refresh();
                    }
                    else
                    {
                        Refresh();
                    }
                    status = false;
                }
            };
            timer.Start();
        }
        public void Refresh()
        {
            var lista = con.GetAll<Postulante>();
            tabla.ItemsSource = lista;
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            win.GoTo(new AgregarPostulante(win,this));
            Refresh();
        }

        private void Actualizar()
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
            p = ((Postulante)e.Row.Item);
            status = true;
        }

        private void Tabla_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!status)
            {
                p = ((DataGrid)sender).CurrentCell.Item as Postulante;
            }
        }
    }
}
