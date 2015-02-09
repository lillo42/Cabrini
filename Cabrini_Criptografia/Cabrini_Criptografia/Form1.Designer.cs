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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCriptografia));
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCaminho = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDeCripto
            // 
            this.txtDeCripto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeCripto.Location = new System.Drawing.Point(28, 47);
            this.txtDeCripto.Multiline = true;
            this.txtDeCripto.Name = "txtDeCripto";
            this.txtDeCripto.Size = new System.Drawing.Size(257, 70);
            this.txtDeCripto.TabIndex = 0;
            // 
            // lblMsgCripto
            // 
            this.lblMsgCripto.AutoSize = true;
            this.lblMsgCripto.BackColor = System.Drawing.Color.Transparent;
            this.lblMsgCripto.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgCripto.Location = new System.Drawing.Point(25, 31);
            this.lblMsgCripto.Name = "lblMsgCripto";
            this.lblMsgCripto.Size = new System.Drawing.Size(147, 15);
            this.lblMsgCripto.TabIndex = 1;
            this.lblMsgCripto.Text = "Texto a Criptografar";
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCriptografar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCriptografar.FlatAppearance.BorderSize = 2;
            this.btnCriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnCriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriptografar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCriptografar.Location = new System.Drawing.Point(395, 99);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(113, 38);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = false;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboTipoCripto
            // 
            this.cboTipoCripto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCripto.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCripto.FormattingEnabled = true;
            this.cboTipoCripto.Location = new System.Drawing.Point(395, 27);
            this.cboTipoCripto.Name = "cboTipoCripto";
            this.cboTipoCripto.Size = new System.Drawing.Size(113, 23);
            this.cboTipoCripto.TabIndex = 3;
            this.cboTipoCripto.SelectedIndexChanged += new System.EventHandler(this.cboTipoCripto_SelectedIndexChanged);
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecriptografar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDecriptografar.FlatAppearance.BorderSize = 2;
            this.btnDecriptografar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDecriptografar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecriptografar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecriptografar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDecriptografar.Location = new System.Drawing.Point(513, 99);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(113, 38);
            this.btnDecriptografar.TabIndex = 4;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = false;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(395, 193);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 38);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAbrir.FlatAppearance.BorderSize = 2;
            this.btnAbrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrir.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAbrir.Location = new System.Drawing.Point(513, 193);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(113, 38);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Texto a decriptografar";
            // 
            // txtCripto
            // 
            this.txtCripto.Enabled = false;
            this.txtCripto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCripto.Location = new System.Drawing.Point(28, 157);
            this.txtCripto.Multiline = true;
            this.txtCripto.Name = "txtCripto";
            this.txtCripto.Size = new System.Drawing.Size(257, 70);
            this.txtCripto.TabIndex = 7;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(395, 165);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(201, 21);
            this.txtCaminho.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de Cripto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Arquivo";
            // 
            // btnCaminho
            // 
            this.btnCaminho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCaminho.Location = new System.Drawing.Point(600, 165);
            this.btnCaminho.Name = "btnCaminho";
            this.btnCaminho.Size = new System.Drawing.Size(26, 20);
            this.btnCaminho.TabIndex = 14;
            this.btnCaminho.Text = "...";
            this.btnCaminho.UseVisualStyleBackColor = true;
            this.btnCaminho.Click += new System.EventHandler(this.btnCaminho_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(395, 69);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(231, 20);
            this.txtChave.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo de Algoritmo";
            // 
            // cbAlgoritmos
            // 
            this.cbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlgoritmos.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlgoritmos.FormattingEnabled = true;
            this.cbAlgoritmos.Items.AddRange(new object[] {
            "cesar"});
            this.cbAlgoritmos.Location = new System.Drawing.Point(513, 27);
            this.cbAlgoritmos.Name = "cbAlgoritmos";
            this.cbAlgoritmos.Size = new System.Drawing.Size(113, 23);
            this.cbAlgoritmos.TabIndex = 16;
            // 
            // frCriptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 272);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbAlgoritmos);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnCaminho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frCriptografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCaminho;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlgoritmos;
    }
}

