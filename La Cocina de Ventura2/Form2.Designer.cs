namespace La_Cocina_de_Ventura2
{
    partial class Form2
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
            this.listaP = new System.Windows.Forms.ListBox();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.BebidasI = new System.Windows.Forms.PictureBox();
            this.EspecialesI = new System.Windows.Forms.PictureBox();
            this.TortasI = new System.Windows.Forms.PictureBox();
            this.SopesTacosI = new System.Windows.Forms.PictureBox();
            this.QuesadillasI = new System.Windows.Forms.PictureBox();
            this.GorditasI = new System.Windows.Forms.PictureBox();
            this.orden = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BebidasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspecialesI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TortasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SopesTacosI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.orden);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.listaP);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(866, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 820);
            this.panel1.TabIndex = 8;
            // 
            // listaP
            // 
            this.listaP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaP.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaP.FormattingEnabled = true;
            this.listaP.ItemHeight = 33;
            this.listaP.Location = new System.Drawing.Point(46, 192);
            this.listaP.Name = "listaP";
            this.listaP.Size = new System.Drawing.Size(332, 429);
            this.listaP.TabIndex = 8;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Red;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(368, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(51, 48);
            this.salir.TabIndex = 7;
            this.salir.Text = "X";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden N° 000";
            // 
            // Contenedor
            // 
            this.Contenedor.Location = new System.Drawing.Point(3, 158);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(860, 659);
            this.Contenedor.TabIndex = 7;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // BebidasI
            // 
            this.BebidasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_5;
            this.BebidasI.Location = new System.Drawing.Point(436, -4);
            this.BebidasI.Name = "BebidasI";
            this.BebidasI.Size = new System.Drawing.Size(151, 158);
            this.BebidasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BebidasI.TabIndex = 4;
            this.BebidasI.TabStop = false;
            this.BebidasI.Click += new System.EventHandler(this.BebidasI_Click);
            // 
            // EspecialesI
            // 
            this.EspecialesI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_6;
            this.EspecialesI.Location = new System.Drawing.Point(716, -3);
            this.EspecialesI.Name = "EspecialesI";
            this.EspecialesI.Size = new System.Drawing.Size(151, 158);
            this.EspecialesI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspecialesI.TabIndex = 6;
            this.EspecialesI.TabStop = false;
            this.EspecialesI.Click += new System.EventHandler(this.EspecialesI_Click);
            // 
            // TortasI
            // 
            this.TortasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_8;
            this.TortasI.Location = new System.Drawing.Point(579, -4);
            this.TortasI.Name = "TortasI";
            this.TortasI.Size = new System.Drawing.Size(151, 158);
            this.TortasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TortasI.TabIndex = 5;
            this.TortasI.TabStop = false;
            this.TortasI.Click += new System.EventHandler(this.TortasI_Click);
            // 
            // SopesTacosI
            // 
            this.SopesTacosI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_4;
            this.SopesTacosI.Location = new System.Drawing.Point(289, -4);
            this.SopesTacosI.Name = "SopesTacosI";
            this.SopesTacosI.Size = new System.Drawing.Size(151, 158);
            this.SopesTacosI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SopesTacosI.TabIndex = 3;
            this.SopesTacosI.TabStop = false;
            this.SopesTacosI.Click += new System.EventHandler(this.SopesTacosI_Click);
            // 
            // QuesadillasI
            // 
            this.QuesadillasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_3;
            this.QuesadillasI.Location = new System.Drawing.Point(142, -4);
            this.QuesadillasI.Name = "QuesadillasI";
            this.QuesadillasI.Size = new System.Drawing.Size(151, 158);
            this.QuesadillasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuesadillasI.TabIndex = 2;
            this.QuesadillasI.TabStop = false;
            this.QuesadillasI.Click += new System.EventHandler(this.QuesadillasI_Click);
            // 
            // GorditasI
            // 
            this.GorditasI.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Grupo_2;
            this.GorditasI.Location = new System.Drawing.Point(-5, -4);
            this.GorditasI.Name = "GorditasI";
            this.GorditasI.Size = new System.Drawing.Size(151, 158);
            this.GorditasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GorditasI.TabIndex = 1;
            this.GorditasI.TabStop = false;
            this.GorditasI.Click += new System.EventHandler(this.GorditasI_Click);
            // 
            // orden
            // 
            this.orden.BackColor = System.Drawing.Color.Transparent;
            this.orden.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_3;
            this.orden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orden.FlatAppearance.BorderSize = 0;
            this.orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orden.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orden.Location = new System.Drawing.Point(35, 729);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(352, 77);
            this.orden.TabIndex = 11;
            this.orden.Text = "Realizar Orden";
            this.orden.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_62;
            this.label2.Location = new System.Drawing.Point(122, 600);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total $000.00";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Silver;
            this.pictureBox8.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_62;
            this.pictureBox8.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_62;
            this.pictureBox8.Location = new System.Drawing.Point(35, 590);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(352, 63);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_18;
            this.pictureBox7.Location = new System.Drawing.Point(35, 174);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(352, 479);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1284, 818);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.BebidasI);
            this.Controls.Add(this.EspecialesI);
            this.Controls.Add(this.TortasI);
            this.Controls.Add(this.SopesTacosI);
            this.Controls.Add(this.QuesadillasI);
            this.Controls.Add(this.GorditasI);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BebidasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EspecialesI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TortasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SopesTacosI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuesadillasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GorditasI;
        private System.Windows.Forms.PictureBox QuesadillasI;
        private System.Windows.Forms.PictureBox SopesTacosI;
        private System.Windows.Forms.PictureBox BebidasI;
        private System.Windows.Forms.PictureBox TortasI;
        private System.Windows.Forms.PictureBox EspecialesI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.ListBox listaP;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orden;
        private System.Windows.Forms.Panel Contenedor;
    }
}