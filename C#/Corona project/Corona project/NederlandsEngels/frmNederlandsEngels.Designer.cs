namespace NederlandsEnEngels
{
    partial class frmNederlandsEngels
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
            this.lblTaalModus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblVragen = new System.Windows.Forms.Label();
            this.antwoordenFlowPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAntwoord1 = new System.Windows.Forms.Button();
            this.btnAntwoord2 = new System.Windows.Forms.Button();
            this.btnAntwoord3 = new System.Windows.Forms.Button();
            this.btnAntwoord4 = new System.Windows.Forms.Button();
            this.antwoordenFlowPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTaalModus
            // 
            this.lblTaalModus.BackColor = System.Drawing.Color.SeaShell;
            this.lblTaalModus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaalModus.Location = new System.Drawing.Point(190, 12);
            this.lblTaalModus.Name = "lblTaalModus";
            this.lblTaalModus.Size = new System.Drawing.Size(420, 31);
            this.lblTaalModus.TabIndex = 0;
            this.lblTaalModus.Text = "Taal";
            this.lblTaalModus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.SystemColors.Control;
            this.lblProgress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblProgress.Location = new System.Drawing.Point(743, 9);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.MinimumSize = new System.Drawing.Size(40, 18);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(40, 18);
            this.lblProgress.TabIndex = 6;
            this.lblProgress.Text = "0/1";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVragen
            // 
            this.lblVragen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVragen.AutoSize = true;
            this.lblVragen.BackColor = System.Drawing.SystemColors.Menu;
            this.lblVragen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVragen.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblVragen.Location = new System.Drawing.Point(200, 148);
            this.lblVragen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVragen.MaximumSize = new System.Drawing.Size(410, 50);
            this.lblVragen.MinimumSize = new System.Drawing.Size(410, 50);
            this.lblVragen.Name = "lblVragen";
            this.lblVragen.Size = new System.Drawing.Size(410, 50);
            this.lblVragen.TabIndex = 5;
            this.lblVragen.Text = "dit is de vraag";
            this.lblVragen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // antwoordenFlowPnl
            // 
            this.antwoordenFlowPnl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.antwoordenFlowPnl.Controls.Add(this.btnAntwoord1);
            this.antwoordenFlowPnl.Controls.Add(this.btnAntwoord2);
            this.antwoordenFlowPnl.Controls.Add(this.btnAntwoord3);
            this.antwoordenFlowPnl.Controls.Add(this.btnAntwoord4);
            this.antwoordenFlowPnl.Location = new System.Drawing.Point(12, 211);
            this.antwoordenFlowPnl.Name = "antwoordenFlowPnl";
            this.antwoordenFlowPnl.Size = new System.Drawing.Size(776, 162);
            this.antwoordenFlowPnl.TabIndex = 7;
            // 
            // btnAntwoord1
            // 
            this.btnAntwoord1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntwoord1.Location = new System.Drawing.Point(3, 3);
            this.btnAntwoord1.Name = "btnAntwoord1";
            this.btnAntwoord1.Size = new System.Drawing.Size(381, 75);
            this.btnAntwoord1.TabIndex = 0;
            this.btnAntwoord1.TabStop = false;
            this.btnAntwoord1.Text = "antwoord1";
            this.btnAntwoord1.UseVisualStyleBackColor = true;
            this.btnAntwoord1.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // btnAntwoord2
            // 
            this.btnAntwoord2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntwoord2.Location = new System.Drawing.Point(390, 3);
            this.btnAntwoord2.Name = "btnAntwoord2";
            this.btnAntwoord2.Size = new System.Drawing.Size(381, 75);
            this.btnAntwoord2.TabIndex = 1;
            this.btnAntwoord2.TabStop = false;
            this.btnAntwoord2.Text = "antwoord2";
            this.btnAntwoord2.UseVisualStyleBackColor = true;
            this.btnAntwoord2.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // btnAntwoord3
            // 
            this.btnAntwoord3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntwoord3.Location = new System.Drawing.Point(3, 84);
            this.btnAntwoord3.Name = "btnAntwoord3";
            this.btnAntwoord3.Size = new System.Drawing.Size(381, 75);
            this.btnAntwoord3.TabIndex = 2;
            this.btnAntwoord3.TabStop = false;
            this.btnAntwoord3.Text = "antwoord3";
            this.btnAntwoord3.UseVisualStyleBackColor = true;
            this.btnAntwoord3.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // btnAntwoord4
            // 
            this.btnAntwoord4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAntwoord4.Location = new System.Drawing.Point(390, 84);
            this.btnAntwoord4.Name = "btnAntwoord4";
            this.btnAntwoord4.Size = new System.Drawing.Size(381, 75);
            this.btnAntwoord4.TabIndex = 3;
            this.btnAntwoord4.TabStop = false;
            this.btnAntwoord4.Text = "antwoord4";
            this.btnAntwoord4.UseVisualStyleBackColor = true;
            this.btnAntwoord4.Click += new System.EventHandler(this.controlleerAntwoord);
            // 
            // frmNederlandsEngels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.antwoordenFlowPnl);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblVragen);
            this.Controls.Add(this.lblTaalModus);
            this.Name = "frmNederlandsEngels";
            this.Text = "NederlandsEngels";
            this.Load += new System.EventHandler(this.frmNederlandsEngels_Load);
            this.antwoordenFlowPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaalModus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblVragen;
        private System.Windows.Forms.FlowLayoutPanel antwoordenFlowPnl;
        private System.Windows.Forms.Button btnAntwoord1;
        private System.Windows.Forms.Button btnAntwoord2;
        private System.Windows.Forms.Button btnAntwoord3;
        private System.Windows.Forms.Button btnAntwoord4;
    }
}