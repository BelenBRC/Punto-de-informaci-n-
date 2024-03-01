namespace PuntoInformacionCristoRey
{
    partial class Planos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonPapeleríasCercanas = new System.Windows.Forms.Button();
            this.buttonPlanta3 = new System.Windows.Forms.Button();
            this.buttonPlanta2 = new System.Windows.Forms.Button();
            this.buttonPlanta1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagenPlano = new System.Windows.Forms.PictureBox();
            this.mapasGoogle = new GMap.NET.WindowsForms.GMapControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPlano)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.splitContainer1.Panel1.Controls.Add(this.buttonPapeleríasCercanas);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlanta3);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlanta2);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPlanta1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.imagenPlano);
            this.splitContainer1.Panel2.Controls.Add(this.mapasGoogle);
            this.splitContainer1.Size = new System.Drawing.Size(818, 528);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonPapeleríasCercanas
            // 
            this.buttonPapeleríasCercanas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPapeleríasCercanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonPapeleríasCercanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPapeleríasCercanas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonPapeleríasCercanas.Location = new System.Drawing.Point(0, 312);
            this.buttonPapeleríasCercanas.Name = "buttonPapeleríasCercanas";
            this.buttonPapeleríasCercanas.Size = new System.Drawing.Size(186, 78);
            this.buttonPapeleríasCercanas.TabIndex = 3;
            this.buttonPapeleríasCercanas.Text = "Papelerías cercanas";
            this.toolTip1.SetToolTip(this.buttonPapeleríasCercanas, "Mostrar mapa papelerías cercanas");
            this.buttonPapeleríasCercanas.UseVisualStyleBackColor = false;
            this.buttonPapeleríasCercanas.Click += new System.EventHandler(this.buttonPapeleríasCercanas_Click);
            // 
            // buttonPlanta3
            // 
            this.buttonPlanta3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlanta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonPlanta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonPlanta3.Location = new System.Drawing.Point(0, 228);
            this.buttonPlanta3.Name = "buttonPlanta3";
            this.buttonPlanta3.Size = new System.Drawing.Size(186, 78);
            this.buttonPlanta3.TabIndex = 2;
            this.buttonPlanta3.Text = "3ª planta";
            this.toolTip1.SetToolTip(this.buttonPlanta3, "Mostrar plano tercera planta");
            this.buttonPlanta3.UseVisualStyleBackColor = false;
            this.buttonPlanta3.Click += new System.EventHandler(this.buttonPlanta3_Click);
            // 
            // buttonPlanta2
            // 
            this.buttonPlanta2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlanta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonPlanta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonPlanta2.Location = new System.Drawing.Point(0, 144);
            this.buttonPlanta2.Name = "buttonPlanta2";
            this.buttonPlanta2.Size = new System.Drawing.Size(186, 78);
            this.buttonPlanta2.TabIndex = 1;
            this.buttonPlanta2.Text = "2ª planta";
            this.toolTip1.SetToolTip(this.buttonPlanta2, "Mostrar plano segunda planta");
            this.buttonPlanta2.UseVisualStyleBackColor = false;
            this.buttonPlanta2.Click += new System.EventHandler(this.buttonPlanta2_Click);
            // 
            // buttonPlanta1
            // 
            this.buttonPlanta1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlanta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(111)))), ((int)(((byte)(140)))));
            this.buttonPlanta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonPlanta1.Location = new System.Drawing.Point(0, 60);
            this.buttonPlanta1.Name = "buttonPlanta1";
            this.buttonPlanta1.Size = new System.Drawing.Size(186, 78);
            this.buttonPlanta1.TabIndex = 0;
            this.buttonPlanta1.Text = "1ª planta";
            this.toolTip1.SetToolTip(this.buttonPlanta1, "Mostrar plano primera planta");
            this.buttonPlanta1.UseVisualStyleBackColor = false;
            this.buttonPlanta1.Click += new System.EventHandler(this.buttonPlanta1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.pictureBox1.Image = global::PuntoInformacionCristoRey.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(555, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Volver al menú");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imagenPlano
            // 
            this.imagenPlano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(183)))), ((int)(((byte)(5)))));
            this.imagenPlano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenPlano.Image = global::PuntoInformacionCristoRey.Properties.Resources.planta1;
            this.imagenPlano.Location = new System.Drawing.Point(0, 0);
            this.imagenPlano.Name = "imagenPlano";
            this.imagenPlano.Size = new System.Drawing.Size(627, 528);
            this.imagenPlano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagenPlano.TabIndex = 0;
            this.imagenPlano.TabStop = false;
            // 
            // mapasGoogle
            // 
            this.mapasGoogle.Bearing = 0F;
            this.mapasGoogle.CanDragMap = true;
            this.mapasGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapasGoogle.EmptyTileColor = System.Drawing.Color.Navy;
            this.mapasGoogle.GrayScaleMode = false;
            this.mapasGoogle.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mapasGoogle.LevelsKeepInMemmory = 5;
            this.mapasGoogle.Location = new System.Drawing.Point(0, 0);
            this.mapasGoogle.MarkersEnabled = true;
            this.mapasGoogle.MaxZoom = 2;
            this.mapasGoogle.MinZoom = 2;
            this.mapasGoogle.MouseWheelZoomEnabled = true;
            this.mapasGoogle.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mapasGoogle.Name = "mapasGoogle";
            this.mapasGoogle.NegativeMode = false;
            this.mapasGoogle.PolygonsEnabled = true;
            this.mapasGoogle.RetryLoadTile = 0;
            this.mapasGoogle.RoutesEnabled = true;
            this.mapasGoogle.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mapasGoogle.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mapasGoogle.ShowTileGridLines = false;
            this.mapasGoogle.Size = new System.Drawing.Size(627, 528);
            this.mapasGoogle.TabIndex = 2;
            this.mapasGoogle.Visible = false;
            this.mapasGoogle.Zoom = 0D;
            // 
            // Planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 528);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Planos";
            this.Text = "PUNTO DE INFORMACIÓN CES CRISTO REY";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPlano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonPlanta3;
        private System.Windows.Forms.Button buttonPlanta2;
        private System.Windows.Forms.Button buttonPlanta1;
        private System.Windows.Forms.PictureBox imagenPlano;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPapeleríasCercanas;
        private GMap.NET.WindowsForms.GMapControl mapasGoogle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}