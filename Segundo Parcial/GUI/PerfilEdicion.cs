using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Parcial.GUI
{
    public partial class PerfilEdicion : Form
    {
        Accion _AccionElegida = Accion.INSERTAR;
        Boolean _PROCESAR = false;

        public Boolean Procesar
        {
            get { return _PROCESAR; }
            set { _PROCESAR = value; }
        }

        public enum Accion { INSERTAR, ACTUALIZAR };
        
        public PerfilEdicion(Accion pAccion)
        {
            InitializeComponent();
            _AccionElegida = pAccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_AccionElegida == Accion.INSERTAR)
            {
                _PROCESAR = true;
                Close();
            }
            else
            {
                _PROCESAR = true;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PerfilEdicion_Load(object sender, EventArgs e)
        {

        }

        

        

        
    }
}
