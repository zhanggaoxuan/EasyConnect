﻿namespace EasyConnect
{
	partial class InitialSetupWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialSetupWindow));
			this._finishButton = new System.Windows.Forms.Button();
			this._nextButton = new System.Windows.Forms.Button();
			this._previousButton = new System.Windows.Forms.Button();
			this._containerPanel = new System.Windows.Forms.Panel();
			this._introLabel = new System.Windows.Forms.Label();
			this._containerPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _finishButton
			// 
			this._finishButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._finishButton.Enabled = false;
			this._finishButton.Location = new System.Drawing.Point(680, 423);
			this._finishButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._finishButton.Name = "_finishButton";
			this._finishButton.Size = new System.Drawing.Size(100, 28);
			this._finishButton.TabIndex = 0;
			this._finishButton.Text = "Finish";
			this._finishButton.UseVisualStyleBackColor = true;
			this._finishButton.Click += new System.EventHandler(this._finishButton_Click);
			// 
			// _nextButton
			// 
			this._nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._nextButton.Location = new System.Drawing.Point(572, 423);
			this._nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._nextButton.Name = "_nextButton";
			this._nextButton.Size = new System.Drawing.Size(100, 28);
			this._nextButton.TabIndex = 1;
			this._nextButton.Text = "Next >";
			this._nextButton.UseVisualStyleBackColor = true;
			this._nextButton.Click += new System.EventHandler(this._nextButton_Click);
			// 
			// _previousButton
			// 
			this._previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._previousButton.Enabled = false;
			this._previousButton.Location = new System.Drawing.Point(464, 423);
			this._previousButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._previousButton.Name = "_previousButton";
			this._previousButton.Size = new System.Drawing.Size(100, 28);
			this._previousButton.TabIndex = 2;
			this._previousButton.Text = "< Previous";
			this._previousButton.UseVisualStyleBackColor = true;
			this._previousButton.Click += new System.EventHandler(this._previousButton_Click);
			// 
			// _containerPanel
			// 
			this._containerPanel.Controls.Add(this._introLabel);
			this._containerPanel.Location = new System.Drawing.Point(-1, -1);
			this._containerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this._containerPanel.Name = "_containerPanel";
			this._containerPanel.Size = new System.Drawing.Size(800, 416);
			this._containerPanel.TabIndex = 3;
			// 
			// _introLabel
			// 
			this._introLabel.AutoSize = true;
			this._introLabel.Location = new System.Drawing.Point(17, 12);
			this._introLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this._introLabel.Name = "_introLabel";
			this._introLabel.Size = new System.Drawing.Size(726, 34);
			this._introLabel.TabIndex = 0;
			this._introLabel.Text = "We will now walk you through the setup process for encryption keys to protect you" +
    "r bookmarks file.  Click \"Next\" to \r\ncontinue.";
			// 
			// InitialSetupWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 466);
			this.ControlBox = false;
			this.Controls.Add(this._containerPanel);
			this.Controls.Add(this._previousButton);
			this.Controls.Add(this._nextButton);
			this.Controls.Add(this._finishButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InitialSetupWindow";
			this.Text = "Encryption Setup";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InitialSetupWindow_KeyDown);
			this._containerPanel.ResumeLayout(false);
			this._containerPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button _finishButton;
		private System.Windows.Forms.Button _nextButton;
		private System.Windows.Forms.Button _previousButton;
		private System.Windows.Forms.Panel _containerPanel;
		private System.Windows.Forms.Label _introLabel;
	}
}