namespace Tela_de_login
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginlabel1 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.senhalabel = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.buttom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginlabel1
            // 
            this.loginlabel1.AutoSize = true;
            this.loginlabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginlabel1.Location = new System.Drawing.Point(205, 139);
            this.loginlabel1.Name = "loginlabel1";
            this.loginlabel1.Size = new System.Drawing.Size(36, 16);
            this.loginlabel1.TabIndex = 0;
            this.loginlabel1.Text = "login";
            this.loginlabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(269, 133);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(100, 22);
            this.txtlogin.TabIndex = 1;
            this.txtlogin.TextChanged += new System.EventHandler(this.textboxlogin_TextChanged);
            // 
            // senhalabel
            // 
            this.senhalabel.AutoSize = true;
            this.senhalabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.senhalabel.Location = new System.Drawing.Point(197, 192);
            this.senhalabel.Name = "senhalabel";
            this.senhalabel.Size = new System.Drawing.Size(44, 16);
            this.senhalabel.TabIndex = 2;
            this.senhalabel.Text = "senha";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(269, 192);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 22);
            this.txtsenha.TabIndex = 3;
            // 
            // buttom
            // 
            this.buttom.Location = new System.Drawing.Point(247, 232);
            this.buttom.Name = "buttom";
            this.buttom.Size = new System.Drawing.Size(75, 23);
            this.buttom.TabIndex = 4;
            this.buttom.Text = "buttom";
            this.buttom.UseVisualStyleBackColor = true;
            this.buttom.Click += new System.EventHandler(this.buttom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttom);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.senhalabel);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.loginlabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel1;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label senhalabel;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button buttom;
    }
}

