using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturacion2024.Clases
{
    internal class Productos : ConexionBD

    {
        private string CODIGO;
        private string PRODUCTO;
        private string PRECIO_UNITARIO;
        private string ESTADO;
        private int PROVEEDOR_ID;
        private string PROVEEDOR_NAME;

        public string CODIGO_ {  get => CODIGO; set => CODIGO = value ; }
        public string PRODUCTO_ { get => PRODUCTO; set => PRODUCTO = value; }
        public string PRECIO_UNITARIO_ {  get => PRECIO_UNITARIO; set =>  PRECIO_UNITARIO = value;}
        public string ESTADO_ {  get => ESTADO; set => ESTADO = value; }

        public int PROVEEDOR_ID_ { get => PROVEEDOR_ID; set => PROVEEDOR_ID = value; }

        public string PROVEEDOR_NAME_ { get => PROVEEDOR_NAME; set => PROVEEDOR_NAME = value; }

        //FUNCION PARA LISTAR LOS CLIENTES


        //funcion para crear productos
        public bool CrearProducto()
        {
            string sql = "SP_InsertarProducto";

            // Crear los parámetros
            var parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                  new System.Data.SqlClient.SqlParameter("@Producto", PRODUCTO_),
                  new System.Data.SqlClient.SqlParameter("@Precio_unitario", PRECIO_UNITARIO_),
                  new System.Data.SqlClient.SqlParameter("@Proveedor_ID", PROVEEDOR_ID_)
             };

            ConcatenacionCadena(sql, parametros);
            if (TransaccionCompleta)
            {
                MessageBox.Show("Producto creado");
            }
            return TransaccionCompleta;
        }
        //funcion para editar PRODUCTO
        public bool Editar_Producto()
        {
            //string SQL = "EXEC SP_EditarProducto '" + CODIGO_ + "', '" + PRODUCTO_ + "', '" + PRECIO_UNITARIO_ + "'";
            //ConcatenacionCadena(SQL);
            string sql = "SP_EditarProducto";

            // Crear los parámetros
            var parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                  new System.Data.SqlClient.SqlParameter("@Codigo", CODIGO_),
                  new System.Data.SqlClient.SqlParameter("@Producto", PRODUCTO_),
                  new System.Data.SqlClient.SqlParameter("@Precio_Unitario", PRECIO_UNITARIO_),
                  new System.Data.SqlClient.SqlParameter("@Proveedor_ID", PROVEEDOR_ID_)
             };

            ConcatenacionCadena(sql, parametros);
            if (TransaccionCompleta)
            {
                MessageBox.Show("Producto Editado");
            }
            return TransaccionCompleta;
        }
        //funcion para eliminar el PRODUCTO 
        public void Eliminar_Producto()
        {
            //string SQL = "EXEC SP_EliminarProducto '" + CODIGO_ + "'";
            //ConcatenacionCadena(SQL);
            string sql = "SP_EliminarProducto";

            // Crear los parámetros
            var parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                  new System.Data.SqlClient.SqlParameter("@Codigo", CODIGO_)
             };

            ConcatenacionCadena(sql, parametros);
            if (TransaccionCompleta)
            {
                MessageBox.Show("Producto Eliminado");
            }
        }
        public DataTable Listar_Productos()
        {
            return Cargar_Data_Table("SP_ListarProductos;");
        }
        //funcion para buscar el producto por palabra clave
        public DataTable Buscar_Producto(string Palabra_Clave)
        {
            //return Cargar_Data_Table("[SP_Buscar_Producto]'" + Palabra_Clave + "'");
            string sql = "SP_Buscar_Producto";

            var parametros = new List<System.Data.SqlClient.SqlParameter>
             {
                      new System.Data.SqlClient.SqlParameter("@Palabra_Clave", Palabra_Clave)
             };
            return Cargar_Data_Table(sql, parametros);
        }
        public DataTable Buscar_Producto_columna_especifica(string Palabra_Clave, string Columna)
        {
            //return Cargar_Data_Table("[SP_Buscar_Producto]'" + Palabra_Clave + "'");
            string sql = "SP_BUSQUEDA_ESPECIFICA_PRODUCTOS";

            var parametros = new List<System.Data.SqlClient.SqlParameter>
             {
                      new System.Data.SqlClient.SqlParameter("@Palabra_Clave", Palabra_Clave),
                      new System.Data.SqlClient.SqlParameter("@Columna", Columna)
             };
            return Cargar_Data_Table(sql, parametros);
        }

    }
}
