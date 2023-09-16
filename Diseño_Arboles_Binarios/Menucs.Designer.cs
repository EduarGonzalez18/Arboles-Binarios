namespace Diseño_Arboles_Binarios
{
    partial class Menucs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEscenario1 = new System.Windows.Forms.Button();
            this.btnEscenario2 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(286, 409);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 45);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu De Opciones";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-5, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(843, 101);
            this.panel4.TabIndex = 13;
            // 
            // btnEscenario1
            // 
            this.btnEscenario1.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEscenario1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEscenario1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEscenario1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscenario1.ForeColor = System.Drawing.Color.Transparent;
            this.btnEscenario1.Location = new System.Drawing.Point(105, 246);
            this.btnEscenario1.Name = "btnEscenario1";
            this.btnEscenario1.Size = new System.Drawing.Size(188, 66);
            this.btnEscenario1.TabIndex = 14;
            this.btnEscenario1.Text = "Escenario Uno";
            this.btnEscenario1.UseVisualStyleBackColor = false;
            this.btnEscenario1.Click += new System.EventHandler(this.btnEscenario1_Click);
            // 
            // btnEscenario2
            // 
            this.btnEscenario2.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEscenario2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEscenario2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEscenario2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscenario2.ForeColor = System.Drawing.Color.Transparent;
            this.btnEscenario2.Location = new System.Drawing.Point(419, 246);
            this.btnEscenario2.Name = "btnEscenario2";
            this.btnEscenario2.Size = new System.Drawing.Size(188, 66);
            this.btnEscenario2.TabIndex = 15;
            this.btnEscenario2.Text = "Escenario Dos";
            this.btnEscenario2.UseVisualStyleBackColor = false;
            this.btnEscenario2.Click += new System.EventHandler(this.btnEscenario2_Click);
            // 
            // Menucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(839, 608);
            this.Controls.Add(this.btnEscenario2);
            this.Controls.Add(this.btnEscenario1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnSalir);
            this.Name = "Menucs";
            this.Text = "Menucs";
            this.Load += new System.EventHandler(this.Menucs_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEscenario1;
        private System.Windows.Forms.Button btnEscenario2;
    }
}