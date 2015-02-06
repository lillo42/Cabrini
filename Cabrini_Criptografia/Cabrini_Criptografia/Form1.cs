using Criptografia.Crifras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabrini_Criptografia
{
    public partial class frCriptografia : Form
    {
        public frCriptografia()
        {
            InitializeComponent();
        }


        private void CriptoCesar()
        {
            var cesar = new Cesar();
            txtCripto.Text = cesar.Criptografa(txtDeCripto.Text, (int)nuChave.Value);
        }

        private void DesCriptoCesar()
        {
            var cesar = new Cesar();
            txtDeCripto.Text = cesar.Decriptografa(txtCripto.Text, (int)nuChave.Value);
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (cboTipoCripto.SelectedIndex == 0)
                CriptoCesar();
            txtDeCripto.Clear();
            
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            if (cboTipoCripto.SelectedIndex == 0)
                DesCriptoCesar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, txtCripto.Text);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCaminho.Text))
            {
                txtCripto.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = openFileDialog1.FileName;
            }
        }

    }
}
