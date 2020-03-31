using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroProyectoFinal.UI;
using RegistroProyectoFinal.UI.Consultas;
using RegistroProyectoFinal.UI.Registro;


namespace RegistroProyectoFinal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void FacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarFacturacion frm = new RegistrarFacturacion();
            frm.Show();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarProducto frm = new RegistrarProducto();
            frm.Show();

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void FacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarFacturacion frm = new ConsultarFacturacion();
            frm.Show();
        }
    }
}
