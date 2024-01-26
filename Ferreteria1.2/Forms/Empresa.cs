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
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {

        }

        private void OpenForm(object fromHijo)
        {
            try
            {
                if (this.panel7.Controls.Count > 0)
                {
                    this.panel7.Controls.RemoveAt(0);
                }
                Form fh = fromHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel7.Controls.Add(fh);
                this.panel7.Tag = fh;
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
            OpenForm(new Registos.RegistrarEmpresa());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistrarEmpresa());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistrarFacturas());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistrarFacturas());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistoAbonos());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistoAbonos());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaEmpresa());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaEmpresa());
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaAbonos());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaEmpresa());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaFacturas());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaFacturas());
        }
        #endregion
    }
}
