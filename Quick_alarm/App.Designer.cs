
using System.Windows.Forms;

namespace Quick_alarm
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.button1 = new Quick_alarm.RoundedButton();
            this.button2 = new Quick_alarm.RoundedButton();
            this.button3 = new Quick_alarm.RoundedButton();
            this.button4 = new Quick_alarm.RoundedButton();
            this.button5 = new Quick_alarm.RoundedButton();
            this.button6 = new Quick_alarm.RoundedButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSet = new Quick_alarm.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new Quick_alarm.RoundedButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMinimize = new Quick_alarm.RoundedButton();
            this.textBoxMessage = new Quick_alarm.TextBoxUnderlined();
            this.popupMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button1.BorderColor = System.Drawing.Color.Transparent;
            this.button1.BorderRadius = 30;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "5 minutes";
            this.button1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button2.BorderColor = System.Drawing.Color.Transparent;
            this.button2.BorderRadius = 30;
            this.button2.BorderSize = 0;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button2.Location = new System.Drawing.Point(110, 159);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "10 minutes";
            this.button2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button3.BorderColor = System.Drawing.Color.Transparent;
            this.button3.BorderRadius = 30;
            this.button3.BorderSize = 0;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button3.Location = new System.Drawing.Point(208, 159);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button3.Size = new System.Drawing.Size(96, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "15 minutes";
            this.button3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button4.BorderColor = System.Drawing.Color.Transparent;
            this.button4.BorderRadius = 30;
            this.button4.BorderSize = 0;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button4.Location = new System.Drawing.Point(12, 203);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button4.Size = new System.Drawing.Size(96, 36);
            this.button4.TabIndex = 3;
            this.button4.Text = "20 minutes";
            this.button4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button5.BorderColor = System.Drawing.Color.Transparent;
            this.button5.BorderRadius = 30;
            this.button5.BorderSize = 0;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button5.Location = new System.Drawing.Point(110, 203);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button5.Size = new System.Drawing.Size(96, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "25 minutes";
            this.button5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.button6.BorderColor = System.Drawing.Color.Black;
            this.button6.BorderRadius = 30;
            this.button6.BorderSize = 0;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button6.Location = new System.Drawing.Point(208, 203);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button6.Size = new System.Drawing.Size(96, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "30 minutes";
            this.button6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSet, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 276);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 15, 2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "HH\':\'mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(66, 7, 3, 3);
            this.dateTimePicker1.MaximumSize = new System.Drawing.Size(61, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 2, 5, 16, 23, 49, 515);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(0, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(60, 32);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 5, 16, 23, 49, 518);
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.buttonSet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.buttonSet.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.buttonSet.BorderRadius = 2;
            this.buttonSet.BorderSize = 1;
            this.buttonSet.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.buttonSet.Location = new System.Drawing.Point(160, 24);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(0, 24, 0, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.buttonSet.Size = new System.Drawing.Size(61, 32);
            this.buttonSet.TabIndex = 1;
            this.buttonSet.Text = "Set";
            this.buttonSet.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.ButtonSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(84, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Set alarm after:";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.BorderColor = System.Drawing.Color.Black;
            this.buttonClose.BorderRadius = 0;
            this.buttonClose.BorderSize = 1;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.Location = new System.Drawing.Point(280, 4);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 28);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.TabStop = false;
            this.buttonClose.Text = "X";
            this.buttonClose.TextColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Quick Alarm Text";
            this.notifyIcon1.BalloonTipTitle = "Quick Alarm Title";
            this.notifyIcon1.ContextMenuStrip = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Quick Alarm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            this.notifyIcon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseUp);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1});
            this.contextMenu1.Name = "contextMenuStrip1";
            this.contextMenu1.Size = new System.Drawing.Size(120, 30);
            this.contextMenu1.Click += new System.EventHandler(this.About_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.BackColor = System.Drawing.Color.Snow;
            this.menuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(119, 26);
            this.menuItem1.Text = "About";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(109)))), ((int)(((byte)(35)))));
            this.label5.Location = new System.Drawing.Point(44, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "                                                       ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(109)))), ((int)(((byte)(35)))));
            this.label7.Location = new System.Drawing.Point(96, 254);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "or choose an hour";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BorderColor = System.Drawing.Color.Black;
            this.buttonMinimize.BorderRadius = 0;
            this.buttonMinimize.BorderSize = 1;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimize.ForeColor = System.Drawing.Color.Black;
            this.buttonMinimize.Location = new System.Drawing.Point(244, 4);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(32, 28);
            this.buttonMinimize.TabIndex = 16;
            this.buttonMinimize.Text = "__";
            this.buttonMinimize.TextColor = System.Drawing.Color.Black;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.Snow;
            this.textBoxMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(109)))), ((int)(((byte)(35)))));
            this.textBoxMessage.BorderSize = 3;
            this.textBoxMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMessage.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxMessage.Location = new System.Drawing.Point(62, 49);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMessage.PlaceholderText = "      Your message";
            this.textBoxMessage.Size = new System.Drawing.Size(190, 39);
            this.textBoxMessage.TabIndex = 17;
            this.textBoxMessage.TextMessage = "";
            this.textBoxMessage.UnderlinedStyle = true;
            // 
            // popupMessage
            // 
            this.popupMessage.BackColor = System.Drawing.Color.Transparent;
            this.popupMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.popupMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(109)))), ((int)(((byte)(35)))));
            this.popupMessage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.popupMessage.Location = new System.Drawing.Point(0, 248);
            this.popupMessage.Name = "popupMessage";
            this.popupMessage.Size = new System.Drawing.Size(316, 47);
            this.popupMessage.TabIndex = 18;
            this.popupMessage.Text = "Alarm in ";
            this.popupMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.popupMessage.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(316, 365);
            this.ContextMenuStrip = this.contextMenu1;
            this.ControlBox = false;
            this.Controls.Add(this.popupMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quick Alarm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton button1;
        private RoundedButton button2;
        private RoundedButton button3;
        private RoundedButton button4;
        private RoundedButton button5;
        private RoundedButton button6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private RoundedButton buttonClose;
        private NotifyIcon notifyIcon1;
        private Label label5;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private RoundedButton buttonSet;
        private RoundedButton buttonMinimize;
        private TextBoxUnderlined textBoxMessage;
        private ContextMenuStrip contextMenu1;
        private ToolStripMenuItem menuItem1;
        private Label popupMessage;
        private Timer timer1;
    }
}

