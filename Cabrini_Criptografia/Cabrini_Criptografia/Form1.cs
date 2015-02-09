using Criptografia.Crifras;
using Criptografia.Interfaces;
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
            cboTipoCripto.DataSource = Enum.GetValues(typeof(TipoCriptografia));
        }


        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            switch((TipoCriptografia)cboTipoCripto.SelectedValue)
            {
                case TipoCriptografia.MonoAlfabetica:
                    CriptoMonoAlfabetica();
                    break;
                case TipoCriptografia.PoliAlfabetica:
                    CriptoPoliAlfabetica();
                    break;
                default:
                    break;
            }
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            switch ((TipoCriptografia)cboTipoCripto.SelectedValue)
            {
                case TipoCriptografia.MonoAlfabetica:
                    DeCriptoMonoAlfabetica();
                    break;
                case TipoCriptografia.PoliAlfabetica:
                    DeCriptoPoliAlfabetica();
                    break;
                default:
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(openFileDialog1.FileName, txtCripto.Text);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCaminho.Text))
            {
                txtCripto.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCaminho.Text = openFileDialog1.FileName;
            }
        }

        private void cboTipoCripto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAlgoritmos.DataSource = null;
            cbAlgoritmos.DisplayMember = "Nome";
            cbAlgoritmos.DataSource = GetCriptografias();
        }

        private List<ICripto> GetCriptografias()
        {
            switch ((TipoCriptografia)cboTipoCripto.SelectedValue)
            {
                case TipoCriptografia.MonoAlfabetica:
                    return GetMonoAlfabetica();
                case TipoCriptografia.PoliAlfabetica:
                    return GetPoliAlfabetica();
                default:
                    return null;
            }
        }

        private List<ICripto> GetMonoAlfabetica()
        {
            var retorno = new List<ICripto>();
            retorno.Add(new Cesar());
            return retorno;
        }

        private List<ICripto> GetPoliAlfabetica()
        {
            var retorno = new List<ICripto>();
            retorno.Add(new Vigenere());
            return retorno;
        }

        private void CriptoMonoAlfabetica()
        {
            var cripto = (IMonoAlfabetica)cbAlgoritmos.SelectedValue;
            int chave;
            if (int.TryParse(txtChave.Text, out chave))
                txtCripto.Text = cripto.Criptografa(txtDeCripto.Text, chave);
        }

        private void DeCriptoMonoAlfabetica()
        {
            var cripto = (IMonoAlfabetica)cbAlgoritmos.SelectedValue;
            int chave;
            if (int.TryParse(txtChave.Text, out chave))
                txtDeCripto.Text = cripto.Decriptografa(txtCripto.Text, chave);
        }

        private void CriptoPoliAlfabetica()
        {
            var cripto = (IPoliAlfabetica)cbAlgoritmos.SelectedValue;
            txtCripto.Text = cripto.Criptografa(txtCripto.Text, txtChave.Text);
        }

        private void DeCriptoPoliAlfabetica()
        {
            var cripto = (IPoliAlfabetica)cbAlgoritmos.SelectedValue;
            txtDeCripto.Text = cripto.Decriptografa(txtCripto.Text, txtChave.Text);
        }
    }
}
