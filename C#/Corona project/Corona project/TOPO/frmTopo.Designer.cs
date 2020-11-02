namespace Corona_project
{
    partial class frmTopo
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
            this.lbxAnswer = new System.Windows.Forms.ListBox();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.lblMaxPoints = new System.Windows.Forms.Label();
            this.lblClickOp = new System.Windows.Forms.Label();
            this.pcbMap = new System.Windows.Forms.PictureBox();
            this.btnGelderland = new System.Windows.Forms.Button();
            this.btnUtrecht = new System.Windows.Forms.Button();
            this.btnZuidHolland = new System.Windows.Forms.Button();
            this.btnNoordBrabant = new System.Windows.Forms.Button();
            this.btnLimburg = new System.Windows.Forms.Button();
            this.btnFelevoland = new System.Windows.Forms.Button();
            this.btnOverijsel = new System.Windows.Forms.Button();
            this.btnNoordHolland = new System.Windows.Forms.Button();
            this.btnZeeland = new System.Windows.Forms.Button();
            this.btnFriesland = new System.Windows.Forms.Button();
            this.btnDrenthe = new System.Windows.Forms.Button();
            this.btnGroningen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxAnswer
            // 
            this.lbxAnswer.FormattingEnabled = true;
            this.lbxAnswer.Location = new System.Drawing.Point(706, 334);
            this.lbxAnswer.Name = "lbxAnswer";
            this.lbxAnswer.Size = new System.Drawing.Size(55, 17);
            this.lbxAnswer.TabIndex = 999;
            this.lbxAnswer.TabStop = false;
            this.lbxAnswer.Visible = false;
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(42, 114);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(37, 13);
            this.lblProvince.TabIndex = 1000;
            this.lblProvince.Text = "lblFind";
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Location = new System.Drawing.Point(26, 12);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentPoints.TabIndex = 1001;
            this.lblCurrentPoints.Text = "12";
            // 
            // lblMaxPoints
            // 
            this.lblMaxPoints.AutoSize = true;
            this.lblMaxPoints.Location = new System.Drawing.Point(42, 12);
            this.lblMaxPoints.Name = "lblMaxPoints";
            this.lblMaxPoints.Size = new System.Drawing.Size(27, 13);
            this.lblMaxPoints.TabIndex = 1002;
            this.lblMaxPoints.Text = "/ 12";
            // 
            // lblClickOp
            // 
            this.lblClickOp.AutoSize = true;
            this.lblClickOp.Location = new System.Drawing.Point(21, 95);
            this.lblClickOp.Name = "lblClickOp";
            this.lblClickOp.Size = new System.Drawing.Size(48, 13);
            this.lblClickOp.TabIndex = 1003;
            this.lblClickOp.Text = "Click op:";
            // 
            // pcbMap
            // 
            this.pcbMap.BackColor = System.Drawing.Color.Transparent;
            this.pcbMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbMap.Image = global::Corona_project.Properties.Resources.knp;
            this.pcbMap.Location = new System.Drawing.Point(109, 12);
            this.pcbMap.Name = "pcbMap";
            this.pcbMap.Size = new System.Drawing.Size(667, 788);
            this.pcbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMap.TabIndex = 0;
            this.pcbMap.TabStop = false;
            // 
            // btnGelderland
            // 
            this.btnGelderland.BackColor = System.Drawing.Color.Transparent;
            this.btnGelderland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.btnGelderland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelderland.Location = new System.Drawing.Point(534, 413);
            this.btnGelderland.Name = "btnGelderland";
            this.btnGelderland.Size = new System.Drawing.Size(72, 27);
            this.btnGelderland.TabIndex = 1004;
            this.btnGelderland.UseVisualStyleBackColor = false;
            this.btnGelderland.Click += new System.EventHandler(this.btnGelderland_Click);
            // 
            // btnUtrecht
            // 
            this.btnUtrecht.BackColor = System.Drawing.Color.Transparent;
            this.btnUtrecht.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(209)))), ((int)(((byte)(96)))));
            this.btnUtrecht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtrecht.Location = new System.Drawing.Point(397, 402);
            this.btnUtrecht.Name = "btnUtrecht";
            this.btnUtrecht.Size = new System.Drawing.Size(72, 27);
            this.btnUtrecht.TabIndex = 1005;
            this.btnUtrecht.UseVisualStyleBackColor = false;
            this.btnUtrecht.Click += new System.EventHandler(this.btnUtrecht_Click);
            // 
            // btnZuidHolland
            // 
            this.btnZuidHolland.BackColor = System.Drawing.Color.Transparent;
            this.btnZuidHolland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(13)))), ((int)(((byte)(182)))));
            this.btnZuidHolland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZuidHolland.Location = new System.Drawing.Point(289, 437);
            this.btnZuidHolland.Name = "btnZuidHolland";
            this.btnZuidHolland.Size = new System.Drawing.Size(72, 27);
            this.btnZuidHolland.TabIndex = 1006;
            this.btnZuidHolland.UseVisualStyleBackColor = false;
            this.btnZuidHolland.Click += new System.EventHandler(this.btnZuidHolland_Click);
            // 
            // btnNoordBrabant
            // 
            this.btnNoordBrabant.BackColor = System.Drawing.Color.Transparent;
            this.btnNoordBrabant.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(19)))), ((int)(((byte)(144)))));
            this.btnNoordBrabant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoordBrabant.Location = new System.Drawing.Point(413, 538);
            this.btnNoordBrabant.Name = "btnNoordBrabant";
            this.btnNoordBrabant.Size = new System.Drawing.Size(72, 27);
            this.btnNoordBrabant.TabIndex = 1007;
            this.btnNoordBrabant.UseVisualStyleBackColor = false;
            this.btnNoordBrabant.Click += new System.EventHandler(this.btnNoordBrabant_Click);
            // 
            // btnLimburg
            // 
            this.btnLimburg.BackColor = System.Drawing.Color.Transparent;
            this.btnLimburg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.btnLimburg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimburg.Location = new System.Drawing.Point(513, 629);
            this.btnLimburg.Name = "btnLimburg";
            this.btnLimburg.Size = new System.Drawing.Size(72, 27);
            this.btnLimburg.TabIndex = 1008;
            this.btnLimburg.UseVisualStyleBackColor = false;
            this.btnLimburg.Click += new System.EventHandler(this.btnLimburg_Click);
            // 
            // btnFelevoland
            // 
            this.btnFelevoland.BackColor = System.Drawing.Color.Transparent;
            this.btnFelevoland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(72)))), ((int)(((byte)(204)))));
            this.btnFelevoland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFelevoland.Location = new System.Drawing.Point(450, 313);
            this.btnFelevoland.Name = "btnFelevoland";
            this.btnFelevoland.Size = new System.Drawing.Size(72, 27);
            this.btnFelevoland.TabIndex = 1009;
            this.btnFelevoland.UseVisualStyleBackColor = false;
            this.btnFelevoland.Click += new System.EventHandler(this.btnFelevoland_Click);
            // 
            // btnOverijsel
            // 
            this.btnOverijsel.BackColor = System.Drawing.Color.Transparent;
            this.btnOverijsel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.btnOverijsel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverijsel.Location = new System.Drawing.Point(605, 313);
            this.btnOverijsel.Name = "btnOverijsel";
            this.btnOverijsel.Size = new System.Drawing.Size(72, 27);
            this.btnOverijsel.TabIndex = 1010;
            this.btnOverijsel.UseVisualStyleBackColor = false;
            this.btnOverijsel.Click += new System.EventHandler(this.btnOverijsel_Click);
            // 
            // btnNoordHolland
            // 
            this.btnNoordHolland.BackColor = System.Drawing.Color.Transparent;
            this.btnNoordHolland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(169)))), ((int)(((byte)(6)))));
            this.btnNoordHolland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoordHolland.Location = new System.Drawing.Point(338, 295);
            this.btnNoordHolland.Name = "btnNoordHolland";
            this.btnNoordHolland.Size = new System.Drawing.Size(72, 27);
            this.btnNoordHolland.TabIndex = 1011;
            this.btnNoordHolland.UseVisualStyleBackColor = false;
            this.btnNoordHolland.Click += new System.EventHandler(this.btnNoordHolland_Click);
            // 
            // btnZeeland
            // 
            this.btnZeeland.BackColor = System.Drawing.Color.Transparent;
            this.btnZeeland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(122)))), ((int)(((byte)(190)))));
            this.btnZeeland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZeeland.Location = new System.Drawing.Point(160, 566);
            this.btnZeeland.Name = "btnZeeland";
            this.btnZeeland.Size = new System.Drawing.Size(72, 27);
            this.btnZeeland.TabIndex = 1012;
            this.btnZeeland.UseVisualStyleBackColor = false;
            this.btnZeeland.Click += new System.EventHandler(this.btnZeeland_Click);
            // 
            // btnFriesland
            // 
            this.btnFriesland.BackColor = System.Drawing.Color.Transparent;
            this.btnFriesland.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(122)))), ((int)(((byte)(86)))));
            this.btnFriesland.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriesland.Location = new System.Drawing.Point(503, 135);
            this.btnFriesland.Name = "btnFriesland";
            this.btnFriesland.Size = new System.Drawing.Size(72, 27);
            this.btnFriesland.TabIndex = 1013;
            this.btnFriesland.UseVisualStyleBackColor = true;
            this.btnFriesland.Click += new System.EventHandler(this.btnFriesland_Click);
            // 
            // btnDrenthe
            // 
            this.btnDrenthe.BackColor = System.Drawing.Color.Transparent;
            this.btnDrenthe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnDrenthe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrenthe.Location = new System.Drawing.Point(635, 208);
            this.btnDrenthe.Name = "btnDrenthe";
            this.btnDrenthe.Size = new System.Drawing.Size(72, 27);
            this.btnDrenthe.TabIndex = 1014;
            this.btnDrenthe.UseVisualStyleBackColor = false;
            this.btnDrenthe.Click += new System.EventHandler(this.btnDrenthe_Click);
            // 
            // btnGroningen
            // 
            this.btnGroningen.BackColor = System.Drawing.Color.Transparent;
            this.btnGroningen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(200)))));
            this.btnGroningen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroningen.Location = new System.Drawing.Point(635, 81);
            this.btnGroningen.Name = "btnGroningen";
            this.btnGroningen.Size = new System.Drawing.Size(72, 27);
            this.btnGroningen.TabIndex = 1015;
            this.btnGroningen.UseVisualStyleBackColor = false;
            this.btnGroningen.Click += new System.EventHandler(this.btnGroningen_Click);
            // 
            // frmTopo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 812);
            this.Controls.Add(this.btnGroningen);
            this.Controls.Add(this.btnDrenthe);
            this.Controls.Add(this.btnFriesland);
            this.Controls.Add(this.btnZeeland);
            this.Controls.Add(this.btnNoordHolland);
            this.Controls.Add(this.btnOverijsel);
            this.Controls.Add(this.btnFelevoland);
            this.Controls.Add(this.btnLimburg);
            this.Controls.Add(this.btnNoordBrabant);
            this.Controls.Add(this.btnZuidHolland);
            this.Controls.Add(this.btnUtrecht);
            this.Controls.Add(this.btnGelderland);
            this.Controls.Add(this.lblClickOp);
            this.Controls.Add(this.lblMaxPoints);
            this.Controls.Add(this.lblCurrentPoints);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.pcbMap);
            this.Controls.Add(this.lbxAnswer);
            this.DoubleBuffered = true;
            this.Name = "frmTopo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Topo";
            this.Load += new System.EventHandler(this.frmTopo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbxAnswer;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.Label lblMaxPoints;
        private System.Windows.Forms.Label lblClickOp;
        private System.Windows.Forms.PictureBox pcbMap;
        private System.Windows.Forms.Button btnGelderland;
        private System.Windows.Forms.Button btnUtrecht;
        private System.Windows.Forms.Button btnZuidHolland;
        private System.Windows.Forms.Button btnNoordBrabant;
        private System.Windows.Forms.Button btnLimburg;
        private System.Windows.Forms.Button btnFelevoland;
        private System.Windows.Forms.Button btnOverijsel;
        private System.Windows.Forms.Button btnNoordHolland;
        private System.Windows.Forms.Button btnZeeland;
        private System.Windows.Forms.Button btnFriesland;
        private System.Windows.Forms.Button btnDrenthe;
        private System.Windows.Forms.Button btnGroningen;
    }
}