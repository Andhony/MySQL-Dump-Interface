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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            Cronometro.Stop();
            this.Hide();
            GUI.PerfilesPrincipal f = new PerfilesPrincipal();
            f.ShowDialog();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Cronometro.Start();
        }
    }
}
