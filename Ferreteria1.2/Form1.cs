using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void OpenForm(object fromHijo)
        {
            try
            {
                if (this.panel11.Controls.Count > 0)
                {
                    this.panel11.Controls.RemoveAt(0);
                }
                Form fh = fromHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panel11.Controls.Add(fh);
                this.panel11.Tag = fh;
                fh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OpenForm");
            }
        }

        #region Forms
        private void ventasFrom_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Ventas());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Ventas());
        }

        private void Bodega_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Bodega());
        }

        private void pictureBodega_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Bodega());
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Usuarios());
        }

        private void pictureUsuario_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Usuarios());
        }

        private void Gasto_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Gastos());
        }

        private void pictureGasto_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Gastos());
        }

        private void Empresa_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Empresa());
        }

        private void pictureEmpresa_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Empresa());
        }

        private void Control_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Control());
        }

        private void pictureControl_Click(object sender, EventArgs e)
        {
            OpenForm(new Forms.Control());
        }

        #endregion


    }
}