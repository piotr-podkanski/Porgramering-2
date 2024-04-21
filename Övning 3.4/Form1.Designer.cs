namespace Övning_3._4
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
            tbxStr1 = new TextBox();
            lblStr1 = new Label();
            lblStr2 = new Label();
            tbxStr2 = new TextBox();
            lblResult = new Label();
            lblInfo = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbxStr1
            // 
            tbxStr1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxStr1.Location = new Point(169, 34);
            tbxStr1.Name = "tbxStr1";
            tbxStr1.Size = new Size(100, 37);
            tbxStr1.TabIndex = 0;
            // 
            // lblStr1
            // 
            lblStr1.AutoSize = true;
            lblStr1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStr1.ForeColor = SystemColors.ButtonFace;
            lblStr1.Location = new Point(29, 37);
            lblStr1.Name = "lblStr1";
            lblStr1.Size = new Size(75, 29);
            lblStr1.TabIndex = 1;
            lblStr1.Text = "label1:";
            // 
            // lblStr2
            // 
            lblStr2.AutoSize = true;
            lblStr2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblStr2.ForeColor = SystemColors.ButtonFace;
            lblStr2.Location = new Point(29, 101);
            lblStr2.Name = "lblStr2";
            lblStr2.Size = new Size(79, 29);
            lblStr2.TabIndex = 3;
            lblStr2.Text = "label2:";
            // 
            // tbxStr2
            // 
            tbxStr2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            tbxStr2.Location = new Point(169, 98);
            tbxStr2.Name = "tbxStr2";
            tbxStr2.Size = new Size(100, 37);
            tbxStr2.TabIndex = 2;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ButtonFace;
            lblResult.Location = new Point(29, 173);
            lblResult.MaximumSize = new Size(250, 30);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(243, 29);
            lblResult.TabIndex = 4;
            lblResult.Text = "Your result will be here";
            lblResult.Visible = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.ButtonFace;
            lblInfo.Location = new Point(299, 37);
            lblInfo.MaximumSize = new Size(200, 0);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(191, 87);
            lblInfo.TabIndex = 5;
            lblInfo.Text = "To combine these words press the button bellow";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(310, 146);
            button1.Name = "button1";
            button1.Size = new Size(159, 56);
            button1.TabIndex = 6;
            button1.Text = "Combine";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(494, 335);
            Controls.Add(button1);
            Controls.Add(lblInfo);
            Controls.Add(lblResult);
            Controls.Add(lblStr2);
            Controls.Add(tbxStr2);
            Controls.Add(lblStr1);
            Controls.Add(tbxStr1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxStr1;
        private Label lblStr1;
        private Label lblStr2;
        private TextBox tbxStr2;
        private Label lblResult;
        private Label lblInfo;
        private Button button1;
    }
}