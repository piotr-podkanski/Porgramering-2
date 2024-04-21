namespace Övning_3._1
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
            tbxValue = new TextBox();
            lblInput = new Label();
            BtnCalc = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // tbxValue
            // 
            tbxValue.Location = new Point(221, 54);
            tbxValue.Name = "tbxValue";
            tbxValue.Size = new Size(100, 34);
            tbxValue.TabIndex = 0;
            tbxValue.Text = "0";
            tbxValue.TextChanged += tbxValue_TextChanged;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.BackColor = Color.Transparent;
            lblInput.ForeColor = SystemColors.Control;
            lblInput.Location = new Point(53, 57);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(162, 27);
            lblInput.TabIndex = 1;
            lblInput.Text = "Input your value:";
            // 
            // BtnCalc
            // 
            BtnCalc.Location = new Point(53, 193);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(113, 50);
            BtnCalc.TabIndex = 2;
            BtnCalc.Text = "Calculate";
            BtnCalc.UseVisualStyleBackColor = true;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(183, 103);
            lblResult.MaximumSize = new Size(180, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(174, 54);
            lblResult.TabIndex = 3;
            lblResult.Text = "\r\nResult will be here";
            lblResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(537, 302);
            Controls.Add(lblResult);
            Controls.Add(BtnCalc);
            Controls.Add(lblInput);
            Controls.Add(tbxValue);
            Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Calculate the quadrant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxValue;
        private Label lblInput;
        private Button BtnCalc;
        private Label lblResult;

    }
}