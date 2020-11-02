namespace Corona_project
{
    partial class frmRekenspel
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
            this.getal1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rekenteken = new System.Windows.Forms.Label();
            this.getal2 = new System.Windows.Forms.Label();
            this.txtAntwoord = new System.Windows.Forms.TextBox();
            this.btnBeantwoord = new System.Windows.Forms.Button();
            this.lblVragen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getal1
            // 
            this.getal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getal1.Location = new System.Drawing.Point(12, 88);
            this.getal1.Name = "getal1";
            this.getal1.Size = new System.Drawing.Size(182, 135);
            this.getal1.TabIndex = 0;
            this.getal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rekenen";
            // 
            // rekenteken
            // 
            this.rekenteken.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rekenteken.Location = new System.Drawing.Point(200, 88);
            this.rekenteken.Name = "rekenteken";
            this.rekenteken.Size = new System.Drawing.Size(70, 135);
            this.rekenteken.TabIndex = 2;
            this.rekenteken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getal2
            // 
            this.getal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getal2.Location = new System.Drawing.Point(276, 88);
            this.getal2.Name = "getal2";
            this.getal2.Size = new System.Drawing.Size(182, 135);
            this.getal2.TabIndex = 3;
            this.getal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAntwoord
            // 
            this.txtAntwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAntwoord.Location = new System.Drawing.Point(21, 200);
            this.txtAntwoord.MaxLength = 4;
            this.txtAntwoord.Name = "txtAntwoord";
            this.txtAntwoord.Size = new System.Drawing.Size(178, 83);
            this.txtAntwoord.TabIndex = 4;
            this.txtAntwoord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAntwoord_KeyPress);
            // 
            // btnBeantwoord
            // 
            this.btnBeantwoord.Location = new System.Drawing.Point(21, 290);
            this.btnBeantwoord.Name = "btnBeantwoord";
            this.btnBeantwoord.Size = new System.Drawing.Size(138, 74);
            this.btnBeantwoord.TabIndex = 5;
            this.btnBeantwoord.Text = "Beantwoorden";
            this.btnBeantwoord.UseVisualStyleBackColor = true;
            this.btnBeantwoord.Click += new System.EventHandler(this.BtnBeantwoord_Click);
            // 
            // lblVragen
            // 
            this.lblVragen.AutoSize = true;
            this.lblVragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVragen.Location = new System.Drawing.Point(322, 13);
            this.lblVragen.Name = "lblVragen";
            this.lblVragen.Size = new System.Drawing.Size(136, 29);
            this.lblVragen.TabIndex = 6;
            this.lblVragen.Text = "Vraag 1/20";
            // 
            // frmRekenspel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.lblVragen);
            this.Controls.Add(this.btnBeantwoord);
            this.Controls.Add(this.txtAntwoord);
            this.Controls.Add(this.getal2);
            this.Controls.Add(this.rekenteken);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getal1);
            this.Name = "frmRekenspel";
            this.Text = "Rekenen";
            this.Load += new System.EventHandler(this.FrmRekenspel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label getal1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rekenteken;
        private System.Windows.Forms.Label getal2;
        private System.Windows.Forms.TextBox txtAntwoord;
        private System.Windows.Forms.Button btnBeantwoord;
        private System.Windows.Forms.Label lblVragen;
    }
}