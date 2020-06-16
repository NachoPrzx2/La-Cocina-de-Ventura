using La_Cocina_de_Ventura2.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Cocina_de_Ventura2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void changeview(string vista)
        {
            UserControl GorditasPanel = new GorditasMenu();
            UserControl QuesadillasPanel = new QuesadillasMenu();
            UserControl SopesTacosPanel = new SopesTacosMenu();
            UserControl BebidasPanel = new BebidasMenu();
            UserControl TortasPanel = new TortasMenu();
            UserControl EspecialesPanel = new EspecialesMenu();
            Contenedor.Controls.Clear();
            switch (vista)
            {
                case "PanelGorditas":
                    Contenedor.Controls.Add(GorditasPanel);
                    GorditasPanel.Dock = DockStyle.Fill;
                    break;
                case "QuesadillasPanel":
                    Contenedor.Controls.Add(QuesadillasPanel);
                    QuesadillasPanel.Dock = DockStyle.Fill;
                    break;
                case "SopesTacosPanel":
                    Contenedor.Controls.Add(SopesTacosPanel);
                    SopesTacosPanel.Dock = DockStyle.Fill;
                    break;
                case "BebidasPanel":
                    Contenedor.Controls.Add(BebidasPanel);
                    BebidasPanel.Dock = DockStyle.Fill;
                    break;
                case "TortasPanel":
                    Contenedor.Controls.Add(TortasPanel);
                    TortasPanel.Dock = DockStyle.Fill;
                    break;
                case "EspecialesPanel":
                    Contenedor.Controls.Add(EspecialesPanel);
                    EspecialesPanel.Dock = DockStyle.Fill;
                    break;
            }
        }
        //Se muestra el panel de gorditas y se ocultan los demas
        private void GorditasI_Click(object sender, EventArgs e)
        {
            changeview("PanelGorditas");
        }
        //Se muestra el panel de Quesadillas y se ocultan las demas
        private void QuesadillasI_Click(object sender, EventArgs e)
        {
            changeview("QuesadillasPanel");
        }
        //Se muestra el panel de Sopes y Tacos, se ocultan los demas
        private void SopesTacosI_Click(object sender, EventArgs e)
        {
            changeview("SopesTacosPanel");
        }
        //Se muestra el panel de Bebidas y se ocultan los demas
        private void BebidasI_Click(object sender, EventArgs e)
        {
            changeview("BebidasPanel");
        }
        //Se muestra el pabel de Tortas y se ocultan los demas
        private void TortasI_Click(object sender, EventArgs e)
        {
            changeview("TortasPanel");
        }
        //Se muestra el panel de Especiales y se ocultan los demas
        private void EspecialesI_Click(object sender, EventArgs e)
        {
            changeview("EspecialesPanel");
        }
        //Boton para salir del sistema
        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
