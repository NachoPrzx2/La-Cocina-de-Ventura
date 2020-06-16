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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Aqui se cierra el formulario "Login" y se abre el Form2 (ventas)
        private void button1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            Form frm2 = new Menu.Gerente();
            frm2.Show();
            
        }
        //Boton para salir del programa
        private void salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
