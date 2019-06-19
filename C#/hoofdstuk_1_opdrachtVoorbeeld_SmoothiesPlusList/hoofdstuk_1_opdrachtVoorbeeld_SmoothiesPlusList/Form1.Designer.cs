namespace hoofdstuk_1_opdrachtVoorbeeld_SmoothiesPlus
{
    partial class Form1
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
            this.btnZoek = new System.Windows.Forms.Button();
            this.btnWisSelectie = new System.Windows.Forms.Button();
            this.btnDefaultLijst = new System.Windows.Forms.Button();
            this.btnWisIngrediënt = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtIngrediënt = new System.Windows.Forms.TextBox();
            this.livIngrediënt = new System.Windows.Forms.ListView();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtLandVanHerkomst = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnKleurIngrediënt = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtCalorieën = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtPrijsPerKilo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZoek
            // 
            this.btnZoek.BackColor = System.Drawing.SystemColors.Control;
            this.btnZoek.Location = new System.Drawing.Point(17, 128);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(95, 29);
            this.btnZoek.TabIndex = 0;
            this.btnZoek.Text = "Zoek in lijst";
            this.btnZoek.UseVisualStyleBackColor = false;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // btnWisSelectie
            // 
            this.btnWisSelectie.BackColor = System.Drawing.SystemColors.Control;
            this.btnWisSelectie.Location = new System.Drawing.Point(17, 163);
            this.btnWisSelectie.Name = "btnWisSelectie";
            this.btnWisSelectie.Size = new System.Drawing.Size(95, 73);
            this.btnWisSelectie.TabIndex = 1;
            this.btnWisSelectie.Text = "Selectie ongedaan maken";
            this.btnWisSelectie.UseVisualStyleBackColor = false;
            this.btnWisSelectie.Click += new System.EventHandler(this.btnWisSelectie_Click);
            // 
            // btnDefaultLijst
            // 
            this.btnDefaultLijst.Location = new System.Drawing.Point(17, 299);
            this.btnDefaultLijst.Name = "btnDefaultLijst";
            this.btnDefaultLijst.Size = new System.Drawing.Size(95, 36);
            this.btnDefaultLijst.TabIndex = 3;
            this.btnDefaultLijst.Text = "Default lijst";
            this.btnDefaultLijst.UseVisualStyleBackColor = true;
            this.btnDefaultLijst.Click += new System.EventHandler(this.btnDefaultLijst_Click);
            // 
            // btnWisIngrediënt
            // 
            this.btnWisIngrediënt.Location = new System.Drawing.Point(17, 242);
            this.btnWisIngrediënt.Name = "btnWisIngrediënt";
            this.btnWisIngrediënt.Size = new System.Drawing.Size(95, 51);
            this.btnWisIngrediënt.TabIndex = 2;
            this.btnWisIngrediënt.Text = "Wis ingrediënt";
            this.btnWisIngrediënt.UseVisualStyleBackColor = true;
            this.btnWisIngrediënt.Click += new System.EventHandler(this.btnWisIngrediënt_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Einde";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(75, 17);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Ingrediënt:";
            // 
            // txtIngrediënt
            // 
            this.txtIngrediënt.Location = new System.Drawing.Point(128, 26);
            this.txtIngrediënt.Name = "txtIngrediënt";
            this.txtIngrediënt.Size = new System.Drawing.Size(169, 22);
            this.txtIngrediënt.TabIndex = 6;
            this.txtIngrediënt.TextChanged += new System.EventHandler(this.txtIngrediënt_TextChanged);
            // 
            // livIngrediënt
            // 
            this.livIngrediënt.Location = new System.Drawing.Point(128, 122);
            this.livIngrediënt.Name = "livIngrediënt";
            this.livIngrediënt.Size = new System.Drawing.Size(630, 324);
            this.livIngrediënt.TabIndex = 7;
            this.livIngrediënt.UseCompatibleStateImageBehavior = false;
            this.livIngrediënt.View = System.Windows.Forms.View.Details;
            this.livIngrediënt.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.livIngrediënt_DrawColumnHeader);
            this.livIngrediënt.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.livIngrediënt_DrawSubItem);
            this.livIngrediënt.Click += new System.EventHandler(this.livIngrediënt_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(125, 71);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(45, 17);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Kleur:";
            // 
            // txtLandVanHerkomst
            // 
            this.txtLandVanHerkomst.Location = new System.Drawing.Point(440, 26);
            this.txtLandVanHerkomst.Name = "txtLandVanHerkomst";
            this.txtLandVanHerkomst.Size = new System.Drawing.Size(169, 22);
            this.txtLandVanHerkomst.TabIndex = 9;
            this.txtLandVanHerkomst.TextChanged += new System.EventHandler(this.txtLandVanHerkomst_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(301, 26);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(133, 17);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Land van herkomst:";
            // 
            // btnKleurIngrediënt
            // 
            this.btnKleurIngrediënt.BackColor = System.Drawing.SystemColors.Control;
            this.btnKleurIngrediënt.Location = new System.Drawing.Point(176, 65);
            this.btnKleurIngrediënt.Name = "btnKleurIngrediënt";
            this.btnKleurIngrediënt.Size = new System.Drawing.Size(95, 29);
            this.btnKleurIngrediënt.TabIndex = 11;
            this.btnKleurIngrediënt.UseVisualStyleBackColor = false;
            this.btnKleurIngrediënt.TextChanged += new System.EventHandler(this.btnKleurIngrediënt_TextChanged);
            this.btnKleurIngrediënt.Click += new System.EventHandler(this.btnKleurIngrediënt_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(285, 72);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(114, 17);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "Aantal calorieën:";
            // 
            // txtCalorieën
            // 
            this.txtCalorieën.Location = new System.Drawing.Point(401, 72);
            this.txtCalorieën.Name = "txtCalorieën";
            this.txtCalorieën.Size = new System.Drawing.Size(83, 22);
            this.txtCalorieën.TabIndex = 12;
            this.txtCalorieën.TextChanged += new System.EventHandler(this.txtCalorieën_TextChanged);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(491, 72);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(89, 17);
            this.lbl5.TabIndex = 15;
            this.lbl5.Text = "Prijs per kilo:";
            // 
            // txtPrijsPerKilo
            // 
            this.txtPrijsPerKilo.Location = new System.Drawing.Point(607, 72);
            this.txtPrijsPerKilo.Name = "txtPrijsPerKilo";
            this.txtPrijsPerKilo.Size = new System.Drawing.Size(83, 22);
            this.txtPrijsPerKilo.TabIndex = 14;
            this.txtPrijsPerKilo.TextChanged += new System.EventHandler(this.txtPrijsPerKilo_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtPrijsPerKilo);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtCalorieën);
            this.Controls.Add(this.btnKleurIngrediënt);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtLandVanHerkomst);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.livIngrediënt);
            this.Controls.Add(this.txtIngrediënt);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefaultLijst);
            this.Controls.Add(this.btnWisIngrediënt);
            this.Controls.Add(this.btnWisSelectie);
            this.Controls.Add(this.btnZoek);
            this.Name = "Form1";
            this.Text = "frmSmoothiesPlus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Button btnWisSelectie;
        private System.Windows.Forms.Button btnDefaultLijst;
        private System.Windows.Forms.Button btnWisIngrediënt;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtIngrediënt;
        private System.Windows.Forms.ListView livIngrediënt;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtLandVanHerkomst;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnKleurIngrediënt;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtCalorieën;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox txtPrijsPerKilo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

