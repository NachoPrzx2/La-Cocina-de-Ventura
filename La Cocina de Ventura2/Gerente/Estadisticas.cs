using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Cocina_de_Ventura2.Gerente
{
    public partial class Estadisticas : UserControl
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void CFechaInicial_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaInicial.Text = CFechaInicial.SelectionRange.Start.ToString();
        }

        private void CFechaFinal_DateChanged(object sender, DateRangeEventArgs e)
        {
            FechaFinal.Text = CFechaFinal.SelectionRange.Start.ToString();
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
