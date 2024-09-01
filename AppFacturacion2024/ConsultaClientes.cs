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
    public partial class ConsultaClientes : Form
    {
        Clientes obj_clientes = new Clientes();
        //la accion= true es para saber si se va a retornar datos del datagridview en caso que se use para listar en la factura 
        bool accion_ = false;
        public ConsultaClientes(bool acccion=false, bool veropciones = true)
        {
            InitializeComponent();
            this.KeyPreview = true;
            accion_ = acccion;
            dtListaClientes.KeyDown += new KeyEventHandler(dtListaClientes_KeyDown);
            dtListaClientes.CellEnter += new DataGridViewCellEventHandler(dtListaClientes_CellEnter);
            // if (veropciones) panelOpciones.Visible = true;
            panelOpciones.Visible = true;
            cmbBuscar.SelectedIndex = 1;
            txtBuscar.Select();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConsultaClientesLista()
        {
            
           // DataTable dataTable = obj_clientes.Listar_Clientes();
            //LlenarGrid(dataTable);
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            //ConsultaClientesLista();
            txtBuscar.Select();
        }

        private void dtListaClientes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
           
                if (e.Button == MouseButtons.Right && !accion_)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        dtListaClientes.CurrentCell = dtListaClientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //aqui se debe tomar los datos para abrir una nueva ventana si en caso quiere actualizar la linea 
                        menuOpciones.Show(Cursor.Position);
                        DataGridViewRow row = dtListaClientes.Rows[e.RowIndex];
                        obj_clientes.CLIENTE_ID_ = int.Parse(row.Cells[0].Value.ToString());
                        obj_clientes.IDENTIFICACION_ = row.Cells[1].Value.ToString();
                        obj_clientes.NOMBRES_ = row.Cells[2].Value.ToString();
                        obj_clientes.CORREO_ = row.Cells[3].Value.ToString();
                        obj_clientes.TELEFONO_ = row.Cells[4].Value.ToString();
                    }
                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message);
                }
            }
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarClientes ventana_crear_editar_clientes = new CrearEditarClientes(true);
            ventana_crear_editar_clientes.ShowDialog();
            //ConsultaClientesLista();
            Buscador();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarClientes ventana_crear_editar_clientes = new CrearEditarClientes(false, obj_clientes.IDENTIFICACION_, obj_clientes.NOMBRES_, obj_clientes.CORREO_, obj_clientes.TELEFONO_ , obj_clientes.CLIENTE_ID_);
            ventana_crear_editar_clientes.ShowDialog();
            //ConsultaClientesLista();
                Buscador();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obj_clientes.Eliminar_Cliente();
                    //ConsultaClientesLista();
                    Buscador();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }
        public int ClienteID { get; private set; }
        public string ClienteNombre { get; private set; }
        public string ClienteIdentificacion { get; private set; }
        public string ClienteCorreo { get; private set; }
        private void dtListaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accion_)
            {
                if (e.RowIndex >= 0)
                {
                    // Obtén la información del cliente desde la fila seleccionada en el DataGridView usando los índices de las columnas
                    ClienteID = int.Parse(dtListaClientes.Rows[e.RowIndex].Cells[5].Value.ToString()); 
                    ClienteNombre = dtListaClientes.Rows[e.RowIndex].Cells[2].Value.ToString(); 
                    ClienteCorreo = dtListaClientes.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                    this.DialogResult = DialogResult.OK;
                    // Cierra el formulario de clientes
                    this.Close();
                }
            }
            
        }

        private void ConsultaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                txtBuscar.Focus();
                txtBuscar.Select();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                ConsultaClientesLista();
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
            DataTable dataTable = obj_clientes.Buscar_Cliente(txtBuscador.Text);
            LlenarGrid(dataTable);
        }

        private void dtListaClientes_KeyDown(object sender, KeyEventArgs e)
        {
            //para abrir el menu desde el teclado
            if (e.Control && e.KeyCode == Keys.O)
            {
                if (currentRowIndex >= 0 && currentColumnIndex >= 0)
                {
                    dtListaClientes.CurrentCell = dtListaClientes.Rows[currentRowIndex].Cells[currentColumnIndex];
                    // Aquí se deben tomar los datos para abrir una nueva ventana si en caso quiere actualizar la línea 
                    Rectangle cellRectangle = dtListaClientes.GetCellDisplayRectangle(currentColumnIndex, currentRowIndex, false);
                    Point cellLocation = dtListaClientes.PointToScreen(new Point(cellRectangle.X, cellRectangle.Y));
                    // Mostrar el menú contextual en la posición de la celda
                    menuOpciones.Show(cellLocation);
                    DataGridViewRow row = dtListaClientes.Rows[currentRowIndex];
                    obj_clientes.IDENTIFICACION_ = row.Cells[0].Value.ToString();
                    obj_clientes.NOMBRES_ = row.Cells[1].Value.ToString();
                    obj_clientes.CORREO_ = row.Cells[2].Value.ToString();
                    obj_clientes.TELEFONO_ = row.Cells[3].Value.ToString();
                }
                e.Handled = true; // Indica que el evento ha sido manejado
            }

            //para aceptar dando enter
            if (e.KeyCode == Keys.Enter)
            {
                if (accion_)
                {
                    // Verifica si hay una fila seleccionada en el DataGridView
                    if (dtListaClientes.CurrentRow != null)
                    {
                        int rowIndex = dtListaClientes.CurrentRow.Index;

                        // Obtén la información del cliente desde la fila seleccionada en el DataGridView usando los índices de las columnas
                        ClienteID = int.Parse(dtListaClientes.Rows[rowIndex].Cells[5].Value.ToString()); // Índice 0 para la columna ID
                        ClienteNombre = dtListaClientes.Rows[rowIndex].Cells[2].Value.ToString(); // Índice 1 para la columna Nombre
                        ClienteCorreo = dtListaClientes.Rows[rowIndex].Cells[3].Value.ToString(); // Índice 2 para la columna PrecioUnitario

                        this.DialogResult = DialogResult.OK;
                        // Cierra el formulario
                        this.Close();
                    }
                }
            }

           

        }
        private int currentRowIndex;
        private int currentColumnIndex;
        private void dtListaClientes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            currentColumnIndex = e.ColumnIndex;
        }

       
        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            CrearEditarClientes ventana_crear_editar_clientes = new CrearEditarClientes(true);
            ventana_crear_editar_clientes.ShowDialog();
            //ConsultaClientesLista();
                Buscador();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador();
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
            DataTable dataTable = obj_clientes.Buscar_Cliente_columna_especifica(Palabra_Clave, Columna);
            LlenarGrid(dataTable);
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscador();
            }
        }
        private void LlenarGrid(DataTable dataTable)
        {
            if (dataTable != null)
            {
                dtListaClientes.DataSource = dataTable; //para enviarla directamente al data source 
            }
            else
            {
                MessageBox.Show("No se pudo obtener datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
