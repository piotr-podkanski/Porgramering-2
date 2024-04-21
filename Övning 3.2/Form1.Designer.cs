namespace Övning_3._2
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
            lblVal2 = new Label();
            tbxVal2 = new TextBox();
            lblResult = new Label();
            btnCal = new Button();
            SuspendLayout();
            // 
            // lblVal1
            // 
            lblVal1.AutoSize = true;
            lblVal1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblVal1.ForeColor = SystemColors.Control;
            lblVal1.Location = new Point(46, 52);
            lblVal1.Name = "lblVal1";
            lblVal1.Size = new Size(148, 29);
            lblVal1.TabIndex = 0;
            lblVal1.Text = "Input Value 1:";
            // 
            // tbxVal1
            // 
            tbxVal1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxVal1.Location = new Point(200, 49);
            tbxVal1.Name = "tbxVal1";
            tbxVal1.Size = new Size(100, 37);
            tbxVal1.TabIndex = 2;
            // 
            // lblVal2
            // 
            lblVal2.AutoSize = true;
            lblVal2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblVal2.ForeColor = SystemColors.Control;
            lblVal2.Location = new Point(46, 100);
            lblVal2.Name = "lblVal2";
            lblVal2.Size = new Size(152, 29);
            lblVal2.TabIndex = 4;
            lblVal2.Text = "Input Value 2:";
            // 
            // tbxVal2
            // 
            tbxVal2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxVal2.Location = new Point(200, 97);
            tbxVal2.Name = "tbxVal2";
            tbxVal2.Size = new Size(100, 37);
            tbxVal2.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.Control;
            lblResult.Location = new Point(96, 172);
            lblResult.MaximumSize = new Size(290, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(289, 29);
            lblResult.TabIndex = 6;
            lblResult.Text = "Your result will  output here";
            lblResult.Visible = false;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            btnCal.Location = new Point(313, 233);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(155, 61);
            btnCal.TabIndex = 7;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(480, 313);
            Controls.Add(btnCal);
            Controls.Add(lblResult);
            Controls.Add(tbxVal2);
            Controls.Add(lblVal2);
            Controls.Add(tbxVal1);
            Controls.Add(lblVal1);
            Name = "Form1";
            Text = "Sum";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVal1;
        private TextBox tbxVal1;
        private Label lblVal2;
        private TextBox tbxVal2;
        private Label lblResult;
        private Button btnCal;
    }
}