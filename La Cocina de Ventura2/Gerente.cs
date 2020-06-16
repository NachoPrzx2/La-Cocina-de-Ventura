using La_Cocina_de_Ventura2.Gerente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Cocina_de_Ventura2.Menu
{
    public partial class Gerente : Form
    {
        public Gerente()
        {
            InitializeComponent();
        }

        private void Gerente_Load(object sender, EventArgs e)
        {

        }
        private void changeview(string vista)
        {
            UserControl PrecioPanel = new Precios();
         
            ContenedorGerente.Controls.Clear();
            switch (vista)
            {
                case "Precios":
                    ContenedorGerente.Controls.Add(PrecioPanel);
                    PrecioPanel.Dock = DockStyle.Fill;
                    break;
            }
        }
        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeview("Precios");
        }
    }
}
