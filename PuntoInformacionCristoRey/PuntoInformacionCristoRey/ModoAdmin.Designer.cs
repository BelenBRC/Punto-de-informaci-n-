namespace PuntoInformacionCristoRey
{
    partial class ModoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModoAdmin));
            this.pictureBoxRetroceder = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCont = new System.Windows.Forms.TextBox();
            this.dataGridViewPersonal = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonRecargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroceder)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRetroceder
            // 
            this.pictureBoxRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRetroceder.Image = global::PuntoInformacionCristoRey.Properties.Resources.exit;
            this.pictureBoxRetroceder.Location = new System.Drawing.Point(742, 12);
            this.pictureBoxRetroceder.Name = "pictureBoxRetroceder";
            this.pictureBoxRetroceder.Size = new System.Drawing.Size(60, 74);
            this.pictureBoxRetroceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRetroceder.TabIndex = 2;
            this.pictureBoxRetroceder.TabStop = false;
            this.pictureBoxRetroceder.Click += new System.EventHandler(this.pictureBoxRetroceder_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.textBoxCont);
            this.panelLogin.Controls.Add(this.buttonAcceder);
            this.panelLogin.Controls.Add(this.textBoxUser);
            this.panelLogin.Controls.Add(this.labelContrasenia);
            this.panelLogin.Controls.Add(this.labelUser);
            this.panelLogin.Controls.Add(this.pictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(814, 496);
            this.panelLogin.TabIndex = 3;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.splitContainer1);
            this.panelAdmin.Controls.Add(this.label1);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(814, 496);
            this.panelAdmin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::PuntoInformacionCristoRey.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(27, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.labelUser.Location = new System.Drawing.Point(364, 139);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(119, 36);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario";
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.labelContrasenia.Location = new System.Drawing.Point(367, 228);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(168, 36);
            this.labelContrasenia.TabIndex = 2;
            this.labelContrasenia.Text = "Contraseña";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(367, 179);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(375, 41);
            this.textBoxUser.TabIndex = 1;
            // 
            // buttonAcceder
            // 
            this.buttonAcceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAcceder.Location = new System.Drawing.Point(445, 363);
            this.buttonAcceder.Name = "buttonAcceder";
            this.buttonAcceder.Size = new System.Drawing.Size(236, 62);
            this.buttonAcceder.TabIndex = 3;
            this.buttonAcceder.Text = "Acceder";
            this.buttonAcceder.UseVisualStyleBackColor = false;
            this.buttonAcceder.Click += new System.EventHandler(this.buttonAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(168)))), ((int)(((byte)(217)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrar personal";
            // 
            // textBoxCont
            // 
            this.textBoxCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCont.Location = new System.Drawing.Point(367, 267);
            this.textBoxCont.Name = "textBoxCont";
            this.textBoxCont.PasswordChar = '*';
            this.textBoxCont.Size = new System.Drawing.Size(375, 41);
            this.textBoxCont.TabIndex = 2;
            // 
            // dataGridViewPersonal
            // 
            this.dataGridViewPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersonal.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonal.Name = "dataGridViewPersonal";
            this.dataGridViewPersonal.RowHeadersWidth = 51;
            this.dataGridViewPersonal.RowTemplate.Height = 24;
            this.dataGridViewPersonal.Size = new System.Drawing.Size(621, 390);
            this.dataGridViewPersonal.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 106);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewPersonal);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonRecargar);
            this.splitContainer1.Panel2.Controls.Add(this.buttonGuardar);
            this.splitContainer1.Size = new System.Drawing.Size(814, 390);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonGuardar.Location = new System.Drawing.Point(0, -11);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(186, 78);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar cambios";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonRecargar.Location = new System.Drawing.Point(0, 98);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(186, 78);
            this.buttonRecargar.TabIndex = 2;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = false;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // ModoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 496);
            this.Controls.Add(this.pictureBoxRetroceder);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.panelLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModoAdmin";
            this.Text = "MODO ADMINISRADOR - PUNTO DE INFORMACIÓN CES CRISTO REY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroceder)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonal)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRetroceder;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button buttonAcceder;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCont;
        private System.Windows.Forms.DataGridView dataGridViewPersonal;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonRecargar;
    }
}