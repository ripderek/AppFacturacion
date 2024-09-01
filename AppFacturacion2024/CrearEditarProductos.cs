using AppFacturacion2024.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturacion2024
{
    public partial class CrearEditarProductos : Form
    {
        Productos objProducto = new Productos();
        private bool accion_ = false;
        //si la accion es true entonces se va a crear el cliente 
        //si la accion es falsa entonces se va a editar el cliente 
       
        public CrearEditarProductos(bool accion, string CODIGO = "", string PRODUCTO = "", string PRECIO_UNITARIO = "")
        {
            InitializeComponent();
            if (accion)

                lblEtiqueta.Text = "Crear Producto";
            else
            {
                txtAceptar.Text = "Editar";
                txtCodigoProducto.Visible = true;
                lblEtiqueta.Text = "Editar Producto";
                txtCodigoProducto.Text = CODIGO;
                txtProductos.Text = PRODUCTO;
                txtPrecioUnitario.Text = PRECIO_UNITARIO;  
            }
            accion_ = accion;
            txtProductos.KeyDown += new KeyEventHandler(TeclaEnter);
            txtPrecioUnitario.KeyDown += new KeyEventHandler(TeclaEnter);

        }
        private void TeclaEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CrearEditarProducto();

            }
        }
        private void CrearEditarProducto() {
            string precio = txtPrecioUnitario.Text.Trim();
            precio = precio.Replace(',', '.');
            decimal numero;

            if (precio.Length == 0)
            {
                MessageBox.Show("El precio no puede estar vacio");
                return;
            }
            if (!decimal.TryParse(precio, NumberStyles.Any, CultureInfo.InvariantCulture, out numero))
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            objProducto.PRODUCTO_ = txtProductos.Text;
            objProducto.PRECIO_UNITARIO_ = precio;
            objProducto.CODIGO_ = txtCodigoProducto.Text;
            if (accion_)
            {
                bool completado = objProducto.CrearProducto();
                if (completado) this.Close();
            }
            else
            {
                bool completado = objProducto.Editar_Producto();
                if (completado) this.Close();
            }
        }
        private void txtAceptar_Click(object sender, EventArgs e)
        {
            CrearEditarProducto();
        }
    }
}
