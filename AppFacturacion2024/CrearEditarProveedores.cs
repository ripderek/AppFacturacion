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
    public partial class CrearEditarProveedores : Form
    {
        Proveedores objProveedores = new Proveedores();

        private bool accion_ = false;
        private int id_proveedor_ = 0;
        //si la accion es true entonces se va a crear  
        //si la accion es falsa entonces se va a editar
        public CrearEditarProveedores(bool accion, string IDENTIFICACION = "", string NOMBRES = "", string CORREO = "", string TELEFONO = "", int id_proveedor = 0)
        {
            InitializeComponent();
             this.KeyPreview = true;

            if (accion)

                lblEtiqueta.Text = "Crear Proveedor";
            else
            {
                id_proveedor_ = id_proveedor;
                txtAceptar.Text = "Editar";
                txtCodigoCliente.Visible = true;
                lblEtiqueta.Text = "Editar Proveedor";
                //txtIdentificacion.Visible = false;
                // lblIdentificacion.Visible = false;
                txtCodigoCliente.Text = id_proveedor.ToString();
                txtIdentificacion.Text = IDENTIFICACION;
                txtNombres.Text = NOMBRES;
                txtCorreo.Text = CORREO;
                txtTelefono.Text = TELEFONO;
            }

            accion_ = accion;
            //darle los eventos a los txt 
            
            txtIdentificacion.KeyDown += new KeyEventHandler(TeclaEnter);
            txtNombres.KeyDown += new KeyEventHandler(TeclaEnter);
            txtCorreo.KeyDown += new KeyEventHandler(TeclaEnter);
            txtTelefono.KeyDown += new KeyEventHandler(TeclaEnter);
            
        }
        private void TeclaEnter(object sender, KeyEventArgs e)
        {
            //txtAceptar_Click
            if (e.KeyCode == Keys.Enter)
            {
                CrearEditarProveedor();
            }
        }
        private void CrearEditarProveedor()
        {
            objProveedores.IDENTIFICACION_ = txtIdentificacion.Text;
            objProveedores.NOMBRES_ = txtNombres.Text;
            objProveedores.CORREO_ = txtCorreo.Text;
            objProveedores.TELEFONO_ = txtTelefono.Text;
            objProveedores.PROVEEDOR_ID_ = id_proveedor_;
            if (accion_)
            {
                bool identificador = objProveedores.CrearProveedor();
                if (identificador) this.Close();
            }
            else
            {
                bool identificador = objProveedores.Editar_Proveedor();
                if (identificador) this.Close();
            }
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            CrearEditarProveedor();
        }
    }
}
