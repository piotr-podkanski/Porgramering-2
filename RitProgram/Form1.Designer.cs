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
            pxbCurrent = new PictureBox();
            pxbOwnColor = new PictureBox();
            pxbBrown = new PictureBox();
            pxbOrange = new PictureBox();
            pxbDarkOrange = new PictureBox();
            pxbPurple = new PictureBox();
            pxbDarkPurple = new PictureBox();
            pxbYellow = new PictureBox();
            pxbDarkYellow = new PictureBox();
            pxbGreen = new PictureBox();
            pxbDarkGreen = new PictureBox();
            pxbBlue = new PictureBox();
            pxbDarkBlue = new PictureBox();
            pxbRed = new PictureBox();
            pxbDarkRed = new PictureBox();
            pxbWhite = new PictureBox();
            pxbBlack = new PictureBox();
            pxbSave = new PictureBox();
            nudSize = new NumericUpDown();
            pxbTrash = new PictureBox();
            pxbSpray = new PictureBox();
            pxbBucket = new PictureBox();
            pxbEraser = new PictureBox();
            pxbPencil = new PictureBox();
            pxbCanvas = new PictureBox();
            colorDialog1 = new ColorDialog();
            pnlTop.SuspendLayout();
            pnlR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pxbCurrent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbOwnColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbBrown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkOrange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbPurple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkPurple).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbBlack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbSpray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbBucket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbEraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pxbPencil).BeginInit();
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
            pnlTop.Size = new Size(1920, 60);
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
            btnExit.Location = new Point(1859, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlR
            // 
            pnlR.BackColor = Color.FromArgb(255, 128, 255);
            pnlR.Controls.Add(pxbCurrent);
            pnlR.Controls.Add(pxbOwnColor);
            pnlR.Controls.Add(pxbBrown);
            pnlR.Controls.Add(pxbOrange);
            pnlR.Controls.Add(pxbDarkOrange);
            pnlR.Controls.Add(pxbPurple);
            pnlR.Controls.Add(pxbDarkPurple);
            pnlR.Controls.Add(pxbYellow);
            pnlR.Controls.Add(pxbDarkYellow);
            pnlR.Controls.Add(pxbGreen);
            pnlR.Controls.Add(pxbDarkGreen);
            pnlR.Controls.Add(pxbBlue);
            pnlR.Controls.Add(pxbDarkBlue);
            pnlR.Controls.Add(pxbRed);
            pnlR.Controls.Add(pxbDarkRed);
            pnlR.Controls.Add(pxbWhite);
            pnlR.Controls.Add(pxbBlack);
            pnlR.Controls.Add(pxbSave);
            pnlR.Controls.Add(nudSize);
            pnlR.Controls.Add(pxbTrash);
            pnlR.Controls.Add(pxbSpray);
            pnlR.Controls.Add(pxbBucket);
            pnlR.Controls.Add(pxbEraser);
            pnlR.Controls.Add(pxbPencil);
            pnlR.Dock = DockStyle.Right;
            pnlR.Location = new Point(1790, 60);
            pnlR.Name = "pnlR";
            pnlR.Size = new Size(130, 1020);
            pnlR.TabIndex = 1;
            pnlR.Click += chooseColor;
            // 
            // pxbCurrent
            // 
            pxbCurrent.BackColor = Color.Black;
            pxbCurrent.Location = new Point(10, 157);
            pxbCurrent.Name = "pxbCurrent";
            pxbCurrent.Size = new Size(107, 104);
            pxbCurrent.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbCurrent.TabIndex = 25;
            pxbCurrent.TabStop = false;
            // 
            // pxbOwnColor
            // 
            pxbOwnColor.BackColor = Color.FromArgb(128, 64, 64);
            pxbOwnColor.Location = new Point(67, 657);
            pxbOwnColor.Name = "pxbOwnColor";
            pxbOwnColor.Size = new Size(50, 50);
            pxbOwnColor.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbOwnColor.TabIndex = 23;
            pxbOwnColor.TabStop = false;
            pxbOwnColor.Click += pxbOwnColor_Click;
            // 
            // pxbBrown
            // 
            pxbBrown.BackColor = Color.FromArgb(128, 64, 0);
            pxbBrown.Location = new Point(10, 657);
            pxbBrown.Name = "pxbBrown";
            pxbBrown.Size = new Size(50, 50);
            pxbBrown.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbBrown.TabIndex = 22;
            pxbBrown.TabStop = false;
            pxbBrown.Click += chooseColor;
            // 
            // pxbOrange
            // 
            pxbOrange.BackColor = Color.DarkOrange;
            pxbOrange.Location = new Point(67, 603);
            pxbOrange.Name = "pxbOrange";
            pxbOrange.Size = new Size(50, 50);
            pxbOrange.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbOrange.TabIndex = 21;
            pxbOrange.TabStop = false;
            pxbOrange.Click += chooseColor;
            // 
            // pxbDarkOrange
            // 
            pxbDarkOrange.BackColor = Color.OrangeRed;
            pxbDarkOrange.Location = new Point(10, 603);
            pxbDarkOrange.Name = "pxbDarkOrange";
            pxbDarkOrange.Size = new Size(50, 50);
            pxbDarkOrange.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbDarkOrange.TabIndex = 20;
            pxbDarkOrange.TabStop = false;
            pxbDarkOrange.Click += chooseColor;
            // 
            // pxbPurple
            // 
            pxbPurple.BackColor = Color.Purple;
            pxbPurple.Location = new Point(67, 547);
            pxbPurple.Name = "pxbPurple";
            pxbPurple.Size = new Size(50, 50);
            pxbPurple.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbPurple.TabIndex = 19;
            pxbPurple.TabStop = false;
            pxbPurple.Click += chooseColor;
            // 
            // pxbDarkPurple
            // 
            pxbDarkPurple.BackColor = Color.Indigo;
            pxbDarkPurple.Location = new Point(10, 547);
            pxbDarkPurple.Name = "pxbDarkPurple";
            pxbDarkPurple.Size = new Size(50, 50);
            pxbDarkPurple.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbDarkPurple.TabIndex = 18;
            pxbDarkPurple.TabStop = false;
            pxbDarkPurple.Click += chooseColor;
            // 
            // pxbYellow
            // 
            pxbYellow.BackColor = Color.Yellow;
            pxbYellow.Location = new Point(67, 491);
            pxbYellow.Name = "pxbYellow";
            pxbYellow.Size = new Size(50, 50);
            pxbYellow.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbYellow.TabIndex = 17;
            pxbYellow.TabStop = false;
            pxbYellow.Click += chooseColor;
            // 
            // pxbDarkYellow
            // 
            pxbDarkYellow.BackColor = Color.Gold;
            pxbDarkYellow.Location = new Point(10, 491);
            pxbDarkYellow.Name = "pxbDarkYellow";
            pxbDarkYellow.Size = new Size(50, 50);
            pxbDarkYellow.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbDarkYellow.TabIndex = 16;
            pxbDarkYellow.TabStop = false;
            pxbDarkYellow.Click += chooseColor;
            // 
            // pxbGreen
            // 
            pxbGreen.BackColor = Color.Green;
            pxbGreen.Location = new Point(67, 435);
            pxbGreen.Name = "pxbGreen";
            pxbGreen.Size = new Size(50, 50);
            pxbGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbGreen.TabIndex = 15;
            pxbGreen.TabStop = false;
            pxbGreen.Click += chooseColor;
            // 
            // pxbDarkGreen
            // 
            pxbDarkGreen.BackColor = Color.DarkGreen;
            pxbDarkGreen.Location = new Point(10, 435);
            pxbDarkGreen.Name = "pxbDarkGreen";
            pxbDarkGreen.Size = new Size(50, 50);
            pxbDarkGreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbDarkGreen.TabIndex = 14;
            pxbDarkGreen.TabStop = false;
            pxbDarkGreen.Click += chooseColor;
            // 
            // pxbBlue
            // 
            pxbBlue.BackColor = Color.Blue;
            pxbBlue.Location = new Point(67, 379);
            pxbBlue.Name = "pxbBlue";
            pxbBlue.Size = new Size(50, 50);
            pxbBlue.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbBlue.TabIndex = 13;
            pxbBlue.TabStop = false;
            pxbBlue.Click += chooseColor;
            // 
            // pxbDarkBlue
            // 
            pxbDarkBlue.BackColor = Color.DarkBlue;
            pxbDarkBlue.Location = new Point(10, 379);
            pxbDarkBlue.Name = "pxbDarkBlue";
            pxbDarkBlue.Size = new Size(50, 50);
            pxbDarkBlue.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbDarkBlue.TabIndex = 12;
            pxbDarkBlue.TabStop = false;
            pxbDarkBlue.Click += chooseColor;
            // 
            // pxbRed
            // 
            pxbRed.BackColor = Color.Red;
            pxbRed.Location = new Point(67, 323);
            pxbRed.Name = "pxbRed";
            pxbRed.Size = new Size(50, 50);
            pxbRed.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbRed.TabIndex = 11;
            pxbRed.TabStop = false;
            pxbRed.Click += chooseColor;
            // 
            // pxbDarkRed
            // 
            pxbDarkRed.BackColor = Color.Crimson;
            pxbDarkRed.Location = new Point(10, 323);
            pxbDarkRed.Name = "pxbDarkRed";
            pxbDarkRed.Size = new Size(50, 50);
            pxbDarkRed.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbDarkRed.TabIndex = 10;
            pxbDarkRed.TabStop = false;
            pxbDarkRed.Click += chooseColor;
            // 
            // pxbWhite
            // 
            pxbWhite.BackColor = Color.White;
            pxbWhite.Location = new Point(67, 267);
            pxbWhite.Name = "pxbWhite";
            pxbWhite.Size = new Size(50, 50);
            pxbWhite.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbWhite.TabIndex = 9;
            pxbWhite.TabStop = false;
            pxbWhite.Click += chooseColor;
            // 
            // pxbBlack
            // 
            pxbBlack.BackColor = Color.Black;
            pxbBlack.Location = new Point(10, 267);
            pxbBlack.Name = "pxbBlack";
            pxbBlack.Size = new Size(50, 50);
            pxbBlack.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbBlack.TabIndex = 8;
            pxbBlack.TabStop = false;
            pxbBlack.Click += chooseColor;
            // 
            // pxbSave
            // 
            pxbSave.BackColor = Color.White;
            pxbSave.BorderStyle = BorderStyle.Fixed3D;
            pxbSave.Image = (Image)resources.GetObject("pxbSave.Image");
            pxbSave.Location = new Point(66, 958);
            pxbSave.Name = "pxbSave";
            pxbSave.Size = new Size(50, 50);
            pxbSave.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbSave.TabIndex = 7;
            pxbSave.TabStop = false;
            pxbSave.Click += pxbSave_Click;
            // 
            // nudSize
            // 
            nudSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudSize.Location = new Point(10, 5);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(106, 33);
            nudSize.TabIndex = 6;
            nudSize.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // pxbTrash
            // 
            pxbTrash.BackColor = Color.White;
            pxbTrash.BorderStyle = BorderStyle.Fixed3D;
            pxbTrash.Image = (Image)resources.GetObject("pxbTrash.Image");
            pxbTrash.Location = new Point(9, 958);
            pxbTrash.Name = "pxbTrash";
            pxbTrash.Size = new Size(50, 50);
            pxbTrash.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbTrash.TabIndex = 5;
            pxbTrash.TabStop = false;
            pxbTrash.MouseDown += pxbTrash_MouseDown;
            pxbTrash.MouseUp += pxbTrash_MouseUp;
            // 
            // pxbSpray
            // 
            pxbSpray.BackColor = Color.White;
            pxbSpray.BorderStyle = BorderStyle.Fixed3D;
            pxbSpray.Image = (Image)resources.GetObject("pxbSpray.Image");
            pxbSpray.Location = new Point(66, 101);
            pxbSpray.Name = "pxbSpray";
            pxbSpray.Size = new Size(50, 50);
            pxbSpray.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbSpray.TabIndex = 4;
            pxbSpray.TabStop = false;
            pxbSpray.Click += pxbSpray_Click;
            // 
            // pxbBucket
            // 
            pxbBucket.BackColor = Color.White;
            pxbBucket.BorderStyle = BorderStyle.Fixed3D;
            pxbBucket.Image = (Image)resources.GetObject("pxbBucket.Image");
            pxbBucket.Location = new Point(10, 101);
            pxbBucket.Name = "pxbBucket";
            pxbBucket.Size = new Size(50, 50);
            pxbBucket.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbBucket.TabIndex = 3;
            pxbBucket.TabStop = false;
            pxbBucket.Click += pxbBucket_Click;
            // 
            // pxbEraser
            // 
            pxbEraser.BackColor = Color.White;
            pxbEraser.BorderStyle = BorderStyle.Fixed3D;
            pxbEraser.Image = (Image)resources.GetObject("pxbEraser.Image");
            pxbEraser.Location = new Point(66, 44);
            pxbEraser.Name = "pxbEraser";
            pxbEraser.Size = new Size(50, 50);
            pxbEraser.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbEraser.TabIndex = 2;
            pxbEraser.TabStop = false;
            pxbEraser.Click += pxbEraser_Click;
            // 
            // pxbPencil
            // 
            pxbPencil.BackColor = Color.Silver;
            pxbPencil.BorderStyle = BorderStyle.Fixed3D;
            pxbPencil.Image = (Image)resources.GetObject("pxbPencil.Image");
            pxbPencil.Location = new Point(10, 45);
            pxbPencil.Name = "pxbPencil";
            pxbPencil.Size = new Size(50, 50);
            pxbPencil.SizeMode = PictureBoxSizeMode.StretchImage;
            pxbPencil.TabIndex = 1;
            pxbPencil.TabStop = false;
            pxbPencil.Click += pxbPencil_Click;
            // 
            // pxbCanvas
            // 
            pxbCanvas.BackColor = Color.Silver;
            pxbCanvas.Location = new Point(0, 60);
            pxbCanvas.Name = "pxbCanvas";
            pxbCanvas.Size = new Size(1790, 1020);
            pxbCanvas.TabIndex = 2;
            pxbCanvas.TabStop = false;
            pxbCanvas.MouseDown += pxbCanvas_MouseDown;
            pxbCanvas.MouseMove += pxbCanvas_MouseMove;
            pxbCanvas.MouseUp += pxbCanvas_MouseUp;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pxbCanvas);
            Controls.Add(pnlR);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Paint 2.0";
            WindowState = FormWindowState.Maximized;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pxbCurrent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbOwnColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbBrown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkOrange).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbPurple).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkPurple).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbDarkRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbBlack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbSpray).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbBucket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbEraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbPencil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pxbCanvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlR;
        private PictureBox pxbEraser;
        private PictureBox pxbPencil;
        private Button btnExit;
        private PictureBox pxbBucket;
        private PictureBox pxbSpray;
        private Label lblName;
        private PictureBox pxbTrash;
        private NumericUpDown nudSize;
        private PictureBox pxbSave;
        private PictureBox pxbBlack;
        private PictureBox pxbCanvas;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox14;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pxbCurrent;
        private PictureBox pxbOwnColor;
        private PictureBox pxbBrown;
        private PictureBox pxbOrange;
        private PictureBox pxbDarkOrange;
        private PictureBox pxbPurple;
        private PictureBox pxbDarkPurple;
        private PictureBox pxbYellow;
        private PictureBox pxbDarkYellow;
        private PictureBox pxbGreen;
        private PictureBox pxbDarkGreen;
        private PictureBox pxbBlue;
        private PictureBox pxbDarkBlue;
        private PictureBox pxbRed;
        private PictureBox pxbDarkRed;
        private PictureBox pxbWhite;
        private ColorDialog colorDialog1;
    }
}