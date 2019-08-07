namespace CustomMessageBox
{
    partial class CMForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMForm));
            this.CreateMessageBoxButton = new System.Windows.Forms.Button();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.CaptionTextBox = new System.Windows.Forms.TextBox();
            this.IconComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonsComboBox = new System.Windows.Forms.ComboBox();
            this.OptionsComboBox = new System.Windows.Forms.ComboBox();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.IconLabel = new System.Windows.Forms.Label();
            this.ButtonsLabel = new System.Windows.Forms.Label();
            this.OptionsLabel = new System.Windows.Forms.Label();
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CreateMessageBoxButton
            // 
            this.CreateMessageBoxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateMessageBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CreateMessageBoxButton.Location = new System.Drawing.Point(293, 186);
            this.CreateMessageBoxButton.Name = "CreateMessageBoxButton";
            this.CreateMessageBoxButton.Size = new System.Drawing.Size(89, 35);
            this.CreateMessageBoxButton.TabIndex = 5;
            this.CreateMessageBoxButton.Text = "生成";
            this.CreateMessageBoxButton.UseVisualStyleBackColor = true;
            this.CreateMessageBoxButton.Click += new System.EventHandler(this.CreateMessageBox);
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(76, 57);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(200, 52);
            this.ContentTextBox.TabIndex = 1;
            // 
            // CaptionTextBox
            // 
            this.CaptionTextBox.Location = new System.Drawing.Point(76, 22);
            this.CaptionTextBox.Name = "CaptionTextBox";
            this.CaptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.CaptionTextBox.TabIndex = 0;
            // 
            // IconComboBox
            // 
            this.IconComboBox.FormattingEnabled = true;
            this.IconComboBox.Items.AddRange(new object[] {
            "Asterisk",
            "Error",
            "Exclamation",
            "Hand",
            "Information",
            "None",
            "Question",
            "Stop",
            "Warning"});
            this.IconComboBox.Location = new System.Drawing.Point(76, 140);
            this.IconComboBox.Name = "IconComboBox";
            this.IconComboBox.Size = new System.Drawing.Size(200, 21);
            this.IconComboBox.TabIndex = 2;
            this.IconComboBox.Text = "选择要展示的图标";
            // 
            // ButtonsComboBox
            // 
            this.ButtonsComboBox.FormattingEnabled = true;
            this.ButtonsComboBox.Items.AddRange(new object[] {
            "AbortRetryIgnore",
            "OK",
            "OKCancel",
            "RetryCancel",
            "YesNo",
            "YesNoCancel"});
            this.ButtonsComboBox.Location = new System.Drawing.Point(76, 170);
            this.ButtonsComboBox.Name = "ButtonsComboBox";
            this.ButtonsComboBox.Size = new System.Drawing.Size(200, 21);
            this.ButtonsComboBox.TabIndex = 3;
            this.ButtonsComboBox.Text = "选择要展示的按钮";
            // 
            // OptionsComboBox
            // 
            this.OptionsComboBox.FormattingEnabled = true;
            this.OptionsComboBox.Items.AddRange(new object[] {
            "None",
            "DefaultDesktopOnly",
            "RightAlign",
            "RtlReading",
            "ServiceNotification"});
            this.OptionsComboBox.Location = new System.Drawing.Point(76, 200);
            this.OptionsComboBox.Name = "OptionsComboBox";
            this.OptionsComboBox.Size = new System.Drawing.Size(200, 21);
            this.OptionsComboBox.TabIndex = 4;
            this.OptionsComboBox.Text = "选择展示方式";
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaptionLabel.Location = new System.Drawing.Point(21, 25);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(31, 13);
            this.CaptionLabel.TabIndex = 6;
            this.CaptionLabel.Text = "标题";
            this.CaptionLabel.Click += new System.EventHandler(this.GetHelp);
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContentLabel.Location = new System.Drawing.Point(21, 60);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(31, 13);
            this.ContentLabel.TabIndex = 7;
            this.ContentLabel.Text = "内容";
            this.ContentLabel.Click += new System.EventHandler(this.GetHelp);
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconLabel.Location = new System.Drawing.Point(21, 143);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(31, 13);
            this.IconLabel.TabIndex = 7;
            this.IconLabel.Text = "图标";
            this.IconLabel.Click += new System.EventHandler(this.GetHelp);
            // 
            // ButtonsLabel
            // 
            this.ButtonsLabel.AutoSize = true;
            this.ButtonsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonsLabel.Location = new System.Drawing.Point(21, 173);
            this.ButtonsLabel.Name = "ButtonsLabel";
            this.ButtonsLabel.Size = new System.Drawing.Size(31, 13);
            this.ButtonsLabel.TabIndex = 7;
            this.ButtonsLabel.Text = "按钮";
            this.ButtonsLabel.Click += new System.EventHandler(this.GetHelp);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsLabel.Location = new System.Drawing.Point(21, 203);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(31, 13);
            this.OptionsLabel.TabIndex = 7;
            this.OptionsLabel.Text = "布局";
            this.OptionsLabel.Click += new System.EventHandler(this.GetHelp);
            // 
            // HelpToolTip
            // 
            this.HelpToolTip.AutoPopDelay = 5000;
            this.HelpToolTip.InitialDelay = 200;
            this.HelpToolTip.IsBalloon = true;
            this.HelpToolTip.ReshowDelay = 100;
            // 
            // CMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 237);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.ButtonsLabel);
            this.Controls.Add(this.IconLabel);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.CaptionLabel);
            this.Controls.Add(this.OptionsComboBox);
            this.Controls.Add(this.ButtonsComboBox);
            this.Controls.Add(this.IconComboBox);
            this.Controls.Add(this.CaptionTextBox);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.CreateMessageBoxButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CMForm";
            this.Text = "自定义消息框生成器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitApp);
            this.Load += new System.EventHandler(this.AppStart);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMessageBoxButton;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.TextBox CaptionTextBox;
        private System.Windows.Forms.ComboBox IconComboBox;
        private System.Windows.Forms.ComboBox ButtonsComboBox;
        private System.Windows.Forms.ComboBox OptionsComboBox;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Label ButtonsLabel;
        private System.Windows.Forms.Label OptionsLabel;
        private System.Windows.Forms.ToolTip HelpToolTip;
    }
}

