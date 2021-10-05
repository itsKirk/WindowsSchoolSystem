
namespace SchoolSystem.Core.Screens
{
  partial class SettingsControl
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
      this.components = new System.ComponentModel.Container();
      this.LayoutPanel = new System.Windows.Forms.Panel();
      this.SchoolSettingGroupBox = new System.Windows.Forms.GroupBox();
      this.LogoBox = new System.Windows.Forms.PictureBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
      this.LanguageComboBox = new System.Windows.Forms.ComboBox();
      this.SchoolNameTextBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.HeaderPanel = new System.Windows.Forms.Panel();
      this.CloseBox = new System.Windows.Forms.PictureBox();
      this.OFD = new System.Windows.Forms.OpenFileDialog();
      this.ApplicationToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.LayoutPanel.SuspendLayout();
      this.SchoolSettingGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
      this.HeaderPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
      this.SuspendLayout();
      // 
      // LayoutPanel
      // 
      this.LayoutPanel.Controls.Add(this.SchoolSettingGroupBox);
      this.LayoutPanel.Controls.Add(this.HeaderPanel);
      this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.LayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.LayoutPanel.Name = "LayoutPanel";
      this.LayoutPanel.Size = new System.Drawing.Size(1014, 657);
      this.LayoutPanel.TabIndex = 0;
      this.LayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPanel_Paint);
      // 
      // SchoolSettingGroupBox
      // 
      this.SchoolSettingGroupBox.Controls.Add(this.LogoBox);
      this.SchoolSettingGroupBox.Controls.Add(this.label10);
      this.SchoolSettingGroupBox.Controls.Add(this.label7);
      this.SchoolSettingGroupBox.Controls.Add(this.textBox1);
      this.SchoolSettingGroupBox.Controls.Add(this.label8);
      this.SchoolSettingGroupBox.Controls.Add(this.label2);
      this.SchoolSettingGroupBox.Controls.Add(this.label1);
      this.SchoolSettingGroupBox.Controls.Add(this.textBox6);
      this.SchoolSettingGroupBox.Controls.Add(this.textBox2);
      this.SchoolSettingGroupBox.Controls.Add(this.CurrencyComboBox);
      this.SchoolSettingGroupBox.Controls.Add(this.LanguageComboBox);
      this.SchoolSettingGroupBox.Controls.Add(this.SchoolNameTextBox);
      this.SchoolSettingGroupBox.Controls.Add(this.label3);
      this.SchoolSettingGroupBox.Controls.Add(this.label9);
      this.SchoolSettingGroupBox.Controls.Add(this.textBox3);
      this.SchoolSettingGroupBox.Controls.Add(this.label6);
      this.SchoolSettingGroupBox.Controls.Add(this.label4);
      this.SchoolSettingGroupBox.Controls.Add(this.textBox5);
      this.SchoolSettingGroupBox.Controls.Add(this.textBox4);
      this.SchoolSettingGroupBox.Controls.Add(this.label5);
      this.SchoolSettingGroupBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SchoolSettingGroupBox.Location = new System.Drawing.Point(3, 29);
      this.SchoolSettingGroupBox.Name = "SchoolSettingGroupBox";
      this.SchoolSettingGroupBox.Size = new System.Drawing.Size(941, 372);
      this.SchoolSettingGroupBox.TabIndex = 5;
      this.SchoolSettingGroupBox.TabStop = false;
      this.SchoolSettingGroupBox.Text = "School Details";
      // 
      // LogoBox
      // 
      this.LogoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.LogoBox.Image = global::SchoolSystem.Core.Properties.Resources.logo;
      this.LogoBox.Location = new System.Drawing.Point(546, 247);
      this.LogoBox.Name = "LogoBox";
      this.LogoBox.Size = new System.Drawing.Size(115, 115);
      this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.LogoBox.TabIndex = 8;
      this.LogoBox.TabStop = false;
      this.ApplicationToolTip.SetToolTip(this.LogoBox, "Click to browse");
      this.LogoBox.Click += new System.EventHandler(this.LogoBox_Click);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(510, 262);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(34, 16);
      this.label10.TabIndex = 7;
      this.label10.Text = "Logo";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(45, 93);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(36, 16);
      this.label7.TabIndex = 5;
      this.label7.Text = "Prefix";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(83, 90);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(358, 21);
      this.textBox1.TabIndex = 6;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(40, 210);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(41, 16);
      this.label8.TabIndex = 2;
      this.label8.Text = "Motto";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(32, 134);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 16);
      this.label2.TabIndex = 2;
      this.label2.Text = "Address";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(1, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 16);
      this.label1.TabIndex = 2;
      this.label1.Text = "School Name";
      // 
      // textBox6
      // 
      this.textBox6.Location = new System.Drawing.Point(83, 202);
      this.textBox6.Multiline = true;
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new System.Drawing.Size(358, 61);
      this.textBox6.TabIndex = 3;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(83, 126);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(358, 61);
      this.textBox2.TabIndex = 3;
      // 
      // CurrencyComboBox
      // 
      this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CurrencyComboBox.FormattingEnabled = true;
      this.CurrencyComboBox.Items.AddRange(new object[] {
            "Ksh"});
      this.CurrencyComboBox.Location = new System.Drawing.Point(546, 202);
      this.CurrencyComboBox.Name = "CurrencyComboBox";
      this.CurrencyComboBox.Size = new System.Drawing.Size(358, 24);
      this.CurrencyComboBox.TabIndex = 4;
      // 
      // LanguageComboBox
      // 
      this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.LanguageComboBox.FormattingEnabled = true;
      this.LanguageComboBox.Items.AddRange(new object[] {
            "English(Kenya)"});
      this.LanguageComboBox.Location = new System.Drawing.Point(546, 163);
      this.LanguageComboBox.Name = "LanguageComboBox";
      this.LanguageComboBox.Size = new System.Drawing.Size(358, 24);
      this.LanguageComboBox.TabIndex = 4;
      // 
      // SchoolNameTextBox
      // 
      this.SchoolNameTextBox.Location = new System.Drawing.Point(83, 52);
      this.SchoolNameTextBox.Name = "SchoolNameTextBox";
      this.SchoolNameTextBox.Size = new System.Drawing.Size(358, 21);
      this.SchoolNameTextBox.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(455, 55);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Phone Number";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(487, 206);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(57, 16);
      this.label9.TabIndex = 2;
      this.label9.Text = "Currency";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(546, 52);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(358, 21);
      this.textBox3.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(480, 167);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(64, 16);
      this.label6.TabIndex = 2;
      this.label6.Text = "Language";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(493, 93);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 16);
      this.label4.TabIndex = 2;
      this.label4.Text = "Website";
      // 
      // textBox5
      // 
      this.textBox5.Location = new System.Drawing.Point(546, 126);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new System.Drawing.Size(358, 21);
      this.textBox5.TabIndex = 3;
      // 
      // textBox4
      // 
      this.textBox4.Location = new System.Drawing.Point(546, 89);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(358, 21);
      this.textBox4.TabIndex = 3;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(464, 130);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 16);
      this.label5.TabIndex = 2;
      this.label5.Text = "Email Address";
      // 
      // HeaderPanel
      // 
      this.HeaderPanel.Controls.Add(this.CloseBox);
      this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
      this.HeaderPanel.Name = "HeaderPanel";
      this.HeaderPanel.Size = new System.Drawing.Size(1014, 23);
      this.HeaderPanel.TabIndex = 0;
      // 
      // CloseBox
      // 
      this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
      this.CloseBox.Image = global::SchoolSystem.Core.Properties.Resources.icons8_delete_16;
      this.CloseBox.Location = new System.Drawing.Point(991, 0);
      this.CloseBox.Name = "CloseBox";
      this.CloseBox.Size = new System.Drawing.Size(23, 23);
      this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.CloseBox.TabIndex = 0;
      this.CloseBox.TabStop = false;
      this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
      // 
      // ApplicationToolTip
      // 
      this.ApplicationToolTip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
      // 
      // SettingsControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.LayoutPanel);
      this.Name = "SettingsControl";
      this.Size = new System.Drawing.Size(1014, 657);
      this.LayoutPanel.ResumeLayout(false);
      this.SchoolSettingGroupBox.ResumeLayout(false);
      this.SchoolSettingGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
      this.HeaderPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel LayoutPanel;
    private System.Windows.Forms.Panel HeaderPanel;
    private System.Windows.Forms.PictureBox CloseBox;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox SchoolNameTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox LanguageComboBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.GroupBox SchoolSettingGroupBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.ComboBox CurrencyComboBox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.PictureBox LogoBox;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.OpenFileDialog OFD;
    private System.Windows.Forms.ToolTip ApplicationToolTip;
  }
}
