namespace FootballApp.UserControls
{
    partial class UC_Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Number
            // 
            this.txt_Number.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Number.Location = new System.Drawing.Point(126, 3);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(100, 26);
            this.txt_Number.TabIndex = 0;
            this.txt_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Position
            // 
            this.txt_Position.Enabled = false;
            this.txt_Position.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Position.Location = new System.Drawing.Point(0, 3);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.ReadOnly = true;
            this.txt_Position.Size = new System.Drawing.Size(100, 26);
            this.txt_Position.TabIndex = 0;
            this.txt_Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Name.Location = new System.Drawing.Point(252, 3);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.PlaceholderText = "PlayerControl";
            this.txt_Name.Size = new System.Drawing.Size(100, 26);
            this.txt_Name.TabIndex = 0;
            // 
            // UC_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Position);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Number);
            this.Name = "UC_Player";
            this.Size = new System.Drawing.Size(355, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox txt_Number;
        public TextBox txt_Position;
        public TextBox txt_Name;
    }
}
