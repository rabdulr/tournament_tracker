namespace TrackerUI
{
	partial class CreateTeamForm
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
			this.teamNameValue = new System.Windows.Forms.TextBox();
			this.tournamentNameLabel = new System.Windows.Forms.Label();
			this.headerLabel = new System.Windows.Forms.Label();
			this.addTeamMemberButton = new System.Windows.Forms.Button();
			this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamMemberLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.firstNameValue = new System.Windows.Forms.TextBox();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.lastNameValue = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.emailValue = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.cellPhoneValue = new System.Windows.Forms.TextBox();
			this.cellphoneLabel = new System.Windows.Forms.Label();
			this.createMemberButton = new System.Windows.Forms.Button();
			this.teamMembersListBox = new System.Windows.Forms.ListBox();
			this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
			this.createTeamButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// teamNameValue
			// 
			this.teamNameValue.Location = new System.Drawing.Point(16, 122);
			this.teamNameValue.Name = "teamNameValue";
			this.teamNameValue.Size = new System.Drawing.Size(291, 35);
			this.teamNameValue.TabIndex = 15;
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.tournamentNameLabel.Location = new System.Drawing.Point(9, 82);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(157, 37);
			this.tournamentNameLabel.TabIndex = 14;
			this.tournamentNameLabel.Text = "Team Name";
			this.tournamentNameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.headerLabel.Location = new System.Drawing.Point(7, 6);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(213, 50);
			this.headerLabel.TabIndex = 13;
			this.headerLabel.Text = "Create Team";
			// 
			// addTeamMemberButton
			// 
			this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addTeamMemberButton.Location = new System.Drawing.Point(41, 304);
			this.addTeamMemberButton.Name = "addTeamMemberButton";
			this.addTeamMemberButton.Size = new System.Drawing.Size(214, 73);
			this.addTeamMemberButton.TabIndex = 21;
			this.addTeamMemberButton.Text = "Add Member";
			this.addTeamMemberButton.UseVisualStyleBackColor = true;
			// 
			// selectTeamMemberDropDown
			// 
			this.selectTeamMemberDropDown.FormattingEnabled = true;
			this.selectTeamMemberDropDown.Location = new System.Drawing.Point(16, 238);
			this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
			this.selectTeamMemberDropDown.Size = new System.Drawing.Size(278, 38);
			this.selectTeamMemberDropDown.TabIndex = 20;
			// 
			// selectTeamMemberLabel
			// 
			this.selectTeamMemberLabel.AutoSize = true;
			this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.selectTeamMemberLabel.Location = new System.Drawing.Point(17, 187);
			this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
			this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
			this.selectTeamMemberLabel.TabIndex = 19;
			this.selectTeamMemberLabel.Text = "Select Team Member";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.createMemberButton);
			this.groupBox1.Controls.Add(this.cellPhoneValue);
			this.groupBox1.Controls.Add(this.cellphoneLabel);
			this.groupBox1.Controls.Add(this.emailValue);
			this.groupBox1.Controls.Add(this.emailLabel);
			this.groupBox1.Controls.Add(this.lastNameValue);
			this.groupBox1.Controls.Add(this.lastNameLabel);
			this.groupBox1.Controls.Add(this.firstNameValue);
			this.groupBox1.Controls.Add(this.firstNameLabel);
			this.groupBox1.Location = new System.Drawing.Point(16, 446);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(439, 397);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add New Member";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// firstNameValue
			// 
			this.firstNameValue.Location = new System.Drawing.Point(183, 90);
			this.firstNameValue.Name = "firstNameValue";
			this.firstNameValue.Size = new System.Drawing.Size(216, 35);
			this.firstNameValue.TabIndex = 12;
			this.firstNameValue.TextChanged += new System.EventHandler(this.teamOneScoreValue_TextChanged);
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.firstNameLabel.Location = new System.Drawing.Point(33, 87);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
			this.firstNameLabel.TabIndex = 11;
			this.firstNameLabel.Text = "First Name";
			this.firstNameLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
			// 
			// lastNameValue
			// 
			this.lastNameValue.Location = new System.Drawing.Point(183, 142);
			this.lastNameValue.Name = "lastNameValue";
			this.lastNameValue.Size = new System.Drawing.Size(216, 35);
			this.lastNameValue.TabIndex = 14;
			this.lastNameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.lastNameLabel.Location = new System.Drawing.Point(33, 139);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
			this.lastNameLabel.TabIndex = 13;
			this.lastNameLabel.Text = "Last Name";
			this.lastNameLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// emailValue
			// 
			this.emailValue.Location = new System.Drawing.Point(183, 197);
			this.emailValue.Name = "emailValue";
			this.emailValue.Size = new System.Drawing.Size(216, 35);
			this.emailValue.TabIndex = 16;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.emailLabel.Location = new System.Drawing.Point(33, 194);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(82, 37);
			this.emailLabel.TabIndex = 15;
			this.emailLabel.Text = "Email";
			// 
			// cellPhoneValue
			// 
			this.cellPhoneValue.Location = new System.Drawing.Point(183, 262);
			this.cellPhoneValue.Name = "cellPhoneValue";
			this.cellPhoneValue.Size = new System.Drawing.Size(216, 35);
			this.cellPhoneValue.TabIndex = 18;
			// 
			// cellphoneLabel
			// 
			this.cellphoneLabel.AutoSize = true;
			this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.cellphoneLabel.Location = new System.Drawing.Point(33, 259);
			this.cellphoneLabel.Name = "cellphoneLabel";
			this.cellphoneLabel.Size = new System.Drawing.Size(138, 37);
			this.cellphoneLabel.TabIndex = 17;
			this.cellphoneLabel.Text = "Cellphone";
			// 
			// createMemberButton
			// 
			this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createMemberButton.Location = new System.Drawing.Point(108, 326);
			this.createMemberButton.Name = "createMemberButton";
			this.createMemberButton.Size = new System.Drawing.Size(214, 51);
			this.createMemberButton.TabIndex = 22;
			this.createMemberButton.Text = "Create Member";
			this.createMemberButton.UseVisualStyleBackColor = true;
			// 
			// teamMembersListBox
			// 
			this.teamMembersListBox.FormattingEnabled = true;
			this.teamMembersListBox.ItemHeight = 30;
			this.teamMembersListBox.Location = new System.Drawing.Point(483, 122);
			this.teamMembersListBox.Name = "teamMembersListBox";
			this.teamMembersListBox.Size = new System.Drawing.Size(390, 724);
			this.teamMembersListBox.TabIndex = 23;
			// 
			// deleteSelectedMemberButton
			// 
			this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteSelectedMemberButton.Location = new System.Drawing.Point(903, 419);
			this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
			this.deleteSelectedMemberButton.Size = new System.Drawing.Size(146, 73);
			this.deleteSelectedMemberButton.TabIndex = 24;
			this.deleteSelectedMemberButton.Text = "Delete Member";
			this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
			// 
			// createTeamButton
			// 
			this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.createTeamButton.Location = new System.Drawing.Point(391, 865);
			this.createTeamButton.Name = "createTeamButton";
			this.createTeamButton.Size = new System.Drawing.Size(214, 73);
			this.createTeamButton.TabIndex = 27;
			this.createTeamButton.Text = "Create Team";
			this.createTeamButton.UseVisualStyleBackColor = true;
			// 
			// CreateTeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1087, 950);
			this.Controls.Add(this.createTeamButton);
			this.Controls.Add(this.deleteSelectedMemberButton);
			this.Controls.Add(this.teamMembersListBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.addTeamMemberButton);
			this.Controls.Add(this.selectTeamMemberDropDown);
			this.Controls.Add(this.selectTeamMemberLabel);
			this.Controls.Add(this.teamNameValue);
			this.Controls.Add(this.tournamentNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "CreateTeamForm";
			this.Text = "Create Team";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox teamNameValue;
		private System.Windows.Forms.Label tournamentNameLabel;
		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Button addTeamMemberButton;
		private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
		private System.Windows.Forms.Label selectTeamMemberLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox firstNameValue;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.TextBox lastNameValue;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Button createMemberButton;
		private System.Windows.Forms.TextBox cellPhoneValue;
		private System.Windows.Forms.Label cellphoneLabel;
		private System.Windows.Forms.TextBox emailValue;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.ListBox teamMembersListBox;
		private System.Windows.Forms.Button deleteSelectedMemberButton;
		private System.Windows.Forms.Button createTeamButton;
	}
}