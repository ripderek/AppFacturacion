using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFacturacion2024.Clases
{
    internal class ManejoSesion
    {
        private static ManejoSesion _instance;
        public string UsuarioVendedor { get; set; }

        private ManejoSesion() { }

        public static ManejoSesion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManejoSesion();
                }
                return _instance;
            }
        }
    }
}
