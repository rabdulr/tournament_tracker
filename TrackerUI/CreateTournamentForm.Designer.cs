namespace TrackerUI
{
	partial class CreateTournamentForm
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
			this.tournamentNameValue = new System.Windows.Forms.TextBox();
			this.tournamentNameLabel = new System.Windows.Forms.Label();
			this.entryFeeValue = new System.Windows.Forms.TextBox();
			this.entryFeeLabel = new System.Windows.Forms.Label();
			this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamLabel = new System.Windows.Forms.Label();
			this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
			this.addTeamButton = new System.Windows.Forms.Button();
			this.createPrizeButton = new System.Windows.Forms.Button();
			this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
			this.teamsPlayersLabel = new System.Windows.Forms.Label();
			this.deleteSelectedPlayersButton = new System.Windows.Forms.Button();
			this.deleteSelectedPrizesButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.prizesListBox = new System.Windows.Forms.ListBox();
			this.createTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(28, 18);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(317, 50);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameValue
			// 
			this.tournamentNameValue.Location = new System.Drawing.Point(54, 134);
			this.tournamentNameValue.Name = "tournamentNameValue";
			this.tournamentNameValue.Size = new System.Drawing.Size(291, 35);
			this.tournamentNameValue.TabIndex = 12;
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentNameLabel.Location = new System.Drawing.Point(47, 94);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
			this.tournamentNameLabel.TabIndex = 11;
			this.tournamentNameLabel.Text = "Tournament Name";
			this.tournamentNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// entryFeeValue
			// 
			this.entryFeeValue.Location = new System.Drawing.Point(184, 197);
			this.entryFeeValue.Name = "entryFeeValue";
			this.entryFeeValue.Size = new System.Drawing.Size(131, 35);
			this.entryFeeValue.TabIndex = 14;
			this.entryFeeValue.Text = "0";
			this.entryFeeValue.TextChanged += new System.EventHandler(this.entryFeeValue_TextChanged);
			// 
			// entryFeeLabel
			// 
			this.entryFeeLabel.AutoSize = true;
			this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.entryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.entryFeeLabel.Location = new System.Drawing.Point(47, 197);
			this.entryFeeLabel.Name = "entryFeeLabel";
			this.entryFeeLabel.Size = new System.Drawing.Size(131, 37);
			this.entryFeeLabel.TabIndex = 13;
			this.entryFeeLabel.Text = "Entry Fee:";
			// 
			// selectTeamDropDown
			// 
			this.selectTeamDropDown.FormattingEnabled = true;
			this.selectTeamDropDown.Location = new System.Drawing.Point(54, 316);
			this.selectTeamDropDown.Name = "selectTeamDropDown";
			this.selectTeamDropDown.Size = new System.Drawing.Size(278, 38);
			this.selectTeamDropDown.TabIndex = 16;
			// 
			// selectTeamLabel
			// 
			this.selectTeamLabel.AutoSize = true;
			this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamLabel.Location = new System.Drawing.Point(55, 265);
			this.selectTeamLabel.Name = "selectTeamLabel";
			this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
			this.selectTeamLabel.TabIndex = 15;
			this.selectTeamLabel.Text = "Select Team";
			// 
			// createNewTeamLink
			// 
			this.createNewTeamLink.AutoSize = true;
			this.createNewTeamLink.Location = new System.Drawing.Point(210, 272);
			this.createNewTeamLink.Name = "createNewTeamLink";
			this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
			this.createNewTeamLink.TabIndex = 17;
			this.createNewTeamLink.TabStop = true;
			this.createNewTeamLink.Text = "create new";
			// 
			// addTeamButton
			// 
			this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTeamButton.Location = new System.Drawing.Point(79, 382);
			this.addTeamButton.Name = "addTeamButton";
			this.addTeamButton.Size = new System.Drawing.Size(214, 73);
			this.addTeamButton.TabIndex = 18;
			this.addTeamButton.Text = "Add Team";
			this.addTeamButton.UseVisualStyleBackColor = true;
			// 
			// createPrizeButton
			// 
			this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createPrizeButton.Location = new System.Drawing.Point(79, 482);
			this.createPrizeButton.Name = "createPrizeButton";
			this.createPrizeButton.Size = new System.Drawing.Size(214, 73);
			this.createPrizeButton.TabIndex = 19;
			this.createPrizeButton.Text = "Create Prize";
			this.createPrizeButton.UseVisualStyleBackColor = true;
			this.createPrizeButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// tournamentPlayersListBox
			// 
			this.tournamentPlayersListBox.FormattingEnabled = true;
			this.tournamentPlayersListBox.ItemHeight = 30;
			this.tournamentPlayersListBox.Location = new System.Drawing.Point(391, 134);
			this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
			this.tournamentPlayersListBox.Size = new System.Drawing.Size(371, 154);
			this.tournamentPlayersListBox.TabIndex = 20;
			// 
			// teamsPlayersLabel
			// 
			this.teamsPlayersLabel.AutoSize = true;
			this.teamsPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.teamsPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.teamsPlayersLabel.Location = new System.Drawing.Point(384, 94);
			this.teamsPlayersLabel.Name = "teamsPlayersLabel";
			this.teamsPlayersLabel.Size = new System.Drawing.Size(198, 37);
			this.teamsPlayersLabel.TabIndex = 21;
			this.teamsPlayersLabel.Text = "Teams / Players";
			this.teamsPlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// deleteSelectedPlayersButton
			// 
			this.deleteSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(779, 161);
			this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
			this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(146, 73);
			this.deleteSelectedPlayersButton.TabIndex = 22;
			this.deleteSelectedPlayersButton.Text = "Delete Selected";
			this.deleteSelectedPlayersButton.UseVisualStyleBackColor = true;
			// 
			// deleteSelectedPrizesButton
			// 
			this.deleteSelectedPrizesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.deleteSelectedPrizesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedPrizesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedPrizesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedPrizesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteSelectedPrizesButton.Location = new System.Drawing.Point(779, 396);
			this.deleteSelectedPrizesButton.Name = "deleteSelectedPrizesButton";
			this.deleteSelectedPrizesButton.Size = new System.Drawing.Size(146, 73);
			this.deleteSelectedPrizesButton.TabIndex = 25;
			this.deleteSelectedPrizesButton.Text = "Delete Selected";
			this.deleteSelectedPrizesButton.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(384, 329);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 37);
			this.label1.TabIndex = 24;
			this.label1.Text = "Teams / Players";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// prizesListBox
			// 
			this.prizesListBox.FormattingEnabled = true;
			this.prizesListBox.ItemHeight = 30;
			this.prizesListBox.Location = new System.Drawing.Point(391, 369);
			this.prizesListBox.Name = "prizesListBox";
			this.prizesListBox.Size = new System.Drawing.Size(371, 154);
			this.prizesListBox.TabIndex = 23;
			// 
			// createTournamentButton
			// 
			this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTournamentButton.Location = new System.Drawing.Point(368, 632);
			this.createTournamentButton.Name = "createTournamentButton";
			this.createTournamentButton.Size = new System.Drawing.Size(214, 73);
			this.createTournamentButton.TabIndex = 26;
			this.createTournamentButton.Text = "Create Tournament";
			this.createTournamentButton.UseVisualStyleBackColor = true;
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1014, 763);
			this.Controls.Add(this.createTournamentButton);
			this.Controls.Add(this.deleteSelectedPrizesButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.prizesListBox);
			this.Controls.Add(this.deleteSelectedPlayersButton);
			this.Controls.Add(this.teamsPlayersLabel);
			this.Controls.Add(this.tournamentPlayersListBox);
			this.Controls.Add(this.createPrizeButton);
			this.Controls.Add(this.addTeamButton);
			this.Controls.Add(this.createNewTeamLink);
			this.Controls.Add(this.selectTeamDropDown);
			this.Controls.Add(this.selectTeamLabel);
			this.Controls.Add(this.entryFeeValue);
			this.Controls.Add(this.entryFeeLabel);
			this.Controls.Add(this.tournamentNameValue);
			this.Controls.Add(this.tournamentNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "CreateTournamentForm";
			this.Text = "Create Tournament";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.TextBox tournamentNameValue;
		private System.Windows.Forms.Label tournamentNameLabel;
		private System.Windows.Forms.TextBox entryFeeValue;
		private System.Windows.Forms.Label entryFeeLabel;
		private System.Windows.Forms.ComboBox selectTeamDropDown;
		private System.Windows.Forms.Label selectTeamLabel;
		private System.Windows.Forms.LinkLabel createNewTeamLink;
		private System.Windows.Forms.Button addTeamButton;
		private System.Windows.Forms.Button createPrizeButton;
		private System.Windows.Forms.ListBox tournamentPlayersListBox;
		private System.Windows.Forms.Label teamsPlayersLabel;
		private System.Windows.Forms.Button deleteSelectedPlayersButton;
		private System.Windows.Forms.Button deleteSelectedPrizesButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox prizesListBox;
		private System.Windows.Forms.Button createTournamentButton;
	}
}