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
    public partial class ConsultaProveedores : Form
    {
        Proveedores obj_Proveedores = new Proveedores();
        bool accion_ = false;

        public ConsultaProveedores(bool acccion = false)
        {
            InitializeComponent();
            cmbBuscar.SelectedIndex = 1;
            txtBuscar.Select();
            this.KeyPreview = true;
            accion_ = acccion;
            //dtListaClientes.KeyDown += new KeyEventHandler(dtListaClientes_KeyDown);
            //dtListaClientes.CellEnter += new DataGridViewCellEventHandler(dtListaClientes_CellEnter);
            txtBuscar.Focus();
            txtBuscar.Select();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            CrearEditarProveedores ventana_crear_editar_proveedores = new CrearEditarProveedores(true);
            ventana_crear_editar_proveedores.ShowDialog();
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
            DataTable dataTable = obj_Proveedores.Buscar_Proveedor_columna_especifica(Palabra_Clave, Columna);
            LlenarGrid(dataTable);
        }
        private void LlenarGrid(DataTable dataTable)
        {
            if (dataTable != null)
            {
                dtListaProveedores.DataSource = dataTable; //para enviarla directamente al data source 
            }
            else
            {
                MessageBox.Show("No se pudo obtener datos de la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscador();
            }
        }

        private void dtListaProveedores_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                try
                {
                    if (e.RowIndex >= 0)
                    {
                        dtListaProveedores.CurrentCell = dtListaProveedores.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        //aqui se debe tomar los datos para abrir una nueva ventana si en caso quiere actualizar la linea 
                        menuOpciones.Show(Cursor.Position);
                        DataGridViewRow row = dtListaProveedores.Rows[e.RowIndex];
                        obj_Proveedores.PROVEEDOR_ID_ = int.Parse(row.Cells[0].Value.ToString());
                        obj_Proveedores.IDENTIFICACION_ = row.Cells[1].Value.ToString().Trim();
                        obj_Proveedores.NOMBRES_ = row.Cells[2].Value.ToString().Trim();
                        obj_Proveedores.CORREO_ = row.Cells[3].Value.ToString().Trim();
                        obj_Proveedores.TELEFONO_ = row.Cells[4].Value.ToString().Trim();
                    }
                }
                catch (Exception en)
                {
                    MessageBox.Show(en.Message);
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    obj_Proveedores.Eliminar_Proveedor();
                    //ConsultaClientesLista();
                    Buscador();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEditarProveedores ventana_crear_editar_proveedores = new CrearEditarProveedores(false,obj_Proveedores.IDENTIFICACION_, obj_Proveedores.NOMBRES_, obj_Proveedores.CORREO_, obj_Proveedores.TELEFONO_, obj_Proveedores.PROVEEDOR_ID_);
            ventana_crear_editar_proveedores.ShowDialog();
            //ConsultaClientesLista();
            Buscador();
        }

        public int ProveedorID { get; private set; }
        public string NombreProveedor { get; private set; }
        private void dtListaProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (accion_)
            {
                if (e.RowIndex >= 0)
                {
                    // Obtén la información del cliente desde la fila seleccionada en el DataGridView usando los índices de las columnas
                    ProveedorID = int.Parse(dtListaProveedores.Rows[e.RowIndex].Cells[0].Value.ToString());
                    NombreProveedor = dtListaProveedores.Rows[e.RowIndex].Cells[2].Value.ToString();

                    this.DialogResult = DialogResult.OK;
                    // Cierra el formulario de clientes
                    this.Close();
                }
            }
        }

        private void ConsultaProveedores_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            txtBuscar.Select();
        }
    }
}
