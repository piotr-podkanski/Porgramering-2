namespace RitProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlTop = new Panel();
            lblName = new Label();
            btnExit = new Button();
            pnlR = new Panel();
            pxbColor = new PictureBox();
            pxbSave = new PictureBox();
            nudSize = new NumericUpDown();
            pxbTrash = new PictureBox();
            pxbSpray = new PictureBox();
            pxbBucket = new PictureBox();
            pxbErazer = new PictureBox();
            pxbBrush = new PictureBox();
            pxbCanvas = new PictureBox();
            pnlTop.SuspendLayout();
            pnlR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pxbColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbSpray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbBucket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbErazer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbBrush).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbCanvas).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Fuchsia;
            pnlTop.Controls.Add(lblName);
            pnlTop.Controls.Add(btnExit);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(900, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(164, 45);
            lblName.TabIndex = 5;
            lblName.Text = "Paint 2.0";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(840, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlR
            // 
            pnlR.BackColor = Color.FromArgb(255, 128, 255);
            pnlR.Controls.Add(pxbColor);
            pnlR.Controls.Add(pxbSave);
            pnlR.Controls.Add(nudSize);
            pnlR.Controls.Add(pxbTrash);
            pnlR.Controls.Add(pxbSpray);
            pnlR.Controls.Add(pxbBucket);
            pnlR.Controls.Add(pxbErazer);
            pnlR.Controls.Add(pxbBrush);
            pnlR.Dock = DockStyle.Right;
            pnlR.Location = new Point(830, 60);
            pnlR.Name = "pnlR";
            pnlR.Size = new Size(70, 640);
            pnlR.TabIndex = 1;
            // 
            // pxbColor
            // 
            pxbColor.BackColor = Color.Black;
            pxbColor.Location = new Point(10, 269);
            pxbColor.Name = "pxbColor";
            pxbColor.Size = new Size(50, 50);
            pxbColor.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbColor.TabIndex = 8;
            pxbColor.TabStop = false;
            // 
            // pxbSave
            // 
            pxbSave.BackColor = Color.White;
            pxbSave.BorderStyle = BorderStyle.Fixed3D;
            pxbSave.Image = (Image)resources.GetObject("pxbSave.Image");
            pxbSave.Location = new Point(10, 564);
            pxbSave.Name = "pxbSave";
            pxbSave.Size = new Size(50, 50);
            pxbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbSave.TabIndex = 7;
            pxbSave.TabStop = false;
            // 
            // nudSize
            // 
            nudSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudSize.Location = new Point(10, 5);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(50, 33);
            nudSize.TabIndex = 6;
            // 
            // pxbTrash
            // 
            pxbTrash.BackColor = Color.White;
            pxbTrash.BorderStyle = BorderStyle.Fixed3D;
            pxbTrash.Image = (Image)resources.GetObject("pxbTrash.Image");
            pxbTrash.Location = new Point(10, 508);
            pxbTrash.Name = "pxbTrash";
            pxbTrash.Size = new Size(50, 50);
            pxbTrash.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbTrash.TabIndex = 5;
            pxbTrash.TabStop = false;
            // 
            // pxbSpray
            // 
            pxbSpray.BackColor = Color.White;
            pxbSpray.BorderStyle = BorderStyle.Fixed3D;
            pxbSpray.Image = (Image)resources.GetObject("pxbSpray.Image");
            pxbSpray.Location = new Point(10, 213);
            pxbSpray.Name = "pxbSpray";
            pxbSpray.Size = new Size(50, 50);
            pxbSpray.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbSpray.TabIndex = 4;
            pxbSpray.TabStop = false;
            // 
            // pxbBucket
            // 
            pxbBucket.BackColor = Color.White;
            pxbBucket.BorderStyle = BorderStyle.Fixed3D;
            pxbBucket.Image = (Image)resources.GetObject("pxbBucket.Image");
            pxbBucket.Location = new Point(10, 157);
            pxbBucket.Name = "pxbBucket";
            pxbBucket.Size = new Size(50, 50);
            pxbBucket.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbBucket.TabIndex = 3;
            pxbBucket.TabStop = false;
            // 
            // pxbErazer
            // 
            pxbErazer.BackColor = Color.White;
            pxbErazer.BorderStyle = BorderStyle.Fixed3D;
            pxbErazer.Image = (Image)resources.GetObject("pxbErazer.Image");
            pxbErazer.Location = new Point(10, 101);
            pxbErazer.Name = "pxbErazer";
            pxbErazer.Size = new Size(50, 50);
            pxbErazer.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbErazer.TabIndex = 2;
            pxbErazer.TabStop = false;
            // 
            // pxbBrush
            // 
            pxbBrush.BackColor = Color.Silver;
            pxbBrush.BorderStyle = BorderStyle.Fixed3D;
            pxbBrush.Image = (Image)resources.GetObject("pxbBrush.Image");
            pxbBrush.Location = new Point(10, 45);
            pxbBrush.Name = "pxbBrush";
            pxbBrush.Size = new Size(50, 50);
            pxbBrush.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbBrush.TabIndex = 1;
            pxbBrush.TabStop = false;
            // 
            // pxbCanvas
            // 
            pxbCanvas.BackColor = Color.Silver;
            pxbCanvas.Location = new Point(0, 60);
            pxbCanvas.Name = "pxbCanvas";
            pxbCanvas.Size = new Size(830, 640);
            pxbCanvas.TabIndex = 2;
            pxbCanvas.TabStop = false;
            pxbCanvas.MouseDown += pxbCanvas_MouseDown;
            pxbCanvas.MouseMove += pxbCanvas_MouseMove;
            pxbCanvas.MouseUp += pxbCanvas_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            Controls.Add(pxbCanvas);
            Controls.Add(pnlR);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Paint 2.0";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pxbColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbSpray).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbBucket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbErazer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbBrush).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlR;
        private PictureBox pxbErazer;
        private PictureBox pxbBrush;
        private Button btnExit;
        private PictureBox pxbBucket;
        private PictureBox pxbSpray;
        private Label lblName;
        private PictureBox pxbTrash;
        private NumericUpDown nudSize;
        private PictureBox pxbSave;
        private PictureBox pxbColor;
        private PictureBox pxbCanvas;
    }
}