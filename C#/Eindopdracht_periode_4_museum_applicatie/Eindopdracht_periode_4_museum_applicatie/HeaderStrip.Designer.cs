namespace Eindopdracht_periode_4_museum_applicatie
{
    partial class HeaderStrip
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMaxNorm = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaxNorm
            // 
            this.btnMaxNorm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaxNorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxNorm.Location = new System.Drawing.Point(749, 0);
            this.btnMaxNorm.Name = "btnMaxNorm";
            this.btnMaxNorm.Size = new System.Drawing.Size(30, 35);
            this.btnMaxNorm.TabIndex = 5;
            this.btnMaxNorm.Text = "+";
            this.btnMaxNorm.UseVisualStyleBackColor = true;
            this.btnMaxNorm.Click += new System.EventHandler(this.btnMaxNorm_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(719, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 35);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(779, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HeaderStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(133)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMaxNorm);
            this.Controls.Add(this.btnClose);
            this.Name = "HeaderStrip";
            this.Size = new System.Drawing.Size(809, 35);
            this.Load += new System.EventHandler(this.HeaderStrip_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderStrip_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderStrip_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderStrip_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaxNorm;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
    }
}
