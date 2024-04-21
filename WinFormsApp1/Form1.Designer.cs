namespace Övning7_3
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
            LblDice = new Label();
            BtnThrow = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // LblDice
            // 
            LblDice.AutoSize = true;
            LblDice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblDice.ForeColor = SystemColors.ButtonFace;
            LblDice.Location = new Point(34, 25);
            LblDice.Name = "LblDice";
            LblDice.Size = new Size(100, 25);
            LblDice.TabIndex = 1;
            LblDice.Text = "You threw:";
            LblDice.Click += LblDice_Click;
            // 
            // BtnThrow
            // 
            BtnThrow.Location = new Point(95, 94);
            BtnThrow.Name = "BtnThrow";
            BtnThrow.Size = new Size(75, 23);
            BtnThrow.TabIndex = 2;
            BtnThrow.Text = "Throw";
            BtnThrow.UseVisualStyleBackColor = true;
            BtnThrow.Click += button1_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ControlLightLight;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.ForeColor = SystemColors.ActiveCaptionText;
            lblResult.Location = new Point(140, 23);
            lblResult.MinimumSize = new Size(130, 30);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(130, 30);
            lblResult.TabIndex = 3;
            lblResult.Text = "Your number";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(295, 145);
            Controls.Add(lblResult);
            Controls.Add(BtnThrow);
            Controls.Add(LblDice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblDice;
        private Button BtnThrow;
        private Label lblResult;
    }
}