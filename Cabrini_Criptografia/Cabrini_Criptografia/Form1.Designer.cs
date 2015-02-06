namespace Cabrini_Criptografia
{
    partial class frCriptografia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDeCripto = new System.Windows.Forms.TextBox();
            this.lblMsgCripto = new System.Windows.Forms.Label();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboTipoCripto = new System.Windows.Forms.ComboBox();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCripto = new System.Windows.Forms.TextBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.nuChave = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaminho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuChave)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDeCripto
            // 
            this.txtDeCripto.Location = new System.Drawing.Point(28, 47);
            this.txtDeCripto.Multiline = true;
            this.txtDeCripto.Name = "txtDeCripto";
            this.txtDeCripto.Size = new System.Drawing.Size(257, 70);
            this.txtDeCripto.TabIndex = 0;
            // 
            // lblMsgCripto
            // 
            this.lblMsgCripto.AutoSize = true;
            this.lblMsgCripto.Location = new System.Drawing.Point(25, 31);
            this.lblMsgCripto.Name = "lblMsgCripto";
            this.lblMsgCripto.Size = new System.Drawing.Size(113, 13);
            this.lblMsgCripto.TabIndex = 1;
            this.lblMsgCripto.Text = "Texto a Decriptografar";
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(356, 79);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(91, 38);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboTipoCripto
            // 
            this.cboTipoCripto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCripto.FormattingEnabled = true;
            this.cboTipoCripto.Items.AddRange(new object[] {
            "cesar"});
            this.cboTipoCripto.Location = new System.Drawing.Point(356, 47);
            this.cboTipoCripto.Name = "cboTipoCripto";
            this.cboTipoCripto.Size = new System.Drawing.Size(120, 21);
            this.cboTipoCripto.TabIndex = 3;
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(466, 79);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(91, 38);
            this.btnDecriptografar.TabIndex = 4;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(356, 187);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 38);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(466, 187);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(91, 38);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto a Criptografar";
            // 
            // txtCripto
            // 
            this.txtCripto.Enabled = false;
            this.txtCripto.Location = new System.Drawing.Point(28, 157);
            this.txtCripto.Multiline = true;
            this.txtCripto.Name = "txtCripto";
            this.txtCripto.Size = new System.Drawing.Size(257, 70);
            this.txtCripto.TabIndex = 7;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Location = new System.Drawing.Point(356, 159);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(169, 20);
            this.txtCaminho.TabIndex = 9;
            // 
            // nuChave
            // 
            this.nuChave.Location = new System.Drawing.Point(482, 48);
            this.nuChave.Name = "nuChave";
            this.nuChave.Size = new System.Drawing.Size(75, 20);
            this.nuChave.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Cripto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Arquivo";
            // 
            // btnCaminho
            // 
            this.btnCaminho.Location = new System.Drawing.Point(531, 159);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(26, 20);
            this.btnCaminho.TabIndex = 14;
            this.btnCaminho.Text = "...";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // frCriptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 250);
            this.Controls.Add(this.btnCaminho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuChave);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCripto);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDecriptografar);
            this.Controls.Add(this.cboTipoCripto);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.lblMsgCripto);
            this.Controls.Add(this.txtDeCripto);
            this.Name = "frCriptografia";
            this.Text = "Criptografia";
            ((System.ComponentModel.ISupportInitialize)(this.nuChave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeCripto;
        private System.Windows.Forms.Label lblMsgCripto;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboTipoCripto;
        private System.Windows.Forms.Button btnDecriptografar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCripto;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.NumericUpDown nuChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCaminho;
    }
}

