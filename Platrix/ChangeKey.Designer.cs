namespace Platrix
{
    partial class ChangeKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeKey));
            this.lblPress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.BackColor = System.Drawing.Color.Transparent;
            this.lblPress.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPress.ForeColor = System.Drawing.Color.Snow;
            this.lblPress.Location = new System.Drawing.Point(12, 19);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(284, 39);
            this.lblPress.TabIndex = 0;
            this.lblPress.Text = "Press any button";
            // 
            // ChangeKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(305, 73);
            this.Controls.Add(this.lblPress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeKey";
            this.Text = "ChangeKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPress;
    }
}