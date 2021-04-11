
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.Start_PVP = new System.Windows.Forms.Button();
            this.Start_PVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_PVP
            // 
            this.Start_PVP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_PVP.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start_PVP.Location = new System.Drawing.Point(43, 43);
            this.Start_PVP.Name = "Start_PVP";
            this.Start_PVP.Size = new System.Drawing.Size(396, 61);
            this.Start_PVP.TabIndex = 0;
            this.Start_PVP.Text = "PvP";
            this.Start_PVP.UseVisualStyleBackColor = true;
            this.Start_PVP.Click += new System.EventHandler(this.Start_PVP_Click);
            // 
            // Start_PVE
            // 
            this.Start_PVE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_PVE.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Start_PVE.Location = new System.Drawing.Point(43, 141);
            this.Start_PVE.Name = "Start_PVE";
            this.Start_PVE.Size = new System.Drawing.Size(396, 60);
            this.Start_PVE.TabIndex = 1;
            this.Start_PVE.Text = "PvE";
            this.Start_PVE.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 238);
            this.Controls.Add(this.Start_PVE);
            this.Controls.Add(this.Start_PVP);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(495, 285);
            this.MinimumSize = new System.Drawing.Size(495, 285);
            this.Name = "Start";

            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_PVP;
        private System.Windows.Forms.Button Start_PVE;
    }
}