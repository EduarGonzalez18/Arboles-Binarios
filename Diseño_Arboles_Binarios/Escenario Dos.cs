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
    public partial class Escenario_Dos : Form
    {
        private DialogResult resultado;
        public Escenario_Dos()
        {
            InitializeComponent();
        }

        private void Escenario_Dos_MouseMove(object sender, MouseEventArgs e)
        {
            txtEjeX.Text = e.X.ToString();
            txtEjeY.Text = e.Y.ToString();

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

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            Graphics preOrden = CreateGraphics();
            Font fuente = new Font("Arial", 15);
            preOrden.DrawString("18,9,7,2,8,12,11,25,23,21,24,29,31", fuente, Brushes.Black, 615, 238);
        }

        private void btnInOrden_Click(object sender, EventArgs e)
        {
            Graphics InOrden = CreateGraphics();
            Font fuente = new Font("Arial", 15);
            InOrden.DrawString("2,7,8,9,11,12,18,21,23,24,25,29,31", fuente, Brushes.Black, 615, 380);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {

            Font fuente = new Font("Arial", 15);
            Graphics PostOrden = CreateGraphics();
            PostOrden.DrawString("2,8,7,11,12,9,21,24,23,31,29,25,18", fuente, Brushes.Black, 615, 545);
        }






        // Botón Para mostrar el grafico del arbol
        private void brnMostrarGrafico_Click(object sender, EventArgs e)
        {

            //Nodo raiz
            //18
            Graphics nodo = CreateGraphics();
            Font fuente = new Font("Arial", 15);
            nodo.FillEllipse(Brushes.RosyBrown, 218, 133, 40, 40);
            nodo.DrawString("18", fuente, Brushes.Black, 224, 143);
            Pen linea = new Pen(Color.Black, 3);
            nodo.DrawLine(linea, 222, 163, 158, 206);



            
            //9
            Graphics nodo1 = CreateGraphics();
            Font fuente1 = new Font("Arial", 15);
            nodo1.FillEllipse(Brushes.RosyBrown, 125, 200, 40, 40);
            nodo1.DrawString("9", fuente1, Brushes.Black, 135, 210);
            Pen linea1 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea1, 130, 232, 106, 271);


          
            //7
            Graphics nodo2 = CreateGraphics();
            Font fuente2 = new Font("Arial", 15);
            nodo2.FillEllipse(Brushes.RosyBrown, 80, 270, 40, 40);
            nodo2.DrawString("7", fuente2, Brushes.Black, 90, 280);
            Pen linea2 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea2, 86, 302, 54, 330);


            
            //2
            Graphics nodo3 = CreateGraphics();
            Font fuente3 = new Font("Arial", 15);
            nodo3.FillEllipse(Brushes.RosyBrown, 30, 330, 40, 40);
            nodo3.DrawString("2", fuente3, Brushes.Black, 40, 340);
        
       
            //8
            Graphics nodo4 = CreateGraphics();
            Font fuente4 = new Font("Arial", 15);
            nodo4.FillEllipse(Brushes.RosyBrown, 130, 330, 40, 40);
            nodo4.DrawString("8", fuente4, Brushes.Black, 140, 345);
           Pen linea4 = new Pen(Color.Black, 3);
           nodo.DrawLine(linea4, 115, 302, 140, 332);


            
            //12
            Graphics nodo5 = CreateGraphics();
            Font fuente5 = new Font("Arial", 15);
            nodo5.FillEllipse(Brushes.RosyBrown, 190, 270, 40, 40);
            nodo5.DrawString("12", fuente5, Brushes.Black, 196, 280);
            Pen linea5 = new Pen(Color.Black, 3);
            nodo.DrawLine(linea5, 158, 232, 200, 274);


      
            //11
            Graphics nodo6 = CreateGraphics();
            Font fuente6 = new Font("Arial", 15);
            nodo6.FillEllipse(Brushes.RosyBrown, 190, 330, 40, 40);
            nodo6.DrawString("11", fuente6, Brushes.Black, 200, 340);
            Pen linea6 = new Pen(Color.Black, 3);
            nodo6.DrawLine(linea6, 210, 310, 210, 332);


            //25
            Graphics nodo7 = CreateGraphics();
            Font fuente7 = new Font("Arial", 15);
            nodo7.FillEllipse(Brushes.RosyBrown, 375, 200, 40, 40);
            nodo7.DrawString("25", fuente7, Brushes.Black, 381, 210);
            Pen linea7 = new Pen(Color.Black, 3);
            nodo7.DrawLine(linea7, 255, 163, 385, 203);


        
            //23
            Graphics nodo8 = CreateGraphics();
            Font fuente8 = new Font("Arial", 15);
            nodo8.FillEllipse(Brushes.RosyBrown, 300, 280, 40, 40);
            nodo8.DrawString("23", fuente8, Brushes.Black, 305, 290);
            Pen linea8 = new Pen(Color.Black, 3);
            nodo8.DrawLine(linea8, 381, 233, 333, 286);


            //21
            Graphics nodo9 = CreateGraphics();
            Font fuente9 = new Font("Arial", 15);
            nodo9.FillEllipse(Brushes.RosyBrown, 300, 330, 40, 40);
            nodo9.DrawString("21", fuente9, Brushes.Black, 310, 340);
            Pen linea9 = new Pen(Color.Black, 3);
            nodo9.DrawLine(linea9, 320, 320, 320, 330);


            //29
            Graphics nodo11 = CreateGraphics();
            Font fuente11 = new Font("Arial", 15);
            nodo11.FillEllipse(Brushes.RosyBrown, 450, 280, 40, 40);
            nodo11.DrawString("29", fuente11, Brushes.Black, 460, 290);
            Pen linea11 = new Pen(Color.Black, 3);
            nodo11.DrawLine(linea11, 414, 228, 460, 284);


            //24
            Graphics nodo12 = CreateGraphics();
            Font fuente12 = new Font("Arial", 15);
            nodo12.FillEllipse(Brushes.RosyBrown, 375, 330, 40, 40);
            nodo12.DrawString("24", fuente12, Brushes.Black, 383, 340);
            Pen linea12 = new Pen(Color.Black, 3);
            nodo12.DrawLine(linea12, 336, 311, 384, 334);


            //31
            Graphics nodo10 = CreateGraphics();
            Font fuente10 = new Font("Arial", 15);
            nodo10.FillEllipse(Brushes.RosyBrown, 490, 330, 40, 40);
            nodo10.DrawString("31", fuente10, Brushes.Black, 500, 340);
            Pen linea10 = new Pen(Color.Black, 3);
            nodo10.DrawLine(linea10, 486, 312, 505, 332);



        }

        private void Escenario_Dos_Load(object sender, EventArgs e)
        {

        }
    }
}
