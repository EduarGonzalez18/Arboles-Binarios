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
    public partial class Escenario_Uno : Form
    {
        private DialogResult resultado;
        public Escenario_Uno()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {


            DialogResult = resultado;
            resultado = MessageBox.Show("¿Desea regresar al Menú?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.Yes)
            {

                this.Hide();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Titulo 
            Graphics titulo = CreateGraphics();
            Font fuentetitulo = new Font("Arial", 25);
            titulo.DrawString("Grafico", fuentetitulo, Brushes.Black, 188, 95);


            //Nodo raiz
            //55
            Graphics nodo = CreateGraphics();
            Font fuente = new Font("Arial", 15);
            nodo.FillEllipse(Brushes.RosyBrown, 218, 133, 40, 40);
            nodo.DrawString("55", fuente, Brushes.Black, 224, 143);
            Pen linea = new Pen(Color.Black, 3);
            nodo.DrawLine(linea, 222, 164, 188, 195);


            // Primer triangulo

            //53

            Graphics nodo1 = CreateGraphics();
            Font fuente1 = new Font("Arial", 15);
            nodo1.FillEllipse(Brushes.RosyBrown, 155, 192, 40, 40);
            nodo1.DrawString("53", fuente1, Brushes.Black, 161, 202);
            Pen linea1 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea1, 158, 222, 118, 269);


            //48
            Graphics nodo2 = CreateGraphics();
            Font fuente2 = new Font("Arial", 15);
            nodo2.FillEllipse(Brushes.RosyBrown, 87, 265, 40, 40);
            nodo2.DrawString("48", fuente2, Brushes.Black, 93, 275);
            // Pen linea = new Pen(Color.Black, 3);
            // nodo.DrawLine(linea, 390, 72, 303, 113);

            //54
            Graphics nodo3 = CreateGraphics();
            Font fuente3 = new Font("Arial", 15);
            nodo3.FillEllipse(Brushes.RosyBrown, 220, 265, 40, 40);
            nodo3.DrawString("54", fuente3, Brushes.Black, 226, 275);
            Pen linea3 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea3, 190, 222, 226, 269);

            //51
            Graphics nodo4 = CreateGraphics();
            Font fuente4 = new Font("Arial", 15);
            nodo4.FillEllipse(Brushes.RosyBrown, 155, 333, 40, 40);
            nodo4.DrawString("51", fuente4, Brushes.Black, 161, 343);
            Pen linea4 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea4, 121, 297, 162, 338);


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////7

            // segundo triangulo

            //59
            Graphics nodo5 = CreateGraphics();
            Font fuente5 = new Font("Arial", 15);
            nodo5.FillEllipse(Brushes.RosyBrown, 302, 192, 40, 40);
            nodo5.DrawString("59", fuente5, Brushes.Black, 308, 202);
            Pen linea5 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea5, 255, 161, 306, 200);


            //56
            Graphics nodo6 = CreateGraphics();
            Font fuente6 = new Font("Arial", 15);
            nodo6.FillEllipse(Brushes.RosyBrown, 300, 265, 40, 40);
            nodo6.DrawString("56", fuente6, Brushes.Black, 306, 275);
            Pen linea6 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea6, 322, 231 ,322, 265);


            //57
            Graphics nodo7 = CreateGraphics();
            Font fuente7 = new Font("Arial", 15);
            nodo7.FillEllipse(Brushes.RosyBrown, 300, 333, 40, 40);
            nodo7.DrawString("57", fuente7, Brushes.Black, 306, 343);
            Pen linea7 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea7, 322, 303, 322, 333);


            //63
            Graphics nodo8 = CreateGraphics();
            Font fuente8 = new Font("Arial", 15);
            nodo8.FillEllipse(Brushes.RosyBrown, 390, 265, 40, 40);
            nodo8.DrawString("63", fuente8, Brushes.Black, 396, 275);
            Pen linea8 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea8, 341, 220, 398, 269);

            //61
            Graphics nodo9 = CreateGraphics();
            Font fuente9 = new Font("Arial", 15);
            nodo9.FillEllipse(Brushes.RosyBrown, 392, 333, 40, 40);
            nodo9.DrawString("61", fuente9, Brushes.Black, 398, 343);
            Pen linea9 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea9, 410, 304, 410, 332);


            //70
            Graphics nodo10 = CreateGraphics();
            Font fuente10 = new Font("Arial", 15);
            nodo10.FillEllipse(Brushes.RosyBrown, 465, 333, 40, 40);
            nodo10.DrawString("70", fuente10, Brushes.Black, 471, 343);
            Pen linea10 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea10, 425, 296, 475, 337);





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Graphics preOrden = CreateGraphics();
            Font fuente = new Font("Arial", 15);
            preOrden.DrawString("55,53,48,51,54,59,56,57,63,61,70", fuente, Brushes.Black, 650,238);


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            txtEjeX.Text = e.X.ToString();
            txtEjeY.Text = e.Y.ToString();

        }

        private void Escenario_Uno_Load(object sender, EventArgs e)
        {

        }

        private void Escenario_Uno_MouseMove(object sender, MouseEventArgs e)
        {

            txtEjeX.Text = e.X.ToString();
            txtEjeY.Text = e.Y.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            Graphics InOrden = CreateGraphics();
            Font fuente = new Font("Arial", 15);
            InOrden.DrawString("51,48,53,54,55,57,56,59,61,63,7", fuente, Brushes.Black, 650, 380);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            Font fuente = new Font("Arial", 15);
            Graphics PostOrden = CreateGraphics();
            PostOrden.DrawString("51,48,54,53,56,57,61,70,63,59,55", fuente, Brushes.Black, 650, 545);
        }
    }
}
