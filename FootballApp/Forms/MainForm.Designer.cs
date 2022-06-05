namespace FootballApp
{
    partial class MainForm
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
            this.lbl_Country = new System.Windows.Forms.Label();
            this.cBox_CountryNames = new System.Windows.Forms.ComboBox();
            this.cBox_TacticsFormats = new System.Windows.Forms.ComboBox();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.uC_Player1 = new FootballApp.UserControls.UC_Player();
            this.panel_Players = new System.Windows.Forms.Panel();
            this.uC_Player9 = new FootballApp.UserControls.UC_Player();
            this.uC_Player10 = new FootballApp.UserControls.UC_Player();
            this.uC_Player11 = new FootballApp.UserControls.UC_Player();
            this.uC_Player5 = new FootballApp.UserControls.UC_Player();
            this.uC_Player6 = new FootballApp.UserControls.UC_Player();
            this.uC_Player7 = new FootballApp.UserControls.UC_Player();
            this.uC_Player8 = new FootballApp.UserControls.UC_Player();
            this.uC_Player3 = new FootballApp.UserControls.UC_Player();
            this.uC_Player4 = new FootballApp.UserControls.UC_Player();
            this.uC_Player2 = new FootballApp.UserControls.UC_Player();
            this.panel_Footer = new System.Windows.Forms.Panel();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            this.panel_Players.SuspendLayout();
            this.panel_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Country.Location = new System.Drawing.Point(11, 12);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(95, 25);
            this.lbl_Country.TabIndex = 1;
            this.lbl_Country.Text = "Country";
            // 
            // cBox_CountryNames
            // 
            this.cBox_CountryNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_CountryNames.DropDownHeight = 395;
            this.cBox_CountryNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_CountryNames.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_CountryNames.FormattingEnabled = true;
            this.cBox_CountryNames.IntegralHeight = false;
            this.cBox_CountryNames.Location = new System.Drawing.Point(142, 11);
            this.cBox_CountryNames.Name = "cBox_CountryNames";
            this.cBox_CountryNames.Size = new System.Drawing.Size(184, 31);
            this.cBox_CountryNames.TabIndex = 2;
            // 
            // cBox_TacticsFormats
            // 
            this.cBox_TacticsFormats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBox_TacticsFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_TacticsFormats.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_TacticsFormats.FormattingEnabled = true;
            this.cBox_TacticsFormats.Location = new System.Drawing.Point(352, 11);
            this.cBox_TacticsFormats.Name = "cBox_TacticsFormats";
            this.cBox_TacticsFormats.Size = new System.Drawing.Size(111, 31);
            this.cBox_TacticsFormats.TabIndex = 2;
            this.cBox_TacticsFormats.SelectedIndexChanged += new System.EventHandler(this.cBox_TacticsFormats_SelectedIndexChanged);
            // 
            // panel_Header
            // 
            this.panel_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Header.Controls.Add(this.lbl_Position);
            this.panel_Header.Controls.Add(this.lbl_Number);
            this.panel_Header.Controls.Add(this.lbl_Name);
            this.panel_Header.Controls.Add(this.cBox_TacticsFormats);
            this.panel_Header.Controls.Add(this.cBox_CountryNames);
            this.panel_Header.Controls.Add(this.lbl_Country);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(494, 111);
            this.panel_Header.TabIndex = 3;
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_Position.Location = new System.Drawing.Point(36, 71);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(84, 25);
            this.lbl_Position.TabIndex = 1;
            this.lbl_Position.Text = "Position";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_Number.Location = new System.Drawing.Point(198, 71);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(87, 25);
            this.lbl_Number.TabIndex = 1;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(365, 71);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(66, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // uC_Player1
            // 
            this.uC_Player1.Location = new System.Drawing.Point(15, 13);
            this.uC_Player1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Player1.Name = "uC_Player1";
            this.uC_Player1.Size = new System.Drawing.Size(464, 40);
            this.uC_Player1.TabIndex = 4;
            // 
            // panel_Players
            // 
            this.panel_Players.Controls.Add(this.uC_Player9);
            this.panel_Players.Controls.Add(this.uC_Player10);
            this.panel_Players.Controls.Add(this.uC_Player11);
            this.panel_Players.Controls.Add(this.uC_Player5);
            this.panel_Players.Controls.Add(this.uC_Player6);
            this.panel_Players.Controls.Add(this.uC_Player7);
            this.panel_Players.Controls.Add(this.uC_Player8);
            this.panel_Players.Controls.Add(this.uC_Player3);
            this.panel_Players.Controls.Add(this.uC_Player4);
            this.panel_Players.Controls.Add(this.uC_Player2);
            this.panel_Players.Controls.Add(this.uC_Player1);
            this.panel_Players.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Players.Location = new System.Drawing.Point(0, 111);
            this.panel_Players.Name = "panel_Players";
            this.panel_Players.Size = new System.Drawing.Size(494, 641);
            this.panel_Players.TabIndex = 55;
            // 
            // uC_Player9
            // 
            this.uC_Player9.Location = new System.Drawing.Point(14, 499);
            this.uC_Player9.Margin = new System.Windows.Forms.Padding(10);
            this.uC_Player9.Name = "uC_Player9";
            this.uC_Player9.Size = new System.Drawing.Size(464, 40);
            this.uC_Player9.TabIndex = 14;
            // 
            // uC_Player10
            // 
            this.uC_Player10.Location = new System.Drawing.Point(15, 454);
            this.uC_Player10.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Player10.Name = "uC_Player10";
            this.uC_Player10.Size = new System.Drawing.Size(464, 40);
            this.uC_Player10.TabIndex = 13;
            // 
            // uC_Player11
            // 
            this.uC_Player11.Location = new System.Drawing.Point(15, 405);
            this.uC_Player11.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Player11.Name = "uC_Player11";
            this.uC_Player11.Size = new System.Drawing.Size(464, 40);
            this.uC_Player11.TabIndex = 12;
            // 
            // uC_Player5
            // 
            this.uC_Player5.Location = new System.Drawing.Point(15, 356);
            this.uC_Player5.Margin = new System.Windows.Forms.Padding(8);
            this.uC_Player5.Name = "uC_Player5";
            this.uC_Player5.Size = new System.Drawing.Size(464, 40);
            this.uC_Player5.TabIndex = 11;
            // 
            // uC_Player6
            // 
            this.uC_Player6.Location = new System.Drawing.Point(15, 307);
            this.uC_Player6.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Player6.Name = "uC_Player6";
            this.uC_Player6.Size = new System.Drawing.Size(464, 40);
            this.uC_Player6.TabIndex = 10;
            // 
            // uC_Player7
            // 
            this.uC_Player7.Location = new System.Drawing.Point(15, 258);
            this.uC_Player7.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Player7.Name = "uC_Player7";
            this.uC_Player7.Size = new System.Drawing.Size(464, 40);
            this.uC_Player7.TabIndex = 9;
            // 
            // uC_Player8
            // 
            this.uC_Player8.Location = new System.Drawing.Point(15, 209);
            this.uC_Player8.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Player8.Name = "uC_Player8";
            this.uC_Player8.Size = new System.Drawing.Size(464, 40);
            this.uC_Player8.TabIndex = 8;
            // 
            // uC_Player3
            // 
            this.uC_Player3.Location = new System.Drawing.Point(15, 160);
            this.uC_Player3.Margin = new System.Windows.Forms.Padding(6);
            this.uC_Player3.Name = "uC_Player3";
            this.uC_Player3.Size = new System.Drawing.Size(464, 40);
            this.uC_Player3.TabIndex = 7;
            // 
            // uC_Player4
            // 
            this.uC_Player4.Location = new System.Drawing.Point(15, 111);
            this.uC_Player4.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Player4.Name = "uC_Player4";
            this.uC_Player4.Size = new System.Drawing.Size(464, 40);
            this.uC_Player4.TabIndex = 6;
            // 
            // uC_Player2
            // 
            this.uC_Player2.Location = new System.Drawing.Point(15, 62);
            this.uC_Player2.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Player2.Name = "uC_Player2";
            this.uC_Player2.Size = new System.Drawing.Size(464, 40);
            this.uC_Player2.TabIndex = 5;
            // 
            // panel_Footer
            // 
            this.panel_Footer.Controls.Add(this.btn_Generate);
            this.panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Footer.Location = new System.Drawing.Point(0, 661);
            this.panel_Footer.Name = "panel_Footer";
            this.panel_Footer.Size = new System.Drawing.Size(494, 91);
            this.panel_Footer.TabIndex = 6;
            // 
            // btn_Generate
            // 
            this.btn_Generate.AutoSize = true;
            this.btn_Generate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Generate.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Generate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Generate.Location = new System.Drawing.Point(321, 22);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(143, 47);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(494, 752);
            this.Controls.Add(this.panel_Footer);
            this.Controls.Add(this.panel_Players);
            this.Controls.Add(this.panel_Header);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel_Players.ResumeLayout(false);
            this.panel_Footer.ResumeLayout(false);
            this.panel_Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lbl_Country;
        private ComboBox cBox_CountryNames;
        private ComboBox cBox_TacticsFormats;
        private Panel panel_Header;
        private Label lbl_Position;
        private Label lbl_Number;
        private Label lbl_Name;
        private UserControls.UC_Player uC_Player1;
        private Panel panel_Players;
        private UserControls.UC_Player uC_Player9;
        private UserControls.UC_Player uC_Player10;
        private UserControls.UC_Player uC_Player11;
        private UserControls.UC_Player uC_Player5;
        private UserControls.UC_Player uC_Player6;
        private UserControls.UC_Player uC_Player7;
        private UserControls.UC_Player uC_Player8;
        private UserControls.UC_Player uC_Player3;
        private UserControls.UC_Player uC_Player4;
        private UserControls.UC_Player uC_Player2;
        private Panel panel_Footer;
        private Button btn_Generate;
    }
}