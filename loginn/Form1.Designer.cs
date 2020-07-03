namespace loginn
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.Label();
            this.acceder = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(134, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 0;
            // 
            // Loginpanel
            // 
            this.Loginpanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.Loginpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Loginpanel.Location = new System.Drawing.Point(0, 0);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(176, 373);
            this.Loginpanel.TabIndex = 5;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.login.Location = new System.Drawing.Point(349, 44);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(96, 28);
            this.login.TabIndex = 0;
            this.login.Text = "LOGIN";
            this.login.Click += new System.EventHandler(this.label1_Click);
            // 
            // acceder
            // 
            this.acceder.BackColor = System.Drawing.Color.DimGray;
            this.acceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.acceder.FlatAppearance.BorderSize = 0;
            this.acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceder.Font = new System.Drawing.Font("Century", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceder.ForeColor = System.Drawing.Color.White;
            this.acceder.Location = new System.Drawing.Point(224, 205);
            this.acceder.Name = "acceder";
            this.acceder.Size = new System.Drawing.Size(341, 38);
            this.acceder.TabIndex = 3;
            this.acceder.Text = "ACCEDER";
            this.acceder.UseVisualStyleBackColor = false;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.Info;
            this.user.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.user.Location = new System.Drawing.Point(225, 90);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(341, 27);
            this.user.TabIndex = 1;
            this.user.Text = "USUARIO";
            this.user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Info;
            this.password.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.Location = new System.Drawing.Point(224, 141);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(341, 27);
            this.password.TabIndex = 2;
            this.password.Text = "CONTRASEÑA";
            this.password.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(620, 373);
            this.Controls.Add(this.password);
            this.Controls.Add(this.acceder);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Loginpanel);
            this.Controls.Add(this.user);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button acceder;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
    }
}

