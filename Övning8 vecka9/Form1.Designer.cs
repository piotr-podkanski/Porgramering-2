namespace Övning8_vecka9
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
            gbxDifficulty = new GroupBox();
            lblAmount = new Label();
            lbxDiff = new ListBox();
            btnStart = new Button();
            btnRetry = new Button();
            gbxDifficulty.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDifficulty
            // 
            gbxDifficulty.Controls.Add(lbxDiff);
            gbxDifficulty.Controls.Add(lblAmount);
            gbxDifficulty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gbxDifficulty.ForeColor = SystemColors.ControlLight;
            gbxDifficulty.Location = new Point(48, 48);
            gbxDifficulty.Name = "gbxDifficulty";
            gbxDifficulty.Size = new Size(221, 119);
            gbxDifficulty.TabIndex = 0;
            gbxDifficulty.TabStop = false;
            gbxDifficulty.Text = "Difficulty";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 28);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(83, 25);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount:";
            lblAmount.Click += label1_Click;
            // 
            // lbxDiff
            // 
            lbxDiff.FormattingEnabled = true;
            lbxDiff.ItemHeight = 25;
            lbxDiff.Items.AddRange(new object[] { "5", "10", "15", "20" });
            lbxDiff.Location = new Point(127, 28);
            lbxDiff.Name = "lbxDiff";
            lbxDiff.Size = new Size(73, 29);
            lbxDiff.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(551, 66);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 35);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnRetry
            // 
            btnRetry.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetry.Location = new Point(551, 109);
            btnRetry.Name = "btnRetry";
            btnRetry.Size = new Size(110, 35);
            btnRetry.TabIndex = 2;
            btnRetry.Text = "Try again";
            btnRetry.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 430);
            Controls.Add(btnRetry);
            Controls.Add(btnStart);
            Controls.Add(gbxDifficulty);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxDifficulty.ResumeLayout(false);
            gbxDifficulty.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxDifficulty;
        private Label lblAmount;
        private ListBox lbxDiff;
        private Button btnStart;
        private Button btnRetry;
    }
}