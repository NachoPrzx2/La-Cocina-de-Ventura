namespace La_Cocina_de_Ventura2.Menu
{
    partial class Gerente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.ContenedorGerente = new System.Windows.Forms.Panel();
            this.PreciosB = new System.Windows.Forms.Button();
            this.EstadisticasB = new System.Windows.Forms.Button();
            this.ReportesB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ReportesB);
            this.panel1.Controls.Add(this.EstadisticasB);
            this.panel1.Controls.Add(this.PreciosB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 771);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.salir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(272, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 49);
            this.panel2.TabIndex = 1;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(943, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 48);
            this.salir.TabIndex = 8;
            this.salir.Text = "X";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // ContenedorGerente
            // 
            this.ContenedorGerente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorGerente.Location = new System.Drawing.Point(272, 49);
            this.ContenedorGerente.Name = "ContenedorGerente";
            this.ContenedorGerente.Size = new System.Drawing.Size(994, 722);
            this.ContenedorGerente.TabIndex = 2;
            // 
            // PreciosB
            // 
            this.PreciosB.FlatAppearance.BorderSize = 0;
            this.PreciosB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreciosB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreciosB.ForeColor = System.Drawing.Color.White;
            this.PreciosB.Location = new System.Drawing.Point(0, 237);
            this.PreciosB.Name = "PreciosB";
            this.PreciosB.Size = new System.Drawing.Size(272, 87);
            this.PreciosB.TabIndex = 0;
            this.PreciosB.Text = "Precios";
            this.PreciosB.UseVisualStyleBackColor = true;
            this.PreciosB.Click += new System.EventHandler(this.button1_Click);
            // 
            // EstadisticasB
            // 
            this.EstadisticasB.FlatAppearance.BorderSize = 0;
            this.EstadisticasB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EstadisticasB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadisticasB.ForeColor = System.Drawing.Color.White;
            this.EstadisticasB.Location = new System.Drawing.Point(0, 322);
            this.EstadisticasB.Name = "EstadisticasB";
            this.EstadisticasB.Size = new System.Drawing.Size(272, 87);
            this.EstadisticasB.TabIndex = 1;
            this.EstadisticasB.Text = "Estadisticas";
            this.EstadisticasB.UseVisualStyleBackColor = true;
            // 
            // ReportesB
            // 
            this.ReportesB.FlatAppearance.BorderSize = 0;
            this.ReportesB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportesB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportesB.ForeColor = System.Drawing.Color.White;
            this.ReportesB.Location = new System.Drawing.Point(0, 409);
            this.ReportesB.Name = "ReportesB";
            this.ReportesB.Size = new System.Drawing.Size(272, 87);
            this.ReportesB.TabIndex = 2;
            this.ReportesB.Text = "Reportes";
            this.ReportesB.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Logo_LA_cocina_de_Ventura;
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 771);
            this.Controls.Add(this.ContenedorGerente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gerente";
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.Gerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Panel ContenedorGerente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReportesB;
        private System.Windows.Forms.Button EstadisticasB;
        private System.Windows.Forms.Button PreciosB;
    }
}