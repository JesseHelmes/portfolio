namespace toetsPeriode2_opdracht_2
{
    partial class Frm1
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
            this.lblBouwjaar = new System.Windows.Forms.Label();
            this.lblMerk = new System.Windows.Forms.Label();
            this.lblWaarde = new System.Windows.Forms.Label();
            this.btnBerekenWaarde = new System.Windows.Forms.Button();
            this.txtBouwjaar = new System.Windows.Forms.TextBox();
            this.txtMerk = new System.Windows.Forms.TextBox();
            this.picbAuto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBouwjaar
            // 
            this.lblBouwjaar.AutoSize = true;
            this.lblBouwjaar.Location = new System.Drawing.Point(89, 53);
            this.lblBouwjaar.Name = "lblBouwjaar";
            this.lblBouwjaar.Size = new System.Drawing.Size(66, 17);
            this.lblBouwjaar.TabIndex = 0;
            this.lblBouwjaar.Text = "Bouwjaar";
            // 
            // lblMerk
            // 
            this.lblMerk.AutoSize = true;
            this.lblMerk.Location = new System.Drawing.Point(116, 112);
            this.lblMerk.Name = "lblMerk";
            this.lblMerk.Size = new System.Drawing.Size(39, 17);
            this.lblMerk.TabIndex = 1;
            this.lblMerk.Text = "Merk";
            // 
            // lblWaarde
            // 
            this.lblWaarde.AutoSize = true;
            this.lblWaarde.Location = new System.Drawing.Point(177, 168);
            this.lblWaarde.Name = "lblWaarde";
            this.lblWaarde.Size = new System.Drawing.Size(16, 17);
            this.lblWaarde.TabIndex = 2;
            this.lblWaarde.Text = "0";
            // 
            // btnBerekenWaarde
            // 
            this.btnBerekenWaarde.Location = new System.Drawing.Point(27, 165);
            this.btnBerekenWaarde.Name = "btnBerekenWaarde";
            this.btnBerekenWaarde.Size = new System.Drawing.Size(128, 23);
            this.btnBerekenWaarde.TabIndex = 3;
            this.btnBerekenWaarde.Text = "Bereken Waarde";
            this.btnBerekenWaarde.UseVisualStyleBackColor = true;
            this.btnBerekenWaarde.Click += new System.EventHandler(this.btnBerekenWaarde_Click);
            // 
            // txtBouwjaar
            // 
            this.txtBouwjaar.Location = new System.Drawing.Point(180, 53);
            this.txtBouwjaar.Name = "txtBouwjaar";
            this.txtBouwjaar.Size = new System.Drawing.Size(100, 22);
            this.txtBouwjaar.TabIndex = 4;
            // 
            // txtMerk
            // 
            this.txtMerk.Location = new System.Drawing.Point(180, 112);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.Size = new System.Drawing.Size(100, 22);
            this.txtMerk.TabIndex = 5;
            // 
            // picbAuto
            // 
            this.picbAuto.BackColor = System.Drawing.SystemColors.Control;
            this.picbAuto.Location = new System.Drawing.Point(249, 198);
            this.picbAuto.Name = "picbAuto";
            this.picbAuto.Size = new System.Drawing.Size(470, 226);
            this.picbAuto.TabIndex = 6;
            this.picbAuto.TabStop = false;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 427);
            this.Controls.Add(this.picbAuto);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtBouwjaar);
            this.Controls.Add(this.btnBerekenWaarde);
            this.Controls.Add(this.lblWaarde);
            this.Controls.Add(this.lblMerk);
            this.Controls.Add(this.lblBouwjaar);
            this.Name = "Frm1";
            this.Text = "Opdracht 2";
            ((System.ComponentModel.ISupportInitialize)(this.picbAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBouwjaar;
        private System.Windows.Forms.Label lblMerk;
        private System.Windows.Forms.Label lblWaarde;
        private System.Windows.Forms.Button btnBerekenWaarde;
        private System.Windows.Forms.TextBox txtBouwjaar;
        private System.Windows.Forms.TextBox txtMerk;
        private System.Windows.Forms.PictureBox picbAuto;
    }
}

