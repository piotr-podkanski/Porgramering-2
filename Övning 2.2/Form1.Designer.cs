namespace Övning_2._2
{
    partial class Övning
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
            btnMsg = new Button();
            SuspendLayout();
            // 
            // btnMsg
            // 
            btnMsg.FlatAppearance.BorderColor = Color.Black;
            btnMsg.FlatAppearance.BorderSize = 2;
            btnMsg.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnMsg.Location = new Point(99, 40);
            btnMsg.Name = "btnMsg";
            btnMsg.Size = new Size(134, 63);
            btnMsg.TabIndex = 0;
            btnMsg.Text = "Message";
            btnMsg.UseVisualStyleBackColor = true;
            btnMsg.Click += btnMsg_click;
            // 
            // Övning
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(352, 131);
            Controls.Add(btnMsg);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Övning";
            Text = "Övning";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMsg;
    }
}