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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
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
        private void label2_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistrarUsuario());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenForm(new Registos.RegistrarUsuario());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaUsuarios());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenForm(new Listas.ListaUsuarios());
        }
        #endregion

    }
}
