namespace testeste1
{
    partial class frmCadastroUsuario
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
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.txtCadUsuario = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(375, 133);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(49, 13);
            this.lblCadastroUsuario.TabIndex = 0;
            this.lblCadastroUsuario.Text = "Cadastro";
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.Location = new System.Drawing.Point(255, 178);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblCadUsuario.TabIndex = 1;
            this.lblCadUsuario.Text = "Usuário";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Location = new System.Drawing.Point(255, 226);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(41, 13);
            this.lblCadSenha.TabIndex = 2;
            this.lblCadSenha.Text = "Senha:";
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Location = new System.Drawing.Point(350, 219);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(100, 20);
            this.txtCadSenha.TabIndex = 3;
            // 
            // txtCadUsuario
            // 
            this.txtCadUsuario.Location = new System.Drawing.Point(350, 175);
            this.txtCadUsuario.Name = "txtCadUsuario";
            this.txtCadUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCadUsuario.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(365, 266);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCadUsuario);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Controls.Add(this.lblCadastroUsuario);
            this.Name = "frmCadastroUsuario";
            this.Text = "frmCadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.Label lblCadUsuario;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.TextBox txtCadUsuario;
        private System.Windows.Forms.Button btnCadastrar;
    }
}