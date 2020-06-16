namespace La_Cocina_de_Ventura2.Gerente
{
    partial class Ventas
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
            this.ListaOrdenes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaOrdenes
            // 
            this.ListaOrdenes.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaOrdenes.FormattingEnabled = true;
            this.ListaOrdenes.ItemHeight = 40;
            this.ListaOrdenes.Location = new System.Drawing.Point(18, 75);
            this.ListaOrdenes.MultiColumn = true;
            this.ListaOrdenes.Name = "ListaOrdenes";
            this.ListaOrdenes.Size = new System.Drawing.Size(492, 524);
            this.ListaOrdenes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 144);
            this.label2.TabIndex = 2;
            this.label2.Text = "Información de \r\nla Orden";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::La_Cocina_de_Ventura2.Properties.Resources.icons8_imprimir_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(233, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaOrdenes);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(994, 722);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaOrdenes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
