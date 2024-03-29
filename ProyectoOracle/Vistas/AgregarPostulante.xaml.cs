﻿using System;
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
        Page pagina;
        ConexionOracle con = ConexionOracle.Conexion;
        public AgregarPostulante(MainWindow w,Page pagina)
        {
            InitializeComponent();
            spContenedor.IsEnabled = false;
            spContenedor.Opacity = 0;
            window = w;
            this.pagina = pagina;
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
            window.Back();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            bool b = true;
            //primero se insertan los objetos.
            if (Convert.ToBoolean(chkConyuge.IsChecked))
            {
                Conyuge c = new Conyuge
                {
                    Rut_conyuge = txtRutC.Text,
                    Nombre_completo = txtNombreC.Text
                };
                b = con.Insert(c, false);
            }
            if (!b)
            { 
                //error
                return;
            }
            Postulante p = new Postulante
            {
                Rut = txtRut.Text,
                Nombre_completo = txtNombre.Text + " " + txtApellido.Text,
                Nacimiento = dtNacimiento.DisplayDate,
                Nacionalidad = ((ComboBoxItem)cbNacionalidad.SelectedValue).Content.ToString(),
                Titulo = txtTitulo.Text.Trim().Equals("") ? "Sin titulo profesional" : txtTitulo.Text,
                Cargas_familiares = Int32.Parse(txtCargas.Text),
                P_indigena = Convert.ToBoolean(chkIndigena.IsChecked),
                Fono_c = Int32.Parse(txtFonoC.Text),
                Fono_t = Int32.Parse(txtFonoT.Text),
                Fono_m = Int32.Parse(txtFonoM.Text),
                Email = txtEmail.Text,
                Direccion = txtDireccion.Text,
                Codigo_postal = Int32.Parse(txtPostal.Text),
                Rut_conyuge = Convert.ToBoolean(chkConyuge.IsChecked)?txtRutC.Text:null
            };
            b = con.Insert(p, false);
            if (!b)
            {
                //error
                return;
            }
            //luego se retorna a la pagina anterior
            ((Postulantes)pagina).Refresh();
            window.Back();
        }
    }
}
