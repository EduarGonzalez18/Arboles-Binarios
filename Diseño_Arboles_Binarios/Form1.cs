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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pbImagen1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string clave = "unad";
            //  clave = this.txtContraseña.Text.Trim();


            decimal identificacion;





            if ((txtContraseña.Text.Equals("") || txtContraseña.Text != "unad"))
            {
                MessageBox.Show("Contrasela invalida");
                ErrorProviderInicioSesion.SetError(txtContraseña, "Ingrese una contraseña valida");
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;

            }

            else
            {

                   Menucs menu = new Menucs();
                   menu.ShowDialog();
                   this.Hide();
                 
             


            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
