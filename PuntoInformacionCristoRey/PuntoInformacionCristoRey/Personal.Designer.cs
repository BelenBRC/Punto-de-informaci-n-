namespace PuntoInformacionCristoRey
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.pictureBoxRetroceder = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelPersonal = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroceder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRetroceder
            // 
            this.pictureBoxRetroceder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRetroceder.Image = global::PuntoInformacionCristoRey.Properties.Resources.exit;
            this.pictureBoxRetroceder.Location = new System.Drawing.Point(845, 6);
            this.pictureBoxRetroceder.Name = "pictureBoxRetroceder";
            this.pictureBoxRetroceder.Size = new System.Drawing.Size(60, 74);
            this.pictureBoxRetroceder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRetroceder.TabIndex = 1;
            this.pictureBoxRetroceder.TabStop = false;
            this.pictureBoxRetroceder.Click += new System.EventHandler(this.pictureBoxRetroceder_Click);
            // 
            // flowLayoutPanelPersonal
            // 
            this.flowLayoutPanelPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPersonal.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPersonal.Name = "flowLayoutPanelPersonal";
            this.flowLayoutPanelPersonal.Size = new System.Drawing.Size(917, 554);
            this.flowLayoutPanelPersonal.TabIndex = 2;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 554);
            this.Controls.Add(this.pictureBoxRetroceder);
            this.Controls.Add(this.flowLayoutPanelPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Personal";
            this.Text = "PUNTO DE INFORMACIÓN CES CRISTO REY";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRetroceder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRetroceder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPersonal;
    }
}