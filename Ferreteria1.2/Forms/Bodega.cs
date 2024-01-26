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
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
        }
        private void Bodega_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistroBodega());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            OpenForm(new Registos.RegistroBodega());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistroBodega());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.IngresarProductos());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            OpenForm(new Registos.IngresarProductos());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.IngresarProductos());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaProductos());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            OpenForm(new Listas.ListaProductos());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaProductos());
        }

        private void label5_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaBodega());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            OpenForm(new Listas.ListaBodega());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaBodega());
        }

        #endregion
    }
}
