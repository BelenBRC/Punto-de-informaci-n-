namespace PuntoInformacionCristoRey
{
    partial class PanallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanallaPrincipal));
            this.flowLayoutControles = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.PictureBox();
            this.personal = new System.Windows.Forms.PictureBox();
            this.map = new System.Windows.Forms.PictureBox();
            this.form = new System.Windows.Forms.PictureBox();
            this.calendario = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.flowLayoutControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.web)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutControles
            // 
            this.flowLayoutControles.Controls.Add(this.web);
            this.flowLayoutControles.Controls.Add(this.personal);
            this.flowLayoutControles.Controls.Add(this.map);
            this.flowLayoutControles.Controls.Add(this.form);
            this.flowLayoutControles.Controls.Add(this.calendario);
            this.flowLayoutControles.Controls.Add(this.exit);
            this.flowLayoutControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutControles.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutControles.Name = "flowLayoutControles";
            this.flowLayoutControles.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.flowLayoutControles.Size = new System.Drawing.Size(956, 618);
            this.flowLayoutControles.TabIndex = 0;
            // 
            // labelDireccion
            // 
            this.labelDireccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(12, 566);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(1139, 51);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "Calle San Gregorio Alto, 5          18010 - Granada (España)";
            this.labelDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // web
            // 
            this.web.Image = global::PuntoInformacionCristoRey.Properties.Resources.web;
            this.web.Location = new System.Drawing.Point(120, 3);
            this.web.Margin = new System.Windows.Forms.Padding(90, 3, 80, 3);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(190, 170);
            this.web.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.web.TabIndex = 0;
            this.web.TabStop = false;
            this.web.Click += new System.EventHandler(this.web_Click);
            // 
            // personal
            // 
            this.personal.Image = global::PuntoInformacionCristoRey.Properties.Resources.personal;
            this.personal.Location = new System.Drawing.Point(393, 3);
            this.personal.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.personal.Name = "personal";
            this.personal.Size = new System.Drawing.Size(190, 170);
            this.personal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.personal.TabIndex = 1;
            this.personal.TabStop = false;
            this.personal.Click += new System.EventHandler(this.personal_Click);
            // 
            // map
            // 
            this.map.Image = global::PuntoInformacionCristoRey.Properties.Resources.map;
            this.map.Location = new System.Drawing.Point(33, 179);
            this.map.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(190, 170);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 2;
            this.map.TabStop = false;
            this.map.Click += new System.EventHandler(this.map_Click);
            // 
            // form
            // 
            this.form.Image = global::PuntoInformacionCristoRey.Properties.Resources.form;
            this.form.Location = new System.Drawing.Point(393, 179);
            this.form.Margin = new System.Windows.Forms.Padding(90, 3, 80, 3);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(190, 170);
            this.form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.form.TabIndex = 3;
            this.form.TabStop = false;
            this.form.Click += new System.EventHandler(this.form_Click);
            // 
            // calendario
            // 
            this.calendario.Image = global::PuntoInformacionCristoRey.Properties.Resources.calendario;
            this.calendario.Location = new System.Drawing.Point(33, 355);
            this.calendario.Margin = new System.Windows.Forms.Padding(3, 3, 80, 3);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(190, 170);
            this.calendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.calendario.TabIndex = 5;
            this.calendario.TabStop = false;
            this.calendario.Click += new System.EventHandler(this.calendario_Click);
            // 
            // exit
            // 
            this.exit.Image = global::PuntoInformacionCristoRey.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(306, 355);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(190, 170);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // PanallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 618);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.flowLayoutControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanallaPrincipal";
            this.Text = "PUNTO DE INFORMACIÓN CES CRISTO REY";
            this.flowLayoutControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.web)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutControles;
        private System.Windows.Forms.PictureBox web;
        private System.Windows.Forms.PictureBox personal;
        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.PictureBox form;
        private System.Windows.Forms.PictureBox calendario;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label labelDireccion;
    }
}