namespace Övning7_2
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
            label1 = new Label();
            btnSubmit = new Button();
            lblResult = new Label();
            txbAge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 2;
            label1.Text = "Input your age";
            label1.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(283, 21);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += Submit;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(12, 62);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(221, 25);
            lblResult.TabIndex = 4;
            lblResult.Text = "The result will show here";
            lblResult.Click += lblResult_Click;
            // 
            // txbAge
            // 
            txbAge.Location = new Point(158, 21);
            txbAge.Name = "txbAge";
            txbAge.Size = new Size(100, 23);
            txbAge.TabIndex = 5;
            txbAge.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(406, 113);
            Controls.Add(txbAge);
            Controls.Add(lblResult);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Input_age";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnSubmit;
        private Label lblResult;
        private TextBox txbAge;
    }
}