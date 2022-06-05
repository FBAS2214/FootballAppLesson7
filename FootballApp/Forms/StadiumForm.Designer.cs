namespace FootballApp.Forms
{
    partial class StadiumForm
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
            this.pBox_Flag = new System.Windows.Forms.PictureBox();
            this.lbl_country = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Flag)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_Flag
            // 
            this.pBox_Flag.Location = new System.Drawing.Point(12, 21);
            this.pBox_Flag.Name = "pBox_Flag";
            this.pBox_Flag.Size = new System.Drawing.Size(89, 63);
            this.pBox_Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_Flag.TabIndex = 0;
            this.pBox_Flag.TabStop = false;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.BackColor = System.Drawing.Color.Transparent;
            this.lbl_country.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_country.Location = new System.Drawing.Point(372, 24);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(75, 25);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "label1";
            // 
            // StadiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FootballApp.Resources.stadium;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(494, 752);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.pBox_Flag);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StadiumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StadiumForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Flag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBox_Flag;
        private Label lbl_country;
    }
}