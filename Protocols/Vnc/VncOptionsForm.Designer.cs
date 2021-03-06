﻿namespace EasyConnect.Protocols.Vnc
{
    partial class VncOptionsForm
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
            System.Security.SecureString secureString1 = new System.Security.SecureString();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VncOptionsForm));
            this._displayLabel = new System.Windows.Forms.Label();
            this._displayNumberLabel = new System.Windows.Forms.Label();
            this._flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this._generalPanel = new System.Windows.Forms.Panel();
            this._inheritedPasswordLabel = new System.Windows.Forms.Label();
            this._passwordTextBox = new SecurePasswordTextBox.SecureTextBox();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._generalLabel = new System.Windows.Forms.Label();
            this._hostPanel = new System.Windows.Forms.Panel();
            this._portLabel = new System.Windows.Forms.Label();
            this._hostNameLabel = new System.Windows.Forms.Label();
            this._hostNameTextBox = new System.Windows.Forms.TextBox();
            this._hostLabel = new System.Windows.Forms.Label();
            this._displayPanel = new System.Windows.Forms.Panel();
            this._viewOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this._viewOnlyLabel = new System.Windows.Forms.Label();
            this._displayUpDown = new System.Windows.Forms.NumericUpDown();
            this._behaviorPanel = new System.Windows.Forms.Panel();
            this._clipboardCheckbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this._clipboardLabel = new System.Windows.Forms.Label();
            this._titleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._portTextBox = new System.Windows.Forms.TextBox();
            this._flowLayoutPanel.SuspendLayout();
            this._generalPanel.SuspendLayout();
            this._hostPanel.SuspendLayout();
            this._displayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._displayUpDown)).BeginInit();
            this._behaviorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _displayLabel
            // 
            this._displayLabel.AutoSize = true;
            this._displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._displayLabel.Location = new System.Drawing.Point(8, 11);
            this._displayLabel.Name = "_displayLabel";
            this._displayLabel.Size = new System.Drawing.Size(61, 21);
            this._displayLabel.TabIndex = 55;
            this._displayLabel.Text = "Display";
            // 
            // _displayNumberLabel
            // 
            this._displayNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._displayNumberLabel.Location = new System.Drawing.Point(31, 38);
            this._displayNumberLabel.Name = "_displayNumberLabel";
            this._displayNumberLabel.Size = new System.Drawing.Size(122, 20);
            this._displayNumberLabel.TabIndex = 53;
            this._displayNumberLabel.Text = "Display:";
            this._displayNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _flowLayoutPanel
            // 
            this._flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._flowLayoutPanel.AutoScroll = true;
            this._flowLayoutPanel.Controls.Add(this._generalPanel);
            this._flowLayoutPanel.Controls.Add(this._hostPanel);
            this._flowLayoutPanel.Controls.Add(this._displayPanel);
            this._flowLayoutPanel.Controls.Add(this._behaviorPanel);
            this._flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._flowLayoutPanel.Location = new System.Drawing.Point(0, 61);
            this._flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._flowLayoutPanel.Name = "_flowLayoutPanel";
            this._flowLayoutPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this._flowLayoutPanel.Size = new System.Drawing.Size(719, 400);
            this._flowLayoutPanel.TabIndex = 83;
            this._flowLayoutPanel.WrapContents = false;
            // 
            // _generalPanel
            // 
            this._generalPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._generalPanel.Controls.Add(this._inheritedPasswordLabel);
            this._generalPanel.Controls.Add(this._passwordTextBox);
            this._generalPanel.Controls.Add(this._passwordLabel);
            this._generalPanel.Controls.Add(this._generalLabel);
            this._generalPanel.Location = new System.Drawing.Point(18, 3);
            this._generalPanel.Name = "_generalPanel";
            this._generalPanel.Size = new System.Drawing.Size(684, 76);
            this._generalPanel.TabIndex = 86;
            // 
            // _inheritedPasswordLabel
            // 
            this._inheritedPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._inheritedPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._inheritedPasswordLabel.Location = new System.Drawing.Point(319, 42);
            this._inheritedPasswordLabel.Name = "_inheritedPasswordLabel";
            this._inheritedPasswordLabel.Size = new System.Drawing.Size(263, 16);
            this._inheritedPasswordLabel.TabIndex = 94;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(106, 41);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.PasswordChar = '*';
            this._passwordTextBox.SecureText = secureString1;
            this._passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this._passwordTextBox.TabIndex = 82;
            this._passwordTextBox.TextChanged += new System.EventHandler(this._passwordTextBox_TextChanged);
            // 
            // _passwordLabel
            // 
            this._passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(31, 39);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(125, 20);
            this._passwordLabel.TabIndex = 50;
            this._passwordLabel.Text = "Password:";
            this._passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _generalLabel
            // 
            this._generalLabel.AutoSize = true;
            this._generalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._generalLabel.Location = new System.Drawing.Point(8, 11);
            this._generalLabel.Name = "_generalLabel";
            this._generalLabel.Size = new System.Drawing.Size(64, 21);
            this._generalLabel.TabIndex = 51;
            this._generalLabel.Text = "General";
            // 
            // _hostPanel
            // 
            this._hostPanel.Controls.Add(this._portTextBox);
            this._hostPanel.Controls.Add(this._portLabel);
            this._hostPanel.Controls.Add(this._hostNameLabel);
            this._hostPanel.Controls.Add(this._hostNameTextBox);
            this._hostPanel.Controls.Add(this._hostLabel);
            this._hostPanel.Location = new System.Drawing.Point(18, 85);
            this._hostPanel.Name = "_hostPanel";
            this._hostPanel.Size = new System.Drawing.Size(684, 99);
            this._hostPanel.TabIndex = 84;
            // 
            // _portLabel
            // 
            this._portLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._portLabel.Location = new System.Drawing.Point(31, 61);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(122, 20);
            this._portLabel.TabIndex = 55;
            this._portLabel.Text = "Port:";
            this._portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _hostNameLabel
            // 
            this._hostNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._hostNameLabel.Location = new System.Drawing.Point(31, 38);
            this._hostNameLabel.Name = "_hostNameLabel";
            this._hostNameLabel.Size = new System.Drawing.Size(78, 20);
            this._hostNameLabel.TabIndex = 53;
            this._hostNameLabel.Text = "Host name:";
            this._hostNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _hostNameTextBox
            // 
            this._hostNameTextBox.Location = new System.Drawing.Point(115, 39);
            this._hostNameTextBox.Name = "_hostNameTextBox";
            this._hostNameTextBox.Size = new System.Drawing.Size(154, 20);
            this._hostNameTextBox.TabIndex = 52;
            // 
            // _hostLabel
            // 
            this._hostLabel.AutoSize = true;
            this._hostLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._hostLabel.Location = new System.Drawing.Point(8, 11);
            this._hostLabel.Name = "_hostLabel";
            this._hostLabel.Size = new System.Drawing.Size(42, 21);
            this._hostLabel.TabIndex = 54;
            this._hostLabel.Text = "Host";
            // 
            // _displayPanel
            // 
            this._displayPanel.Controls.Add(this._viewOnlyCheckbox);
            this._displayPanel.Controls.Add(this._viewOnlyLabel);
            this._displayPanel.Controls.Add(this._displayUpDown);
            this._displayPanel.Controls.Add(this._displayLabel);
            this._displayPanel.Controls.Add(this._displayNumberLabel);
            this._displayPanel.Location = new System.Drawing.Point(18, 190);
            this._displayPanel.Name = "_displayPanel";
            this._displayPanel.Size = new System.Drawing.Size(684, 103);
            this._displayPanel.TabIndex = 83;
            // 
            // _viewOnlyCheckbox
            // 
            this._viewOnlyCheckbox.AutoSize = true;
            this._viewOnlyCheckbox.Location = new System.Drawing.Point(115, 68);
            this._viewOnlyCheckbox.Name = "_viewOnlyCheckbox";
            this._viewOnlyCheckbox.Size = new System.Drawing.Size(15, 14);
            this._viewOnlyCheckbox.TabIndex = 84;
            this._viewOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // _viewOnlyLabel
            // 
            this._viewOnlyLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._viewOnlyLabel.Location = new System.Drawing.Point(31, 63);
            this._viewOnlyLabel.Name = "_viewOnlyLabel";
            this._viewOnlyLabel.Size = new System.Drawing.Size(125, 20);
            this._viewOnlyLabel.TabIndex = 83;
            this._viewOnlyLabel.Text = "View only?:";
            this._viewOnlyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _displayUpDown
            // 
            this._displayUpDown.Location = new System.Drawing.Point(115, 40);
            this._displayUpDown.Name = "_displayUpDown";
            this._displayUpDown.Size = new System.Drawing.Size(61, 20);
            this._displayUpDown.TabIndex = 81;
            // 
            // _behaviorPanel
            // 
            this._behaviorPanel.Controls.Add(this._clipboardCheckbox);
            this._behaviorPanel.Controls.Add(this.label2);
            this._behaviorPanel.Controls.Add(this._clipboardLabel);
            this._behaviorPanel.Location = new System.Drawing.Point(18, 299);
            this._behaviorPanel.Name = "_behaviorPanel";
            this._behaviorPanel.Size = new System.Drawing.Size(684, 80);
            this._behaviorPanel.TabIndex = 87;
            // 
            // _clipboardCheckbox
            // 
            this._clipboardCheckbox.AutoSize = true;
            this._clipboardCheckbox.Location = new System.Drawing.Point(152, 46);
            this._clipboardCheckbox.Name = "_clipboardCheckbox";
            this._clipboardCheckbox.Size = new System.Drawing.Size(15, 14);
            this._clipboardCheckbox.TabIndex = 82;
            this._clipboardCheckbox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Display";
            // 
            // _clipboardLabel
            // 
            this._clipboardLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clipboardLabel.Location = new System.Drawing.Point(31, 42);
            this._clipboardLabel.Name = "_clipboardLabel";
            this._clipboardLabel.Size = new System.Drawing.Size(125, 20);
            this._clipboardLabel.TabIndex = 54;
            this._clipboardLabel.Text = "Share clipboard?:";
            this._clipboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(97)))), ((int)(((byte)(102)))));
            this._titleLabel.Location = new System.Drawing.Point(24, 19);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(134, 30);
            this._titleLabel.TabIndex = 89;
            this._titleLabel.Text = "VNC Options";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(29, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 1);
            this.panel1.TabIndex = 90;
            // 
            // _portTextBox
            // 
            this._portTextBox.Location = new System.Drawing.Point(115, 63);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(63, 20);
            this._portTextBox.TabIndex = 59;
            this._portTextBox.Text = "5900";
            // 
            // VncOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._titleLabel);
            this.Controls.Add(this._flowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VncOptionsForm";
            this.Text = "VNC Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VncOptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.VncOptionsForm_Load);
            this._flowLayoutPanel.ResumeLayout(false);
            this._generalPanel.ResumeLayout(false);
            this._generalPanel.PerformLayout();
            this._hostPanel.ResumeLayout(false);
            this._hostPanel.PerformLayout();
            this._displayPanel.ResumeLayout(false);
            this._displayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._displayUpDown)).EndInit();
            this._behaviorPanel.ResumeLayout(false);
            this._behaviorPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _displayLabel;
        private System.Windows.Forms.Label _displayNumberLabel;
        private System.Windows.Forms.FlowLayoutPanel _flowLayoutPanel;
        private System.Windows.Forms.Panel _hostPanel;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.Label _hostNameLabel;
        private System.Windows.Forms.TextBox _hostNameTextBox;
		private System.Windows.Forms.Label _hostLabel;
        private System.Windows.Forms.Panel _displayPanel;
        private System.Windows.Forms.NumericUpDown _displayUpDown;
        private System.Windows.Forms.CheckBox _viewOnlyCheckbox;
        private System.Windows.Forms.Label _viewOnlyLabel;
		private System.Windows.Forms.Panel _generalPanel;
        private System.Windows.Forms.Label _passwordLabel;
		private System.Windows.Forms.Label _generalLabel;
        private SecurePasswordTextBox.SecureTextBox _passwordTextBox;
		private System.Windows.Forms.Label _inheritedPasswordLabel;
		private System.Windows.Forms.Label _titleLabel;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel _behaviorPanel;
        private System.Windows.Forms.CheckBox _clipboardCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _clipboardLabel;
        private System.Windows.Forms.TextBox _portTextBox;
    }
}