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
    public partial class PerfilesPrincipal : Form
    {
        DataTable _DATOS = new DataTable();

        private void GuardarLista()
        {
            _DATOS.TableName = "Perfiles";
            _DATOS.WriteXml("Perfiles.xml");
        }

        //private void LeerLista()
        //{
        //    _DATOS.TableName = "Perfiles";
        //    _DATOS.ReadXml("Perfiles.xml");
        //}

        private void ContarRegistros()
        {
            lblStatus.Text = dtgPerfiles.Rows.Count.ToString() + " Registros encontrados";
        }

        private void Configurar()
        {
            _DATOS.Columns.Add("cQuitar");
            _DATOS.Columns.Add("cEditar");
            _DATOS.Columns.Add("cPerfil");
            _DATOS.Columns.Add("cServidor");
            _DATOS.Columns.Add("cBase");
            _DATOS.Columns.Add("cUsuario");
            _DATOS.Columns.Add("cPuerto");

            dtgPerfiles.AutoGenerateColumns = false;
            dtgPerfiles.DataSource = _DATOS;
        }
        public PerfilesPrincipal()
        {
            InitializeComponent();
            Configurar();
            //LeerLista();
            ContarRegistros();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PerfilEdicion f = new PerfilEdicion();
        }
    }
}
