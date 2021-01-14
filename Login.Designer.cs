
namespace WindowsFormsApp6
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Login2 = new System.Windows.Forms.TextBox();
            this.Senha2 = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Login2
            // 
            this.Login2.Location = new System.Drawing.Point(226, 213);
            this.Login2.Name = "Login2";
            this.Login2.Size = new System.Drawing.Size(100, 22);
            this.Login2.TabIndex = 2;
            this.Login2.TextChanged += new System.EventHandler(this.Login2_TextChanged);
            // 
            // Senha2
            // 
            this.Senha2.Location = new System.Drawing.Point(226, 263);
            this.Senha2.Name = "Senha2";
            this.Senha2.Size = new System.Drawing.Size(100, 22);
            this.Senha2.TabIndex = 3;
            this.Senha2.UseSystemPasswordChar = true;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(125, 213);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(57, 17);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Usuário";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(125, 263);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(65, 17);
            this.Senha.TabIndex = 5;
            this.Senha.Text = "Senha    ";
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(120, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Senha2);
            this.Controls.Add(this.Login2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "Autenticação";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Login2;
        private System.Windows.Forms.TextBox Senha2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}