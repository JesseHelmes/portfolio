namespace Corona_project
{
    partial class frmMain
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
            this.btnRekenSpel = new System.Windows.Forms.Button();
            this.btnTopoSpel = new System.Windows.Forms.Button();
            this.btnNederlandsEngelsSpel = new System.Windows.Forms.Button();
            this.btnTekenCanvas = new System.Windows.Forms.Button();
            this.btnVerkeerSpel = new System.Windows.Forms.Button();
            this.pnlAgenda = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRekenSpel
            // 
            this.btnRekenSpel.Location = new System.Drawing.Point(10, 394);
            this.btnRekenSpel.Name = "btnRekenSpel";
            this.btnRekenSpel.Size = new System.Drawing.Size(122, 44);
            this.btnRekenSpel.TabIndex = 0;
            this.btnRekenSpel.Text = "Rekenen";
            this.btnRekenSpel.UseVisualStyleBackColor = true;
            this.btnRekenSpel.Click += new System.EventHandler(this.btnRekenSpel_Click);
            // 
            // btnTopoSpel
            // 
            this.btnTopoSpel.Location = new System.Drawing.Point(160, 394);
            this.btnTopoSpel.Name = "btnTopoSpel";
            this.btnTopoSpel.Size = new System.Drawing.Size(122, 44);
            this.btnTopoSpel.TabIndex = 1;
            this.btnTopoSpel.Text = "Topografie";
            this.btnTopoSpel.UseVisualStyleBackColor = true;
            this.btnTopoSpel.Click += new System.EventHandler(this.btnTopoSpel_Click);
            // 
            // btnNederlandsEngelsSpel
            // 
            this.btnNederlandsEngelsSpel.Location = new System.Drawing.Point(310, 394);
            this.btnNederlandsEngelsSpel.Name = "btnNederlandsEngelsSpel";
            this.btnNederlandsEngelsSpel.Size = new System.Drawing.Size(122, 44);
            this.btnNederlandsEngelsSpel.TabIndex = 2;
            this.btnNederlandsEngelsSpel.Text = "Nederlands en Engels";
            this.btnNederlandsEngelsSpel.UseVisualStyleBackColor = true;
            this.btnNederlandsEngelsSpel.Click += new System.EventHandler(this.btnNederlandsEngelsSpel_Click);
            // 
            // btnTekenCanvas
            // 
            this.btnTekenCanvas.Location = new System.Drawing.Point(460, 394);
            this.btnTekenCanvas.Name = "btnTekenCanvas";
            this.btnTekenCanvas.Size = new System.Drawing.Size(122, 44);
            this.btnTekenCanvas.TabIndex = 3;
            this.btnTekenCanvas.Text = "Tekenen";
            this.btnTekenCanvas.UseVisualStyleBackColor = true;
            this.btnTekenCanvas.Click += new System.EventHandler(this.btnTekenCanvas_Click);
            // 
            // btnVerkeerSpel
            // 
            this.btnVerkeerSpel.Location = new System.Drawing.Point(610, 394);
            this.btnVerkeerSpel.Name = "btnVerkeerSpel";
            this.btnVerkeerSpel.Size = new System.Drawing.Size(122, 44);
            this.btnVerkeerSpel.TabIndex = 4;
            this.btnVerkeerSpel.Text = "Verkeer";
            this.btnVerkeerSpel.UseVisualStyleBackColor = true;
            this.btnVerkeerSpel.Click += new System.EventHandler(this.btnVerkeerSpel_Click);
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.BackColor = System.Drawing.Color.Linen;
            this.pnlAgenda.Controls.Add(this.label1);
            this.pnlAgenda.Location = new System.Drawing.Point(12, 12);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.Size = new System.Drawing.Size(720, 362);
            this.pnlAgenda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda in deze panel";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.pnlAgenda);
            this.Controls.Add(this.btnVerkeerSpel);
            this.Controls.Add(this.btnTekenCanvas);
            this.Controls.Add(this.btnNederlandsEngelsSpel);
            this.Controls.Add(this.btnTopoSpel);
            this.Controls.Add(this.btnRekenSpel);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basisschool Corona Applicatie";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlAgenda.ResumeLayout(false);
            this.pnlAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRekenSpel;
        private System.Windows.Forms.Button btnTopoSpel;
        private System.Windows.Forms.Button btnNederlandsEngelsSpel;
        private System.Windows.Forms.Button btnTekenCanvas;
        private System.Windows.Forms.Button btnVerkeerSpel;
        private System.Windows.Forms.Panel pnlAgenda;
        private System.Windows.Forms.Label label1;
    }
}

