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
    public partial class ConsultaProductos : Form
    {
        Productos obj_productos = new Productos();
        bool accion_ = false;
        public ConsultaProductos(bool accion=false,bool veropciones = true)
        {
            InitializeComponent();
            this.KeyPreview = true;
            accion_ = accion;
            // if (veropciones) panelOpciones.Visible = true;
            panelOpciones.Visible = true;
            cmbBuscar.SelectedIndex = 1;
            txtBuscar.Focus();
            txtBuscar.Select();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultaProductosLista()
        {
            //DataTable dataTable = obj_productos.Listar_Productos();
            //LlenarGrid(dataTable);
            
        }
        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            txtBuscar.Select();
            //ConsultaProductosLista();
        }

        private void dtListaProdutos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && !accion_)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        dtListaProdutos.CurrentCell = dtListaProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //aqui se debe tomar los datos para abrir una nueva ventana si en caso quiere actualizar la linea 
                        menuOpciones.Show(Cursor.Position);
                        DataGridViewRow row = dtListaProdutos.Rows[e.RowIndex];
                        obj_productos.CODIGO_ = row.Cells[0].Value.ToString();
                        obj_productos.PRODUCTO_ = row.Cells[1].Value.ToString();
                        obj_productos.PRECIO_UNITARIO_ = row.Cells[2].Value.ToString();
                    }
                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message);
                }
            }
        }

        private void crearProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarProductos ventana_crear_editar_productos = new CrearEditarProductos(true);
            ventana_crear_editar_productos.ShowDialog();
            ConsultaProductosLista();
        }

        private void menuOpciones_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarProductos ventana_crear_editar_productos = new CrearEditarProductos(false, obj_productos.CODIGO_, obj_productos.PRODUCTO_, obj_productos.PRECIO_UNITARIO_);
            ventana_crear_editar_productos.ShowDialog();
            //ConsultaProductosLista();
                Buscador();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obj_productos.Eliminar_Producto();
                    //ConsultaProductosLista();
                    Buscador();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
      
        }
        public string CodigoProducto { get; private set; }
        public string ProductoNombre { get; private set; }
        public string PrecioUnitario { get; private set; }
        private void dtListaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accion_)
            {
                if (e.RowIndex >= 0)
                {
                    // Obtén la información del cliente desde la fila seleccionada en el DataGridView usando los índices de las columnas
                    CodigoProducto = dtListaProdutos.Rows[e.RowIndex].Cells[0].Value.ToString(); // Índice 0 para la columna ID
                    ProductoNombre = dtListaProdutos.Rows[e.RowIndex].Cells[1].Value.ToString(); // Índice 1 para la columna Nombre
                    PrecioUnitario = dtListaProdutos.Rows[e.RowIndex].Cells[2].Value.ToString(); // Índice 1 para la columna Nombre

                    this.DialogResult = DialogResult.OK;
                    // Cierra el formulario de clientes
                    this.Close();
                }
            }
        }

        private void ConsultaProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                // txtBuscador.Visible = true;
                // txtBuscador.BringToFront();
                // txtBuscador.Focus();
                txtBuscar.Select();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                ConsultaProductosLista();
            }
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            //detectar si se da enter para aceptar la busqueda del texto que contiene
            if (e.KeyCode == Keys.Enter)
            {
                //funcion para buscar
                Busqueda_Palabra_Clave();
                txtBuscador.Visible = false;
                txtBuscador.Text = "";

            }
        }
        private void Busqueda_Palabra_Clave()
        {
            DataTable dataTable = obj_productos.Buscar_Producto(txtBuscador.Text);
            LlenarGrid(dataTable);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            CrearEditarProductos ventana_crear_editar_productos = new CrearEditarProductos(true);
            ventana_crear_editar_productos.ShowDialog();
            //ConsultaProductosLista();
                Buscador();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscador();
            }
            if (e.KeyCode == Keys.Tab)
            {
                dtListaProdutos.Select();
                dtListaProdutos.Focus();
            }
        }
        private void Buscador()
        {
            //controlar que el select del combobox no este vacio o nullo skere modo diablo
            if (cmbBuscar.SelectedItem != null)
            {
                //MessageBox.Show(cmbBuscar.SelectedItem.ToString());
                //accionar el buscador
                BusquedaEspeficia(txtBuscar.Text, cmbBuscar.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Seleccione un filtro de busqueda");
            }
        }
        private void BusquedaEspeficia(string Palabra_Clave, string Columna)
        {
            DataTable dataTable = obj_productos.Buscar_Producto_columna_especifica(Palabra_Clave, Columna);
            LlenarGrid(dataTable);
        }
        private void LlenarGrid(DataTable dataTable)
        {
            if (dataTable != null)
            {
                dtListaProdutos.DataSource = dataTable; //para enviarla directamente al data source 
            }
            else
            {
                MessageBox.Show("No se pudo obtener datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtListaProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txtBuscar.Select();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (accion_)
                {
                    // Verifica si hay una fila seleccionada en el DataGridView
                    if (dtListaProdutos.CurrentRow != null)
                    {
                        int rowIndex = dtListaProdutos.CurrentRow.Index;

                        // Obtén la información del cliente desde la fila seleccionada en el DataGridView usando los índices de las columnas
                        CodigoProducto = dtListaProdutos.Rows[rowIndex].Cells[0].Value.ToString(); // Índice 0 para la columna ID
                        ProductoNombre = dtListaProdutos.Rows[rowIndex].Cells[1].Value.ToString(); // Índice 1 para la columna Nombre
                        PrecioUnitario = dtListaProdutos.Rows[rowIndex].Cells[2].Value.ToString(); // Índice 2 para la columna PrecioUnitario

                        this.DialogResult = DialogResult.OK;
                        // Cierra el formulario
                        this.Close();
                    }
                }
            }
        }
    }
}
