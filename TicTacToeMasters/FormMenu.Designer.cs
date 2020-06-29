namespace TicTacToeMasters
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonJugar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.labelVictorias = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxFlagO = new System.Windows.Forms.PictureBox();
            this.picBoxFlagX = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelUsuarioAPI = new System.Windows.Forms.Label();
            this.labelPuntosAPI = new System.Windows.Forms.Label();
            this.labelVictoriasAPI = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlagO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlagX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonJugar
            // 
            this.buttonJugar.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJugar.FlatAppearance.BorderSize = 0;
            this.buttonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonJugar.Location = new System.Drawing.Point(5, 301);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(105, 40);
            this.buttonJugar.TabIndex = 2;
            this.buttonJugar.Text = "Jugar";
            this.buttonJugar.UseVisualStyleBackColor = false;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSalir.Location = new System.Drawing.Point(5, 359);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(105, 40);
            this.buttonSalir.TabIndex = 3;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(12, 62);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(91, 20);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "USUARIO";
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntaje.ForeColor = System.Drawing.Color.White;
            this.labelPuntaje.Location = new System.Drawing.Point(12, 130);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(88, 20);
            this.labelPuntaje.TabIndex = 5;
            this.labelPuntaje.Text = "PUNTAJE";
            // 
            // labelVictorias
            // 
            this.labelVictorias.AutoSize = true;
            this.labelVictorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictorias.ForeColor = System.Drawing.Color.White;
            this.labelVictorias.Location = new System.Drawing.Point(5, 198);
            this.labelVictorias.Name = "labelVictorias";
            this.labelVictorias.Size = new System.Drawing.Size(105, 20);
            this.labelVictorias.TabIndex = 6;
            this.labelVictorias.Text = "VICTORIAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BackgroundImage = global::TicTacToeMasters.Properties.Resources.fondocolor;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.picBoxFlagO);
            this.panel2.Controls.Add(this.picBoxFlagX);
            this.panel2.Controls.Add(this.picBoxLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 450);
            this.panel2.TabIndex = 2;
            // 
            // picBoxFlagO
            // 
            this.picBoxFlagO.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFlagO.Image = global::TicTacToeMasters.Properties.Resources.obanner2;
            this.picBoxFlagO.Location = new System.Drawing.Point(581, -16);
            this.picBoxFlagO.Name = "picBoxFlagO";
            this.picBoxFlagO.Size = new System.Drawing.Size(103, 191);
            this.picBoxFlagO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFlagO.TabIndex = 2;
            this.picBoxFlagO.TabStop = false;
            // 
            // picBoxFlagX
            // 
            this.picBoxFlagX.BackColor = System.Drawing.Color.Transparent;
            this.picBoxFlagX.Image = global::TicTacToeMasters.Properties.Resources.xbanner;
            this.picBoxFlagX.Location = new System.Drawing.Point(0, -16);
            this.picBoxFlagX.Name = "picBoxFlagX";
            this.picBoxFlagX.Size = new System.Drawing.Size(103, 191);
            this.picBoxFlagX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFlagX.TabIndex = 1;
            this.picBoxFlagX.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogo.Image = global::TicTacToeMasters.Properties.Resources.logo;
            this.picBoxLogo.Location = new System.Drawing.Point(104, 101);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(473, 244);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // labelUsuarioAPI
            // 
            this.labelUsuarioAPI.AutoSize = true;
            this.labelUsuarioAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuarioAPI.ForeColor = System.Drawing.Color.White;
            this.labelUsuarioAPI.Location = new System.Drawing.Point(24, 97);
            this.labelUsuarioAPI.Name = "labelUsuarioAPI";
            this.labelUsuarioAPI.Size = new System.Drawing.Size(13, 16);
            this.labelUsuarioAPI.TabIndex = 7;
            this.labelUsuarioAPI.Text = "-";
            // 
            // labelPuntosAPI
            // 
            this.labelPuntosAPI.AutoSize = true;
            this.labelPuntosAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntosAPI.ForeColor = System.Drawing.Color.White;
            this.labelPuntosAPI.Location = new System.Drawing.Point(32, 166);
            this.labelPuntosAPI.Name = "labelPuntosAPI";
            this.labelPuntosAPI.Size = new System.Drawing.Size(13, 16);
            this.labelPuntosAPI.TabIndex = 8;
            this.labelPuntosAPI.Text = "-";
            // 
            // labelVictoriasAPI
            // 
            this.labelVictoriasAPI.AutoSize = true;
            this.labelVictoriasAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictoriasAPI.ForeColor = System.Drawing.Color.White;
            this.labelVictoriasAPI.Location = new System.Drawing.Point(32, 234);
            this.labelVictoriasAPI.Name = "labelVictoriasAPI";
            this.labelVictoriasAPI.Size = new System.Drawing.Size(13, 16);
            this.labelVictoriasAPI.TabIndex = 9;
            this.labelVictoriasAPI.Text = "-";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelVictoriasAPI);
            this.Controls.Add(this.labelPuntosAPI);
            this.Controls.Add(this.labelUsuarioAPI);
            this.Controls.Add(this.labelVictorias);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonJugar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlagO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFlagX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxFlagO;
        private System.Windows.Forms.PictureBox picBoxFlagX;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPuntaje;
        private System.Windows.Forms.Label labelVictorias;
        private System.Windows.Forms.Label labelUsuarioAPI;
        private System.Windows.Forms.Label labelPuntosAPI;
        private System.Windows.Forms.Label labelVictoriasAPI;
    }
}