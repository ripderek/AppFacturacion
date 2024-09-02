using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFacturacion2024.Clases
{
    internal class Proveedores: ConexionBD
    {
        private string IDENTIFICACION;
        private string NOMBRES;
        private string CORREO;
        private string TELEFONO;
        private int PROVEEDOR_ID;

        public string IDENTIFICACION_ { get => IDENTIFICACION; set => IDENTIFICACION = value; }
        public string NOMBRES_ { get => NOMBRES; set => NOMBRES = value; }
        public string CORREO_ { get => CORREO; set => CORREO = value; }
        public string TELEFONO_ { get => TELEFONO; set => TELEFONO = value; }
        public int PROVEEDOR_ID_ { get => PROVEEDOR_ID; set => PROVEEDOR_ID = value; }

        public bool CrearProveedor()
        {
            //ConcatenacionCadena("EXEC SP_Insertar_Cliente '" + IDENTIFICACION_ + "' ,'" + NOMBRES_ + "',  '" + CORREO_ + "' , '" + TELEFONO_ + "'"); 
            //string SQL = "EXEC SP_EliminarProducto '" + CODIGO_ + "'";
            //ConcatenacionCadena(SQL);
            string sql = "SP_CREAR_PROVEEDOR";

            // Crear los parámetros
            var parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                  new System.Data.SqlClient.SqlParameter("@NOMBRES", NOMBRES_),
                  new System.Data.SqlClient.SqlParameter("@IDENTIFICACION", IDENTIFICACION_),
                  new System.Data.SqlClient.SqlParameter("@CORREO", CORREO_),
                  new System.Data.SqlClient.SqlParameter("@TELEFONO", TELEFONO_),
             };
            ConcatenacionCadena(sql, parametros);
            if (TransaccionCompleta)
            {
                MessageBox.Show("Proveedor Creado");
            }
            return TransaccionCompleta;
        }
        //editar
        public bool Editar_Proveedor()
        {
            //ConcatenacionCadena("EXEC SP_Actualizar_Cliente '" + IDENTIFICACION_ + "' , '" + NOMBRES_ + "', '" + CORREO_ + "' , '" + TELEFONO_ + "'");
            string sql = "SP_EDITAR_PROVEEDOR";
            // Crear los parámetros
            var parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                  new System.Data.SqlClient.SqlParameter("@NOMBRES",NOMBRES_ ),
                  new System.Data.SqlClient.SqlParameter("@IDENTIFICACION",  IDENTIFICACION_),
                  new System.Data.SqlClient.SqlParameter("@CORREO", CORREO_),
                  new System.Data.SqlClient.SqlParameter("@TELEFONO", TELEFONO_),
                  new System.Data.SqlClient.SqlParameter("@ID_Proveedor", PROVEEDOR_ID_),
             };
            ConcatenacionCadena(sql, parametros);
            if (TransaccionCompleta)
            {
                MessageBox.Show("Proveedor Editado");
            }
            return TransaccionCompleta;
        }
        //eliminar
        public void Eliminar_Proveedor()
        {
            //ConcatenacionCadena("EXEC SP_Eliminar_Cliente '" + IDENTIFICACION_ + "'");
            string sql = "SP_Eliminar_Proveedor";
            // Crear los parámetros
            var parametros = new List<System.Data.SqlClient.SqlParameter>
                {
                  new System.Data.SqlClient.SqlParameter("@Proveedor_ID", PROVEEDOR_ID_),
             };
            ConcatenacionCadena(sql, parametros);
            if (TransaccionCompleta)
            {
                MessageBox.Show("Proveedor Eliminado");
            }
        }
        //buscar
        //cuando se lista hay que enviar el id del proveedor no de la persona OJITO con eso 
        public DataTable Buscar_Proveedor_columna_especifica(string Palabra_Clave, string Columna)
        {
            //return Cargar_Data_Table("EXEC [SP_Buscar_Cliente] '"+Palabra_Clave+"'");
            string sql = "SP_BUSQUEDA_ESPECIFICA_PROVEEDORES";
            //MessageBox.Show(Palabra_Clave+" - "+Columna);
            var parametros = new List<System.Data.SqlClient.SqlParameter>
             {
                      new System.Data.SqlClient.SqlParameter("@Palabra_Clave", Palabra_Clave.Trim()),
                      new System.Data.SqlClient.SqlParameter("@Columna", Columna.Trim())
             };
            return Cargar_Data_Table(sql, parametros);
        }
    }
}
