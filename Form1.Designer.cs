
namespace TimeX
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel BorderRight;
            System.Windows.Forms.Panel BorderLeft;
            System.Windows.Forms.Panel BorderTop;
            System.Windows.Forms.Panel BorderDown;
            this.CloseWindowButton = new System.Windows.Forms.Button();
            this.MinimizeWindowButton = new System.Windows.Forms.Button();
            this.WindowNameLabel = new System.Windows.Forms.Label();
            this.TimeXNameLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SliderMenuButton = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.BreakTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PlayInLoopCheckBox = new System.Windows.Forms.CheckBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.TimeXNameTextBox = new System.Windows.Forms.TextBox();
            this.OffAlarmButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            BorderRight = new System.Windows.Forms.Panel();
            BorderLeft = new System.Windows.Forms.Panel();
            BorderTop = new System.Windows.Forms.Panel();
            BorderDown = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderRight
            // 
            BorderRight.BackColor = System.Drawing.Color.DodgerBlue;
            BorderRight.Location = new System.Drawing.Point(404, 0);
            BorderRight.Name = "BorderRight";
            BorderRight.Size = new System.Drawing.Size(1, 590);
            BorderRight.TabIndex = 8;
            // 
            // BorderLeft
            // 
            BorderLeft.BackColor = System.Drawing.Color.DodgerBlue;
            BorderLeft.Location = new System.Drawing.Point(0, 0);
            BorderLeft.Name = "BorderLeft";
            BorderLeft.Size = new System.Drawing.Size(1, 590);
            BorderLeft.TabIndex = 9;
            // 
            // BorderTop
            // 
            BorderTop.BackColor = System.Drawing.Color.DodgerBlue;
            BorderTop.Location = new System.Drawing.Point(0, 0);
            BorderTop.Name = "BorderTop";
            BorderTop.Size = new System.Drawing.Size(405, 1);
            BorderTop.TabIndex = 11;
            // 
            // BorderDown
            // 
            BorderDown.BackColor = System.Drawing.Color.DodgerBlue;
            BorderDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            BorderDown.Location = new System.Drawing.Point(0, 589);
            BorderDown.Name = "BorderDown";
            BorderDown.Size = new System.Drawing.Size(405, 1);
            BorderDown.TabIndex = 12;
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CloseWindowButton.FlatAppearance.BorderSize = 0;
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseWindowButton.ForeColor = System.Drawing.SystemColors.Window;
            this.CloseWindowButton.Location = new System.Drawing.Point(366, 13);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(27, 23);
            this.CloseWindowButton.TabIndex = 0;
            this.CloseWindowButton.Text = "X";
            this.CloseWindowButton.UseVisualStyleBackColor = true;
            this.CloseWindowButton.Click += new System.EventHandler(this.CloseWindowButton_Click);
            // 
            // MinimizeWindowButton
            // 
            this.MinimizeWindowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeWindowButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.MinimizeWindowButton.FlatAppearance.BorderSize = 0;
            this.MinimizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindowButton.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinimizeWindowButton.ForeColor = System.Drawing.SystemColors.Window;
            this.MinimizeWindowButton.Location = new System.Drawing.Point(333, 13);
            this.MinimizeWindowButton.Name = "MinimizeWindowButton";
            this.MinimizeWindowButton.Size = new System.Drawing.Size(27, 23);
            this.MinimizeWindowButton.TabIndex = 1;
            this.MinimizeWindowButton.Text = "_";
            this.MinimizeWindowButton.UseVisualStyleBackColor = true;
            this.MinimizeWindowButton.Click += new System.EventHandler(this.MinimizeWindowButton_Click);
            // 
            // WindowNameLabel
            // 
            this.WindowNameLabel.AutoSize = true;
            this.WindowNameLabel.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WindowNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.WindowNameLabel.Location = new System.Drawing.Point(12, 17);
            this.WindowNameLabel.Name = "WindowNameLabel";
            this.WindowNameLabel.Size = new System.Drawing.Size(59, 19);
            this.WindowNameLabel.TabIndex = 2;
            this.WindowNameLabel.Text = "TimeX";
            // 
            // TimeXNameLabel
            // 
            this.TimeXNameLabel.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeXNameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.TimeXNameLabel.Location = new System.Drawing.Point(24, 80);
            this.TimeXNameLabel.Name = "TimeXNameLabel";
            this.TimeXNameLabel.Size = new System.Drawing.Size(354, 42);
            this.TimeXNameLabel.TabIndex = 3;
            this.TimeXNameLabel.Text = "Eye protection";
            this.TimeXNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Unispace", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.TimeLabel.Location = new System.Drawing.Point(34, 140);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(344, 115);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "00:20";
            this.TimeLabel.TextChanged += new System.EventHandler(this.TimeLabel_TextChanged);
            // 
            // SliderMenuButton
            // 
            this.SliderMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SliderMenuButton.FlatAppearance.BorderSize = 0;
            this.SliderMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SliderMenuButton.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SliderMenuButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SliderMenuButton.Location = new System.Drawing.Point(179, 0);
            this.SliderMenuButton.Name = "SliderMenuButton";
            this.SliderMenuButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SliderMenuButton.Size = new System.Drawing.Size(56, 54);
            this.SliderMenuButton.TabIndex = 5;
            this.SliderMenuButton.Text = "▲";
            this.SliderMenuButton.UseVisualStyleBackColor = true;
            this.SliderMenuButton.Click += new System.EventHandler(this.SliderMenuButton_Click);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.BreakTimeTextBox);
            this.Menu.Controls.Add(this.TimeTextBox);
            this.Menu.Controls.Add(this.PlayInLoopCheckBox);
            this.Menu.Controls.Add(this.ApplyButton);
            this.Menu.Controls.Add(this.TimeXNameTextBox);
            this.Menu.Controls.Add(this.SliderMenuButton);
            this.Menu.Location = new System.Drawing.Point(0, 530);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(405, 276);
            this.Menu.TabIndex = 6;
            // 
            // BreakTimeTextBox
            // 
            this.BreakTimeTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.BreakTimeTextBox.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BreakTimeTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BreakTimeTextBox.Location = new System.Drawing.Point(124, 143);
            this.BreakTimeTextBox.Mask = "00:00";
            this.BreakTimeTextBox.Name = "BreakTimeTextBox";
            this.BreakTimeTextBox.Size = new System.Drawing.Size(157, 23);
            this.BreakTimeTextBox.TabIndex = 10;
            this.BreakTimeTextBox.Text = "0001";
            this.BreakTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BreakTimeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.TimeTextBox.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.TimeTextBox.Location = new System.Drawing.Point(124, 103);
            this.TimeTextBox.Mask = "00:00";
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(157, 23);
            this.TimeTextBox.TabIndex = 9;
            this.TimeTextBox.Text = "0020";
            this.TimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // PlayInLoopCheckBox
            // 
            this.PlayInLoopCheckBox.Checked = true;
            this.PlayInLoopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayInLoopCheckBox.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayInLoopCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayInLoopCheckBox.Location = new System.Drawing.Point(124, 172);
            this.PlayInLoopCheckBox.Name = "PlayInLoopCheckBox";
            this.PlayInLoopCheckBox.Size = new System.Drawing.Size(122, 28);
            this.PlayInLoopCheckBox.TabIndex = 8;
            this.PlayInLoopCheckBox.Text = "Play in loop";
            this.PlayInLoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // ApplyButton
            // 
            this.ApplyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ApplyButton.FlatAppearance.BorderSize = 0;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ApplyButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ApplyButton.Location = new System.Drawing.Point(124, 221);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(157, 45);
            this.ApplyButton.TabIndex = 7;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // TimeXNameTextBox
            // 
            this.TimeXNameTextBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.TimeXNameTextBox.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeXNameTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.TimeXNameTextBox.Location = new System.Drawing.Point(124, 63);
            this.TimeXNameTextBox.MaxLength = 16;
            this.TimeXNameTextBox.Name = "TimeXNameTextBox";
            this.TimeXNameTextBox.PlaceholderText = "TimeX Name";
            this.TimeXNameTextBox.Size = new System.Drawing.Size(157, 23);
            this.TimeXNameTextBox.TabIndex = 6;
            this.TimeXNameTextBox.Text = "Eye protection";
            this.TimeXNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OffAlarmButton
            // 
            this.OffAlarmButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OffAlarmButton.FlatAppearance.BorderSize = 0;
            this.OffAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffAlarmButton.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OffAlarmButton.ForeColor = System.Drawing.SystemColors.Window;
            this.OffAlarmButton.Location = new System.Drawing.Point(77, 350);
            this.OffAlarmButton.Name = "OffAlarmButton";
            this.OffAlarmButton.Size = new System.Drawing.Size(254, 49);
            this.OffAlarmButton.TabIndex = 7;
            this.OffAlarmButton.Text = "Off alarm";
            this.OffAlarmButton.UseVisualStyleBackColor = true;
            this.OffAlarmButton.Click += new System.EventHandler(this.OffAlarmButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            // 
            // SystemTray
            // 
            this.SystemTray.Icon = global::TimeX.Resources.windowicon;
            this.SystemTray.Text = "Eye protection";
            this.SystemTray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemTray_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(405, 590);
            this.Controls.Add(BorderDown);
            this.Controls.Add(BorderTop);
            this.Controls.Add(BorderLeft);
            this.Controls.Add(BorderRight);
            this.Controls.Add(this.OffAlarmButton);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeXNameLabel);
            this.Controls.Add(this.WindowNameLabel);
            this.Controls.Add(this.MinimizeWindowButton);
            this.Controls.Add(this.CloseWindowButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::TimeX.Resources.windowicon;
            this.MaximumSize = new System.Drawing.Size(405, 590);
            this.MinimumSize = new System.Drawing.Size(405, 590);
            this.Name = "MainWindow";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeX";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseWindowButton;
        private System.Windows.Forms.Button MinimizeWindowButton;
        private System.Windows.Forms.Label WindowNameLabel;
        private System.Windows.Forms.Label TimeXNameLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button SliderMenuButton;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox TimeXNameTextBox;
        private System.Windows.Forms.MaskedTextBox BreakTimeTextBox;
        private System.Windows.Forms.MaskedTextBox TimeTextBox;
        private System.Windows.Forms.CheckBox PlayInLoopCheckBox;
        private System.Windows.Forms.Button OffAlarmButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Panel BorderTop;
        private System.Windows.Forms.Panel BorderDown;
        private System.Windows.Forms.NotifyIcon SystemTray;
    }
}

