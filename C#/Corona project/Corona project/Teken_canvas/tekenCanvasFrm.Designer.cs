namespace Corona_project
{
    partial class tekenCanvasFrm
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
            this.canvasPicBox = new System.Windows.Forms.PictureBox();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.btnWissen = new System.Windows.Forms.Button();
            this.brushSize = new System.Windows.Forms.NumericUpDown();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.currentColorBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // canvasPicBox
            // 
            this.canvasPicBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.canvasPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPicBox.BackColor = System.Drawing.Color.White;
            this.canvasPicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPicBox.Location = new System.Drawing.Point(157, 7);
            this.canvasPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvasPicBox.Name = "canvasPicBox";
            this.canvasPicBox.Size = new System.Drawing.Size(630, 436);
            this.canvasPicBox.TabIndex = 0;
            this.canvasPicBox.TabStop = false;
            this.canvasPicBox.SizeChanged += new System.EventHandler(this.canvasPicBox_SizeChanged);
            this.canvasPicBox.Click += new System.EventHandler(this.canvasPicBox_Click);
            this.canvasPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPicBox_Paint);
            this.canvasPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPicBox_MouseDown);
            this.canvasPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPicBox_MouseMove);
            this.canvasPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPicBox_MouseUp);
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(15, 14);
            this.btnPickColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(105, 30);
            this.btnPickColor.TabIndex = 22;
            this.btnPickColor.Text = "Kies kleur";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.FullOpen = true;
            // 
            // btnWissen
            // 
            this.btnWissen.Location = new System.Drawing.Point(15, 49);
            this.btnWissen.Margin = new System.Windows.Forms.Padding(4);
            this.btnWissen.Name = "btnWissen";
            this.btnWissen.Size = new System.Drawing.Size(100, 28);
            this.btnWissen.TabIndex = 23;
            this.btnWissen.Text = "wissen";
            this.btnWissen.UseVisualStyleBackColor = true;
            this.btnWissen.Click += new System.EventHandler(this.btnWissen_Click);
            // 
            // brushSize
            // 
            this.brushSize.Location = new System.Drawing.Point(15, 85);
            this.brushSize.Margin = new System.Windows.Forms.Padding(4);
            this.brushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(85, 22);
            this.brushSize.TabIndex = 24;
            this.brushSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(15, 208);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(85, 28);
            this.btnEraser.TabIndex = 25;
            this.btnEraser.Text = "gum";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPen
            // 
            this.btnPen.Location = new System.Drawing.Point(15, 174);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(85, 28);
            this.btnPen.TabIndex = 26;
            this.btnPen.Text = "pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // currentColorBox
            // 
            this.currentColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColorBox.Location = new System.Drawing.Point(122, 14);
            this.currentColorBox.Name = "currentColorBox";
            this.currentColorBox.Size = new System.Drawing.Size(30, 30);
            this.currentColorBox.TabIndex = 27;
            this.currentColorBox.TabStop = false;
            // 
            // tekenCanvasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 458);
            this.Controls.Add(this.currentColorBox);
            this.Controls.Add(this.btnPen);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.brushSize);
            this.Controls.Add(this.btnWissen);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.canvasPicBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(818, 495);
            this.Name = "tekenCanvasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.tekenCanvasFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canvasPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvasPicBox;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Button btnWissen;
        private System.Windows.Forms.NumericUpDown brushSize;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.PictureBox currentColorBox;
    }
}