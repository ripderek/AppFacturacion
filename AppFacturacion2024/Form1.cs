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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtUsuario.Text = Usuario.usuario;
            txtNombreUsuario.Text =Usuario.nombres;
            txtUsuarioTipo.Text = Usuario.tipo;
            //aqui colocar un switch para controlar los tipos de usuario para mostar las opciones del menu
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    
        ///para los menus 
        private Form formularioActivo = null;
        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            panelOPCIONES.Controls.Add(nuevoFormulario);
            panelOPCIONES.Tag = nuevoFormulario;
            nuevoFormulario.BringToFront();
            nuevoFormulario.Show();

        }
        private void ocualtarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
            {
                subMenu.Visible = false;
            }
           
        }
        private void verSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //ocualtarSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else { subMenu.Visible = false; }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            verSubmenu(MenuClientes);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            verSubmenu(MenuProductos);

        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            verSubmenu(MenuFacturas);

        }

        private void btnConsultaClientes_Click(object sender, EventArgs e)
        {
            //ConsultaClientes ConsultaCliente = new ConsultaClientes();
            AbrirFormulario(new ConsultaClientes());
        }

        private void btnImprimirListaClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaClientes());
        }

        private void btnConsultaProductos_Click(object sender, EventArgs e)
        {
            //ConsultaProductos
            AbrirFormulario(new ConsultaProductos());

        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistrarFactura());

        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultaFacturas());

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
