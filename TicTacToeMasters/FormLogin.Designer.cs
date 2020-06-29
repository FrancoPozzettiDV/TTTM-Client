namespace TicTacToeMasters
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.whiteLineUser = new System.Windows.Forms.Panel();
            this.whiteLinePass = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.labelCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxPass = new System.Windows.Forms.PictureBox();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(531, 119);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 19);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "Ingresar usuario";
            this.txtUsuario.Click += new System.EventHandler(this.txtUsuario_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(531, 217);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 19);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Ingresar contraseña";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(498, 284);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(283, 42);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.TabStop = false;
            this.btnInicio.Text = "Entrar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(497, 356);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(284, 20);
            this.labelError.TabIndex = 7;
            this.labelError.Text = "Por favor, ingresar todos los datos";
            this.labelError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.picBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 419);
            this.panel1.TabIndex = 8;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::TicTacToeMasters.Properties.Resources.logo;
            this.picBoxLogo.Location = new System.Drawing.Point(6, 103);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(396, 223);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Firebrick;
            this.panelRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRed.Location = new System.Drawing.Point(405, 0);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(16, 419);
            this.panelRed.TabIndex = 9;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.DarkOrange;
            this.panelYellow.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelYellow.Location = new System.Drawing.Point(421, 0);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(16, 419);
            this.panelYellow.TabIndex = 10;
            // 
            // whiteLineUser
            // 
            this.whiteLineUser.BackColor = System.Drawing.Color.White;
            this.whiteLineUser.Location = new System.Drawing.Point(531, 144);
            this.whiteLineUser.Name = "whiteLineUser";
            this.whiteLineUser.Size = new System.Drawing.Size(250, 1);
            this.whiteLineUser.TabIndex = 11;
            // 
            // whiteLinePass
            // 
            this.whiteLinePass.BackColor = System.Drawing.Color.White;
            this.whiteLinePass.Location = new System.Drawing.Point(531, 242);
            this.whiteLinePass.Name = "whiteLinePass";
            this.whiteLinePass.Size = new System.Drawing.Size(250, 1);
            this.whiteLinePass.TabIndex = 14;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBlue.Location = new System.Drawing.Point(437, 0);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(16, 419);
            this.panelBlue.TabIndex = 15;
            // 
            // labelCerrar
            // 
            this.labelCerrar.AutoSize = true;
            this.labelCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCerrar.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCerrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelCerrar.Location = new System.Drawing.Point(792, 0);
            this.labelCerrar.Name = "labelCerrar";
            this.labelCerrar.Size = new System.Drawing.Size(26, 29);
            this.labelCerrar.TabIndex = 16;
            this.labelCerrar.Text = "X";
            this.labelCerrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(537, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Iniciar Sesión";
            // 
            // picBoxPass
            // 
            this.picBoxPass.Image = global::TicTacToeMasters.Properties.Resources.password;
            this.picBoxPass.Location = new System.Drawing.Point(498, 217);
            this.picBoxPass.Name = "picBoxPass";
            this.picBoxPass.Size = new System.Drawing.Size(27, 26);
            this.picBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPass.TabIndex = 13;
            this.picBoxPass.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.Image = global::TicTacToeMasters.Properties.Resources.user;
            this.picBoxUser.Location = new System.Drawing.Point(498, 119);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(27, 26);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUser.TabIndex = 12;
            this.picBoxUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(816, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCerrar);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.whiteLinePass);
            this.Controls.Add(this.picBoxPass);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.whiteLineUser);
            this.Controls.Add(this.panelYellow);
            this.Controls.Add(this.panelRed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel whiteLineUser;
        private System.Windows.Forms.PictureBox picBoxUser;
        private System.Windows.Forms.PictureBox picBoxPass;
        private System.Windows.Forms.Panel whiteLinePass;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Label labelCerrar;
        private System.Windows.Forms.Label label1;
    }
}

