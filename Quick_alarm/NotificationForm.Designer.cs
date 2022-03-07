using System.Drawing;

namespace Quick_alarm
{
    partial class NotificationForm
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
            System.Windows.Forms.Label label1;
            this.buttonOk = new Quick_alarm.RoundedButton();
            this.message = new Quick_alarm.ReadOnlyTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimeNow = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Image = global::Quick_alarm.Properties.Resources.alarm_clock;
            label1.Location = new System.Drawing.Point(108, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 37);
            label1.TabIndex = 7;
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.buttonOk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(136)))), ((int)(((byte)(18)))));
            this.buttonOk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.buttonOk.BorderRadius = 40;
            this.buttonOk.BorderSize = 0;
            this.buttonOk.FlatAppearance.BorderSize = 0;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.buttonOk.Image = global::Quick_alarm.Properties.Resources.layer;
            this.buttonOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOk.Location = new System.Drawing.Point(81, 272);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOk.Size = new System.Drawing.Size(154, 49);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "OK";
            this.buttonOk.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.Snow;
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.message.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(109)))), ((int)(((byte)(35)))));
            this.message.Location = new System.Drawing.Point(3, 200);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(310, 66);
            this.message.TabIndex = 4;
            this.message.Text = "Alarm!";
            this.message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::Quick_alarm.Properties.Resources.header;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelTimeNow, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelTimeNow
            // 
            this.labelTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeNow.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(5)))), ((int)(((byte)(15)))));
            this.labelTimeNow.Location = new System.Drawing.Point(3, 0);
            this.labelTimeNow.Name = "labelTimeNow";
            this.labelTimeNow.Size = new System.Drawing.Size(310, 100);
            this.labelTimeNow.TabIndex = 16;
            this.labelTimeNow.Text = "00:00";
            this.labelTimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(316, 365);
            this.ControlBox = false;
            this.Controls.Add(label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.Text = "Quick Alarm";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton buttonOk;
        private ReadOnlyTextBox message;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTimeNow;
    }
}