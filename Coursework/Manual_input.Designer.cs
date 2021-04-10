
namespace Coursework
{
    partial class Manual_input
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Word_textBox = new System.Windows.Forms.TextBox();
            this.Srtart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Word_textBox
            // 
            this.Word_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Word_textBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Word_textBox.Location = new System.Drawing.Point(12, 28);
            this.Word_textBox.Name = "Word_textBox";
            this.Word_textBox.Size = new System.Drawing.Size(339, 52);
            this.Word_textBox.TabIndex = 0;
            // 
            // Srtart
            // 
            this.Srtart.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Srtart.Location = new System.Drawing.Point(9, 135);
            this.Srtart.Name = "Srtart";
            this.Srtart.Size = new System.Drawing.Size(341, 78);
            this.Srtart.TabIndex = 1;
            this.Srtart.Text = "НАЧАТЬ";
            this.Srtart.UseVisualStyleBackColor = true;
            this.Srtart.Click += new System.EventHandler(this.Srtart_Click);
            // 
            // Manual_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 292);
            this.Controls.Add(this.Srtart);
            this.Controls.Add(this.Word_textBox);
            this.Name = "Manual_input";
            this.Text = "Manual_input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Word_textBox;
        private System.Windows.Forms.Button Srtart;
    }
}