using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria1._2.Forms
{
    public partial class Gastos : Form
    {
        public Gastos()
        {
            InitializeComponent();
        }

        private void Gastos_Load(object sender, EventArgs e)
        {

        }

        private void OpenForm(object fromHijo)
        {
            try
            {
                if (this.panel5.Controls.Count > 0)
                {
                    this.panel5.Controls.RemoveAt(0);
                }
                Form fh = fromHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel5.Controls.Add(fh);
                this.panel5.Tag = fh;
                fh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenForm");
            }
        }

        #region Forms

        private void label1_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistroGasto());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistroGasto());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaGasto());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaGasto());
        }
        #endregion
    }
}
