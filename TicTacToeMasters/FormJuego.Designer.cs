namespace TicTacToeMasters
{
    partial class FormJuego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJuego));
            this.tableTablero = new System.Windows.Forms.TableLayoutPanel();
            this.labelJugador1 = new System.Windows.Forms.Label();
            this.labelJugador2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.labelPuntos1 = new System.Windows.Forms.Label();
            this.labelPuntos2 = new System.Windows.Forms.Label();
            this.labelVictorias1 = new System.Windows.Forms.Label();
            this.labelVictorias2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableTablero
            // 
            this.tableTablero.BackColor = System.Drawing.Color.Transparent;
            this.tableTablero.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableTablero.ColumnCount = 3;
            this.tableTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.8F));
            this.tableTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.2F));
            this.tableTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableTablero.Location = new System.Drawing.Point(252, 27);
            this.tableTablero.Name = "tableTablero";
            this.tableTablero.RowCount = 3;
            this.tableTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.80695F));
            this.tableTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.19305F));
            this.tableTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableTablero.Size = new System.Drawing.Size(380, 380);
            this.tableTablero.TabIndex = 0;
            // 
            // labelJugador1
            // 
            this.labelJugador1.AutoSize = true;
            this.labelJugador1.BackColor = System.Drawing.Color.Transparent;
            this.labelJugador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJugador1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJugador1.Location = new System.Drawing.Point(73, 267);
            this.labelJugador1.Name = "labelJugador1";
            this.labelJugador1.Size = new System.Drawing.Size(103, 24);
            this.labelJugador1.TabIndex = 3;
            this.labelJugador1.Text = "Jugador 1";
            // 
            // labelJugador2
            // 
            this.labelJugador2.AutoSize = true;
            this.labelJugador2.BackColor = System.Drawing.Color.Transparent;
            this.labelJugador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJugador2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJugador2.Location = new System.Drawing.Point(711, 267);
            this.labelJugador2.Name = "labelJugador2";
            this.labelJugador2.Size = new System.Drawing.Size(103, 24);
            this.labelJugador2.TabIndex = 4;
            this.labelJugador2.Text = "Jugador 2";
            // 
            // btnVolver
            // 
            this.btnVolver.Enabled = false;
            this.btnVolver.Location = new System.Drawing.Point(783, 406);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::TicTacToeMasters.Properties.Resources.ficha_2;
            this.pictureBox2.Location = new System.Drawing.Point(682, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.Transparent;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox1.Image = global::TicTacToeMasters.Properties.Resources.ficha_1;
            this.picBox1.Location = new System.Drawing.Point(46, 79);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(161, 162);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            // 
            // labelPuntos1
            // 
            this.labelPuntos1.AutoSize = true;
            this.labelPuntos1.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPuntos1.Location = new System.Drawing.Point(93, 305);
            this.labelPuntos1.Name = "labelPuntos1";
            this.labelPuntos1.Size = new System.Drawing.Size(61, 18);
            this.labelPuntos1.TabIndex = 7;
            this.labelPuntos1.Text = "Puntos";
            // 
            // labelPuntos2
            // 
            this.labelPuntos2.AutoSize = true;
            this.labelPuntos2.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPuntos2.Location = new System.Drawing.Point(733, 305);
            this.labelPuntos2.Name = "labelPuntos2";
            this.labelPuntos2.Size = new System.Drawing.Size(61, 18);
            this.labelPuntos2.TabIndex = 8;
            this.labelPuntos2.Text = "Puntos";
            // 
            // labelVictorias1
            // 
            this.labelVictorias1.AutoSize = true;
            this.labelVictorias1.BackColor = System.Drawing.Color.Transparent;
            this.labelVictorias1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictorias1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelVictorias1.Location = new System.Drawing.Point(90, 336);
            this.labelVictorias1.Name = "labelVictorias1";
            this.labelVictorias1.Size = new System.Drawing.Size(78, 15);
            this.labelVictorias1.TabIndex = 9;
            this.labelVictorias1.Text = "% Victorias";
            // 
            // labelVictorias2
            // 
            this.labelVictorias2.AutoSize = true;
            this.labelVictorias2.BackColor = System.Drawing.Color.Transparent;
            this.labelVictorias2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVictorias2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelVictorias2.Location = new System.Drawing.Point(728, 336);
            this.labelVictorias2.Name = "labelVictorias2";
            this.labelVictorias2.Size = new System.Drawing.Size(78, 15);
            this.labelVictorias2.TabIndex = 10;
            this.labelVictorias2.Text = "% Victorias";
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TicTacToeMasters.Properties.Resources.fondowood;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.labelVictorias2);
            this.Controls.Add(this.labelVictorias1);
            this.Controls.Add(this.labelPuntos2);
            this.Controls.Add(this.labelPuntos1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labelJugador2);
            this.Controls.Add(this.labelJugador1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.tableTablero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJuego";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTablero;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelJugador1;
        private System.Windows.Forms.Label labelJugador2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label labelPuntos1;
        private System.Windows.Forms.Label labelPuntos2;
        private System.Windows.Forms.Label labelVictorias1;
        private System.Windows.Forms.Label labelVictorias2;
    }
}