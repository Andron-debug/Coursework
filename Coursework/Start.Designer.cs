
namespace Coursework
{
    partial class Start
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
            this.Start_PVP = new System.Windows.Forms.Button();
            this.Start_PVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_PVP
            // 
            this.Start_PVP.Location = new System.Drawing.Point(112, 64);
            this.Start_PVP.Name = "Start_PVP";
            this.Start_PVP.Size = new System.Drawing.Size(295, 61);
            this.Start_PVP.TabIndex = 0;
            this.Start_PVP.Text = "PvP";
            this.Start_PVP.UseVisualStyleBackColor = true;
            // 
            // Start_PVE
            // 
            this.Start_PVE.Location = new System.Drawing.Point(112, 131);
            this.Start_PVE.Name = "Start_PVE";
            this.Start_PVE.Size = new System.Drawing.Size(295, 61);
            this.Start_PVE.TabIndex = 1;
            this.Start_PVE.Text = "PvE";
            this.Start_PVE.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 265);
            this.Controls.Add(this.Start_PVE);
            this.Controls.Add(this.Start_PVP);
            this.Name = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_PVP;
        private System.Windows.Forms.Button Start_PVE;
    }
}