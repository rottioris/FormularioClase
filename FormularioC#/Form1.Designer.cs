namespace FormularioC_
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.Background = new System.Windows.Forms.PictureBox();
            this.IconUser = new System.Windows.Forms.PictureBox();
            this.IdUserBx = new System.Windows.Forms.TextBox();
            this.IdUserL = new System.Windows.Forms.Label();
            this.NameBx = new System.Windows.Forms.TextBox();
            this.ApellidoBx = new System.Windows.Forms.TextBox();
            this.TelfBx = new System.Windows.Forms.TextBox();
            this.EmailBx = new System.Windows.Forms.TextBox();
            this.NameL = new System.Windows.Forms.Label();
            this.TelfL = new System.Windows.Forms.Label();
            this.EmailL = new System.Windows.Forms.Label();
            this.AceptarBtt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(2, -1);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(805, 453);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // IconUser
            // 
            this.IconUser.Image = ((System.Drawing.Image)(resources.GetObject("IconUser.Image")));
            this.IconUser.Location = new System.Drawing.Point(328, 73);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(159, 158);
            this.IconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconUser.TabIndex = 1;
            this.IconUser.TabStop = false;
            this.IconUser.Click += new System.EventHandler(this.IconUser_Click);
            // 
            // IdUserBx
            // 
            this.IdUserBx.Location = new System.Drawing.Point(288, 240);
            this.IdUserBx.Name = "IdUserBx";
            this.IdUserBx.Size = new System.Drawing.Size(273, 20);
            this.IdUserBx.TabIndex = 2;
            // 
            // IdUserL
            // 
            this.IdUserL.AutoSize = true;
            this.IdUserL.BackColor = System.Drawing.Color.Transparent;
            this.IdUserL.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUserL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IdUserL.Image = ((System.Drawing.Image)(resources.GetObject("IdUserL.Image")));
            this.IdUserL.Location = new System.Drawing.Point(259, 240);
            this.IdUserL.Name = "IdUserL";
            this.IdUserL.Size = new System.Drawing.Size(23, 20);
            this.IdUserL.TabIndex = 3;
            this.IdUserL.Text = "ID";
            // 
            // NameBx
            // 
            this.NameBx.Location = new System.Drawing.Point(288, 266);
            this.NameBx.Name = "NameBx";
            this.NameBx.Size = new System.Drawing.Size(127, 20);
            this.NameBx.TabIndex = 4;
            // 
            // ApellidoBx
            // 
            this.ApellidoBx.Location = new System.Drawing.Point(421, 266);
            this.ApellidoBx.Name = "ApellidoBx";
            this.ApellidoBx.Size = new System.Drawing.Size(140, 20);
            this.ApellidoBx.TabIndex = 5;
            // 
            // TelfBx
            // 
            this.TelfBx.Location = new System.Drawing.Point(288, 292);
            this.TelfBx.Name = "TelfBx";
            this.TelfBx.Size = new System.Drawing.Size(273, 20);
            this.TelfBx.TabIndex = 6;
            // 
            // EmailBx
            // 
            this.EmailBx.Location = new System.Drawing.Point(288, 318);
            this.EmailBx.Name = "EmailBx";
            this.EmailBx.Size = new System.Drawing.Size(273, 20);
            this.EmailBx.TabIndex = 7;
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.BackColor = System.Drawing.Color.Transparent;
            this.NameL.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameL.Image = ((System.Drawing.Image)(resources.GetObject("NameL.Image")));
            this.NameL.Location = new System.Drawing.Point(239, 266);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(43, 20);
            this.NameL.TabIndex = 8;
            this.NameL.Text = "NAME";
            // 
            // TelfL
            // 
            this.TelfL.AutoSize = true;
            this.TelfL.BackColor = System.Drawing.Color.Transparent;
            this.TelfL.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelfL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TelfL.Image = ((System.Drawing.Image)(resources.GetObject("TelfL.Image")));
            this.TelfL.Location = new System.Drawing.Point(247, 292);
            this.TelfL.Name = "TelfL";
            this.TelfL.Size = new System.Drawing.Size(35, 20);
            this.TelfL.TabIndex = 9;
            this.TelfL.Text = "TELF";
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.BackColor = System.Drawing.Color.Transparent;
            this.EmailL.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EmailL.Image = ((System.Drawing.Image)(resources.GetObject("EmailL.Image")));
            this.EmailL.Location = new System.Drawing.Point(232, 318);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(50, 20);
            this.EmailL.TabIndex = 10;
            this.EmailL.Text = "E-MAIL";
            // 
            // AceptarBtt
            // 
            this.AceptarBtt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AceptarBtt.Font = new System.Drawing.Font("Impact", 12F);
            this.AceptarBtt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AceptarBtt.Image = ((System.Drawing.Image)(resources.GetObject("AceptarBtt.Image")));
            this.AceptarBtt.Location = new System.Drawing.Point(355, 344);
            this.AceptarBtt.Name = "AceptarBtt";
            this.AceptarBtt.Size = new System.Drawing.Size(106, 37);
            this.AceptarBtt.TabIndex = 11;
            this.AceptarBtt.Text = "ACEPTAR";
            this.AceptarBtt.UseVisualStyleBackColor = false;
            this.AceptarBtt.Click += new System.EventHandler(this.AceptarBtt_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AceptarBtt);
            this.Controls.Add(this.EmailL);
            this.Controls.Add(this.TelfL);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.EmailBx);
            this.Controls.Add(this.TelfBx);
            this.Controls.Add(this.ApellidoBx);
            this.Controls.Add(this.NameBx);
            this.Controls.Add(this.IdUserL);
            this.Controls.Add(this.IdUserBx);
            this.Controls.Add(this.IconUser);
            this.Controls.Add(this.Background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario";
            this.Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox IconUser;
        private System.Windows.Forms.TextBox IdUserBx;
        private System.Windows.Forms.Label IdUserL;
        private System.Windows.Forms.TextBox NameBx;
        private System.Windows.Forms.TextBox ApellidoBx;
        private System.Windows.Forms.TextBox TelfBx;
        private System.Windows.Forms.TextBox EmailBx;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label TelfL;
        private System.Windows.Forms.Label EmailL;
        private System.Windows.Forms.Button AceptarBtt;
    }
}

