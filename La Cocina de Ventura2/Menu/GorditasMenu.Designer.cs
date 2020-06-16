namespace La_Cocina_de_Ventura2.Menu
{
    partial class GorditasMenu
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.GorditasComal = new System.Windows.Forms.NumericUpDown();
            this.GorditasB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GorditasDoradas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasComal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasDoradas)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gorditas de Comal";
            // 
            // GorditasComal
            // 
            this.GorditasComal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GorditasComal.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GorditasComal.Location = new System.Drawing.Point(332, 26);
            this.GorditasComal.Name = "GorditasComal";
            this.GorditasComal.Size = new System.Drawing.Size(68, 40);
            this.GorditasComal.TabIndex = 4;
            this.GorditasComal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GorditasB
            // 
            this.GorditasB.BackColor = System.Drawing.Color.Transparent;
            this.GorditasB.BackgroundImage = global::La_Cocina_de_Ventura2.Properties.Resources.Rectángulo_19;
            this.GorditasB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GorditasB.FlatAppearance.BorderSize = 0;
            this.GorditasB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GorditasB.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GorditasB.ForeColor = System.Drawing.Color.White;
            this.GorditasB.Location = new System.Drawing.Point(664, 577);
            this.GorditasB.Name = "GorditasB";
            this.GorditasB.Size = new System.Drawing.Size(193, 79);
            this.GorditasB.TabIndex = 3;
            this.GorditasB.Text = "Añadir";
            this.GorditasB.UseVisualStyleBackColor = false;
            this.GorditasB.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gorditas Dorada";
            // 
            // GorditasDoradas
            // 
            this.GorditasDoradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GorditasDoradas.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GorditasDoradas.Location = new System.Drawing.Point(332, 81);
            this.GorditasDoradas.Name = "GorditasDoradas";
            this.GorditasDoradas.Size = new System.Drawing.Size(68, 40);
            this.GorditasDoradas.TabIndex = 6;
            this.GorditasDoradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GorditasMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GorditasDoradas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GorditasComal);
            this.Controls.Add(this.GorditasB);
            this.Name = "GorditasMenu";
            this.Size = new System.Drawing.Size(860, 659);
            ((System.ComponentModel.ISupportInitialize)(this.GorditasComal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorditasDoradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown GorditasComal;
        private System.Windows.Forms.Button GorditasB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GorditasDoradas;
    }
}
