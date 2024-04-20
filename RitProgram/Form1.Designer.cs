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
            pbxTrash = new PictureBox();
            pbxSpray = new PictureBox();
            pbxBucket = new PictureBox();
            pbxErazer = new PictureBox();
            pbxBrush = new PictureBox();
            nudSize = new NumericUpDown();
            pictureBox1 = new PictureBox();
            pbxColor = new PictureBox();
            pnlTop.SuspendLayout();
            pnlR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTrash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSpray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBucket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxErazer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrush).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxColor).BeginInit();
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
            pnlTop.Size = new Size(880, 62);
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
            btnExit.Location = new Point(818, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // pnlR
            // 
            pnlR.BackColor = Color.FromArgb(255, 128, 255);
            pnlR.Controls.Add(pbxColor);
            pnlR.Controls.Add(pictureBox1);
            pnlR.Controls.Add(nudSize);
            pnlR.Controls.Add(pbxTrash);
            pnlR.Controls.Add(pbxSpray);
            pnlR.Controls.Add(pbxBucket);
            pnlR.Controls.Add(pbxErazer);
            pnlR.Controls.Add(pbxBrush);
            pnlR.Dock = DockStyle.Right;
            pnlR.Location = new Point(807, 62);
            pnlR.Name = "pnlR";
            pnlR.Size = new Size(73, 617);
            pnlR.TabIndex = 1;
            // 
            // pbxTrash
            // 
            pbxTrash.BackColor = Color.White;
            pbxTrash.BorderStyle = BorderStyle.Fixed3D;
            pbxTrash.Image = (Image)resources.GetObject("pbxTrash.Image");
            pbxTrash.Location = new Point(11, 508);
            pbxTrash.Name = "pbxTrash";
            pbxTrash.Size = new Size(50, 50);
            pbxTrash.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxTrash.TabIndex = 5;
            pbxTrash.TabStop = false;
            // 
            // pbxSpray
            // 
            pbxSpray.BackColor = Color.White;
            pbxSpray.BorderStyle = BorderStyle.Fixed3D;
            pbxSpray.Image = (Image)resources.GetObject("pbxSpray.Image");
            pbxSpray.Location = new Point(11, 213);
            pbxSpray.Name = "pbxSpray";
            pbxSpray.Size = new Size(50, 50);
            pbxSpray.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxSpray.TabIndex = 4;
            pbxSpray.TabStop = false;
            // 
            // pbxBucket
            // 
            pbxBucket.BackColor = Color.White;
            pbxBucket.BorderStyle = BorderStyle.Fixed3D;
            pbxBucket.Image = (Image)resources.GetObject("pbxBucket.Image");
            pbxBucket.Location = new Point(11, 157);
            pbxBucket.Name = "pbxBucket";
            pbxBucket.Size = new Size(50, 50);
            pbxBucket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBucket.TabIndex = 3;
            pbxBucket.TabStop = false;
            // 
            // pbxErazer
            // 
            pbxErazer.BackColor = Color.White;
            pbxErazer.BorderStyle = BorderStyle.Fixed3D;
            pbxErazer.Image = (Image)resources.GetObject("pbxErazer.Image");
            pbxErazer.Location = new Point(11, 101);
            pbxErazer.Name = "pbxErazer";
            pbxErazer.Size = new Size(50, 50);
            pbxErazer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxErazer.TabIndex = 2;
            pbxErazer.TabStop = false;
            // 
            // pbxBrush
            // 
            pbxBrush.BackColor = Color.Silver;
            pbxBrush.BorderStyle = BorderStyle.Fixed3D;
            pbxBrush.Image = (Image)resources.GetObject("pbxBrush.Image");
            pbxBrush.Location = new Point(11, 45);
            pbxBrush.Name = "pbxBrush";
            pbxBrush.Size = new Size(50, 50);
            pbxBrush.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxBrush.TabIndex = 1;
            pbxBrush.TabStop = false;
            // 
            // nudSize
            // 
            nudSize.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudSize.Location = new Point(11, 6);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(50, 33);
            nudSize.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 564);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pbxColor
            // 
            pbxColor.BackColor = Color.Black;
            pbxColor.Location = new Point(11, 269);
            pbxColor.Name = "pbxColor";
            pbxColor.Size = new Size(50, 50);
            pbxColor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxColor.TabIndex = 8;
            pbxColor.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(880, 679);
            Controls.Add(pnlR);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Paint 2.0";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxTrash).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSpray).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBucket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxErazer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrush).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxColor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlR;
        private PictureBox pbxErazer;
        private PictureBox pbxBrush;
        private Button btnExit;
        private PictureBox pbxBucket;
        private PictureBox pbxSpray;
        private Label lblName;
        private PictureBox pbxTrash;
        private NumericUpDown nudSize;
        private PictureBox pictureBox1;
        private PictureBox pbxColor;
    }
}