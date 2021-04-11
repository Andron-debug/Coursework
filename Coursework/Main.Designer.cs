
namespace Coursework
{
    partial class Main
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
            this.Сhance_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Сhance_label
            // 
            this.Сhance_label.AutoSize = true;
            this.Сhance_label.BackColor = System.Drawing.Color.Transparent;
            this.Сhance_label.Location = new System.Drawing.Point(491, 42);
            this.Сhance_label.Name = "Сhance_label";
            this.Сhance_label.Size = new System.Drawing.Size(50, 20);
            this.Сhance_label.TabIndex = 0;
            this.Сhance_label.Text = "label1";
            // 
            // Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coursework.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(664, 474);
            this.Controls.Add(this.Сhance_label);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(682, 521);
            this.MinimumSize = new System.Drawing.Size(682, 521);
            this.Name = "Main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Сhance_label;
    }
}

