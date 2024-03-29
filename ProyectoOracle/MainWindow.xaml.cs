﻿using System;
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

namespace ProyectoOracle
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.NoResize;
            NavFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            NavFrame.Navigate(new ProyectoOracle.Vistas.Menu(this));
        }
        public void GoTo(Page pagina)
        {
            NavFrame.Navigate(pagina);
        }
        public void Back()
        {
            NavFrame.GoBack();
        }
    }
}
