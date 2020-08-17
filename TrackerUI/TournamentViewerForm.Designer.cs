﻿namespace TrackerUI
{
	partial class TournamentViewerForm
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
			this.headerLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
			this.matchupListBox = new System.Windows.Forms.ListBox();
			this.teamOneName = new System.Windows.Forms.Label();
			this.teamOneScoreLabel = new System.Windows.Forms.Label();
			this.teamOneScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreLabel = new System.Windows.Forms.Label();
			this.teamTwoName = new System.Windows.Forms.Label();
			this.versusLabel = new System.Windows.Forms.Label();
			this.scoreButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(12, 9);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(224, 50);
			this.headerLabel.TabIndex = 0;
			this.headerLabel.Text = "Tournament: ";
			this.headerLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(53)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(242, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 50);
			this.label1.TabIndex = 1;
			this.label1.Text = " ";
			// 
			// tournamentName
			// 
			this.tournamentName.AutoSize = true;
			this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentName.Location = new System.Drawing.Point(242, 9);
			this.tournamentName.Name = "tournamentName";
			this.tournamentName.Size = new System.Drawing.Size(150, 50);
			this.tournamentName.TabIndex = 2;
			this.tournamentName.Text = "<none>";
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.roundLabel.Location = new System.Drawing.Point(14, 83);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(94, 37);
			this.roundLabel.TabIndex = 3;
			this.roundLabel.Text = "Round";
			// 
			// roundDropDown
			// 
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(114, 82);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(278, 38);
			this.roundDropDown.TabIndex = 4;
			// 
			// unplayedOnlyCheckbox
			// 
			this.unplayedOnlyCheckbox.AutoSize = true;
			this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(114, 138);
			this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
			this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(209, 41);
			this.unplayedOnlyCheckbox.TabIndex = 6;
			this.unplayedOnlyCheckbox.Text = "Unplayed Only";
			this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
			// 
			// matchupListBox
			// 
			this.matchupListBox.FormattingEnabled = true;
			this.matchupListBox.ItemHeight = 30;
			this.matchupListBox.Location = new System.Drawing.Point(21, 213);
			this.matchupListBox.Name = "matchupListBox";
			this.matchupListBox.Size = new System.Drawing.Size(371, 424);
			this.matchupListBox.TabIndex = 7;
			// 
			// teamOneName
			// 
			this.teamOneName.AutoSize = true;
			this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneName.Location = new System.Drawing.Point(508, 213);
			this.teamOneName.Name = "teamOneName";
			this.teamOneName.Size = new System.Drawing.Size(165, 37);
			this.teamOneName.TabIndex = 8;
			this.teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			this.teamOneScoreLabel.AutoSize = true;
			this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamOneScoreLabel.Location = new System.Drawing.Point(508, 271);
			this.teamOneScoreLabel.Name = "teamOneScoreLabel";
			this.teamOneScoreLabel.Size = new System.Drawing.Size(88, 37);
			this.teamOneScoreLabel.TabIndex = 9;
			this.teamOneScoreLabel.Text = "Score:";
			// 
			// teamOneScoreValue
			// 
			this.teamOneScoreValue.Location = new System.Drawing.Point(602, 274);
			this.teamOneScoreValue.Name = "teamOneScoreValue";
			this.teamOneScoreValue.Size = new System.Drawing.Size(131, 35);
			this.teamOneScoreValue.TabIndex = 10;
			// 
			// teamTwoScoreValue
			// 
			this.teamTwoScoreValue.Location = new System.Drawing.Point(602, 522);
			this.teamTwoScoreValue.Name = "teamTwoScoreValue";
			this.teamTwoScoreValue.Size = new System.Drawing.Size(131, 35);
			this.teamTwoScoreValue.TabIndex = 13;
			// 
			// teamTwoScoreLabel
			// 
			this.teamTwoScoreLabel.AutoSize = true;
			this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoScoreLabel.Location = new System.Drawing.Point(508, 519);
			this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
			this.teamTwoScoreLabel.Size = new System.Drawing.Size(88, 37);
			this.teamTwoScoreLabel.TabIndex = 12;
			this.teamTwoScoreLabel.Text = "Score:";
			// 
			// teamTwoName
			// 
			this.teamTwoName.AutoSize = true;
			this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamTwoName.Location = new System.Drawing.Point(508, 461);
			this.teamTwoName.Name = "teamTwoName";
			this.teamTwoName.Size = new System.Drawing.Size(165, 37);
			this.teamTwoName.TabIndex = 11;
			this.teamTwoName.Text = "<team two>";
			this.teamTwoName.Click += new System.EventHandler(this.teamTwoName_Click);
			// 
			// versusLabel
			// 
			this.versusLabel.AutoSize = true;
			this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.versusLabel.Location = new System.Drawing.Point(589, 371);
			this.versusLabel.Name = "versusLabel";
			this.versusLabel.Size = new System.Drawing.Size(84, 37);
			this.versusLabel.TabIndex = 14;
			this.versusLabel.Text = "- VS -";
			// 
			// scoreButton
			// 
			this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreButton.Location = new System.Drawing.Point(753, 356);
			this.scoreButton.Name = "scoreButton";
			this.scoreButton.Size = new System.Drawing.Size(214, 73);
			this.scoreButton.TabIndex = 15;
			this.scoreButton.Text = "Score";
			this.scoreButton.UseVisualStyleBackColor = true;
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1111, 720);
			this.Controls.Add(this.scoreButton);
			this.Controls.Add(this.versusLabel);
			this.Controls.Add(this.teamTwoScoreValue);
			this.Controls.Add(this.teamTwoScoreLabel);
			this.Controls.Add(this.teamTwoName);
			this.Controls.Add(this.teamOneScoreValue);
			this.Controls.Add(this.teamOneScoreLabel);
			this.Controls.Add(this.teamOneName);
			this.Controls.Add(this.matchupListBox);
			this.Controls.Add(this.unplayedOnlyCheckbox);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.tournamentName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "TournamentViewerForm";
			this.Text = "Tournament Viewer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label tournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
		private System.Windows.Forms.ListBox matchupListBox;
		private System.Windows.Forms.Label teamOneName;
		private System.Windows.Forms.Label teamOneScoreLabel;
		private System.Windows.Forms.TextBox teamOneScoreValue;
		private System.Windows.Forms.TextBox teamTwoScoreValue;
		private System.Windows.Forms.Label teamTwoScoreLabel;
		private System.Windows.Forms.Label teamTwoName;
		private System.Windows.Forms.Label versusLabel;
		private System.Windows.Forms.Button scoreButton;
	}
}

