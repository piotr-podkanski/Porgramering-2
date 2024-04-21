namespace Övning_3._3
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
            lblVal1 = new Label();
            tbxVal1 = new TextBox();
            btnCal = new Button();
            tbxVal2 = new TextBox();
            lblVal2 = new Label();
            tbxVal3 = new TextBox();
            lblVal3 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblVal1
            // 
            lblVal1.AutoSize = true;
            lblVal1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblVal1.ForeColor = SystemColors.ButtonFace;
            lblVal1.Location = new Point(107, 35);
            lblVal1.Name = "lblVal1";
            lblVal1.Size = new Size(148, 29);
            lblVal1.TabIndex = 0;
            lblVal1.Text = "Input Value 1:";
            // 
            // tbxVal1
            // 
            tbxVal1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxVal1.Location = new Point(310, 32);
            tbxVal1.Name = "tbxVal1";
            tbxVal1.Size = new Size(136, 37);
            tbxVal1.TabIndex = 1;
            tbxVal1.TextChanged += textBox1_TextChanged;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCal.Location = new Point(310, 237);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(158, 81);
            btnCal.TabIndex = 2;
            btnCal.Text = "Get the average";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += button1_Click;
            // 
            // tbxVal2
            // 
            tbxVal2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxVal2.Location = new Point(310, 95);
            tbxVal2.Name = "tbxVal2";
            tbxVal2.Size = new Size(136, 37);
            tbxVal2.TabIndex = 4;
            // 
            // lblVal2
            // 
            lblVal2.AutoSize = true;
            lblVal2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblVal2.ForeColor = SystemColors.ButtonFace;
            lblVal2.Location = new Point(103, 98);
            lblVal2.Name = "lblVal2";
            lblVal2.Size = new Size(152, 29);
            lblVal2.TabIndex = 3;
            lblVal2.Text = "Input Value 2:";
            // 
            // tbxVal3
            // 
            tbxVal3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxVal3.Location = new Point(310, 163);
            tbxVal3.Name = "tbxVal3";
            tbxVal3.Size = new Size(136, 37);
            tbxVal3.TabIndex = 6;
            // 
            // lblVal3
            // 
            lblVal3.AutoSize = true;
            lblVal3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblVal3.ForeColor = SystemColors.ButtonFace;
            lblVal3.Location = new Point(103, 166);
            lblVal3.Name = "lblVal3";
            lblVal3.Size = new Size(152, 29);
            lblVal3.TabIndex = 5;
            lblVal3.Text = "Input Value 3:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ButtonFace;
            lblResult.Location = new Point(38, 237);
            lblResult.MaximumSize = new Size(250, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(243, 29);
            lblResult.TabIndex = 7;
            lblResult.Text = "Your result will be here";
            lblResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(tbxVal3);
            Controls.Add(lblVal3);
            Controls.Add(tbxVal2);
            Controls.Add(lblVal2);
            Controls.Add(btnCal);
            Controls.Add(tbxVal1);
            Controls.Add(lblVal1);
            Name = "Form1";
            Text = "Average";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVal1;
        private TextBox tbxVal1;
        private Button btnCal;
        private TextBox tbxVal2;
        private Label lblVal2;
        private TextBox tbxVal3;
        private Label lblVal3;
        private Label lblResult;
    }
}