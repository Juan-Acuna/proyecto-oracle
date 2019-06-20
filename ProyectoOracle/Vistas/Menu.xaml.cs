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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        MainWindow win;
        public Menu(MainWindow w)
        {
            InitializeComponent();
            win = w;
        }

        private void BtnPostulaciones_Click(object sender, RoutedEventArgs e)
        {
            win.GoTo(new Postulaciones(win));
        }

        private void BtnPostulantes_Click(object sender, RoutedEventArgs e)
        {
            win.GoTo(new Postulantes(win));
        }
    }
}
