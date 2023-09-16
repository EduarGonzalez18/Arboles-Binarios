using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Arboles_Binarios
{
    public partial class Menucs : Form
    {
        private DialogResult resultado;

        public Menucs()
        {
            InitializeComponent();
        }

        private void Menucs_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult = resultado;
            resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEscenario1_Click(object sender, EventArgs e)
        {

            Escenario_Uno escenario_Uno = new Escenario_Uno();
            escenario_Uno.ShowDialog();
          //  this.Hide();


        }

        private void btnEscenario2_Click(object sender, EventArgs e)
        {
            

            Escenario_Dos escenario_Dos = new Escenario_Dos();
            escenario_Dos.ShowDialog();
           // this.Hide();
        }
    }
}
