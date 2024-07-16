using AppFacturacion2024.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturacion2024
{
    public partial class frmInicioSesion : Form
    {
         
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            InicioSesion();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioSesion()
        {
            try
            {
                DataTable InfoUsuario = Usuario.Verificar_Inicio_Sesion(txtUsuario.Text, txtContrasena.Text);
                if (InfoUsuario != null && InfoUsuario.Rows.Count > 0 && InfoUsuario.Columns.Count > 0)
                {
                    //Si esque el DataTable contiene filas y columnas entonces mostrar el formulario del menu
                    Form1 form1 = new Form1();
                    this.Close();
                    form1.Show();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InicioSesion();

            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InicioSesion();
            }
        }
    }
}
