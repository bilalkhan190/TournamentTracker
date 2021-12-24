
namespace TournamentTrackerUI
{
    partial class btnCreateTeamForm
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
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.lblSelectMember = new System.Windows.Forms.Label();
            this.ddlSelectMembers = new System.Windows.Forms.ComboBox();
            this.btnAddSelectedTeams = new System.Windows.Forms.Button();
            this.GroupboxForMembers = new System.Windows.Forms.GroupBox();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.listboxTeamMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveTeamMembers = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.GroupboxForMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(30, 116);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(239, 20);
            this.txtTeamName.TabIndex = 16;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.Location = new System.Drawing.Point(24, 91);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(119, 22);
            this.lblTeamName.TabIndex = 15;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.AutoSize = true;
            this.lblCreateTeam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTeam.Location = new System.Drawing.Point(24, 29);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(185, 32);
            this.lblCreateTeam.TabIndex = 14;
            this.lblCreateTeam.Text = "Create Team";
            // 
            // lblSelectMember
            // 
            this.lblSelectMember.AutoSize = true;
            this.lblSelectMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMember.Location = new System.Drawing.Point(24, 155);
            this.lblSelectMember.Name = "lblSelectMember";
            this.lblSelectMember.Size = new System.Drawing.Size(136, 18);
            this.lblSelectMember.TabIndex = 17;
            this.lblSelectMember.Text = "Select Members";
            this.lblSelectMember.Click += new System.EventHandler(this.label1_Click);
            // 
            // ddlSelectMembers
            // 
            this.ddlSelectMembers.FormattingEnabled = true;
            this.ddlSelectMembers.Location = new System.Drawing.Point(27, 176);
            this.ddlSelectMembers.Name = "ddlSelectMembers";
            this.ddlSelectMembers.Size = new System.Drawing.Size(242, 21);
            this.ddlSelectMembers.TabIndex = 18;
            // 
            // btnAddSelectedTeams
            // 
            this.btnAddSelectedTeams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAddSelectedTeams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddSelectedTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSelectedTeams.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelectedTeams.Location = new System.Drawing.Point(53, 212);
            this.btnAddSelectedTeams.Name = "btnAddSelectedTeams";
            this.btnAddSelectedTeams.Size = new System.Drawing.Size(132, 28);
            this.btnAddSelectedTeams.TabIndex = 20;
            this.btnAddSelectedTeams.Text = "Add Member";
            this.btnAddSelectedTeams.UseVisualStyleBackColor = true;
            // 
            // GroupboxForMembers
            // 
            this.GroupboxForMembers.Controls.Add(this.btnCreateMember);
            this.GroupboxForMembers.Controls.Add(this.txtContactNo);
            this.GroupboxForMembers.Controls.Add(this.lblContact);
            this.GroupboxForMembers.Controls.Add(this.txtLastName);
            this.GroupboxForMembers.Controls.Add(this.lblLastName);
            this.GroupboxForMembers.Controls.Add(this.txtEmail);
            this.GroupboxForMembers.Controls.Add(this.lblEmail);
            this.GroupboxForMembers.Controls.Add(this.txtTeamOneScore);
            this.GroupboxForMembers.Controls.Add(this.lblFirstName);
            this.GroupboxForMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupboxForMembers.Location = new System.Drawing.Point(28, 259);
            this.GroupboxForMembers.Name = "GroupboxForMembers";
            this.GroupboxForMembers.Size = new System.Drawing.Size(248, 213);
            this.GroupboxForMembers.TabIndex = 21;
            this.GroupboxForMembers.TabStop = false;
            this.GroupboxForMembers.Text = "Add New Member";
            this.GroupboxForMembers.Enter += new System.EventHandler(this.GroupboxForMembers_Enter);
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(87, 29);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(155, 22);
            this.txtTeamOneScore.TabIndex = 14;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(10, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(61, 16);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First-Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(155, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(87, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 22);
            this.txtLastName.TabIndex = 18;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(10, 56);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 16);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last-Name";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(87, 122);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(155, 22);
            this.txtContactNo.TabIndex = 20;
            this.txtContactNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(10, 123);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 16);
            this.lblContact.TabIndex = 19;
            this.lblContact.Text = "Contact-No:";
            this.lblContact.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateMember.Location = new System.Drawing.Point(41, 160);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(185, 28);
            this.btnCreateMember.TabIndex = 21;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // listboxTeamMembers
            // 
            this.listboxTeamMembers.FormattingEnabled = true;
            this.listboxTeamMembers.Location = new System.Drawing.Point(338, 116);
            this.listboxTeamMembers.Name = "listboxTeamMembers";
            this.listboxTeamMembers.Size = new System.Drawing.Size(254, 355);
            this.listboxTeamMembers.TabIndex = 22;
            // 
            // btnRemoveTeamMembers
            // 
            this.btnRemoveTeamMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRemoveTeamMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveTeamMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTeamMembers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeamMembers.Location = new System.Drawing.Point(607, 256);
            this.btnRemoveTeamMembers.Name = "btnRemoveTeamMembers";
            this.btnRemoveTeamMembers.Size = new System.Drawing.Size(96, 49);
            this.btnRemoveTeamMembers.TabIndex = 24;
            this.btnRemoveTeamMembers.Text = "Remove Selection";
            this.btnRemoveTeamMembers.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.Location = new System.Drawing.Point(213, 490);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(240, 47);
            this.btnCreateTeam.TabIndex = 28;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 549);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnRemoveTeamMembers);
            this.Controls.Add(this.listboxTeamMembers);
            this.Controls.Add(this.GroupboxForMembers);
            this.Controls.Add(this.btnAddSelectedTeams);
            this.Controls.Add(this.ddlSelectMembers);
            this.Controls.Add(this.lblSelectMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCreateTeam);
            this.Name = "btnCreateTeamForm";
            this.Text = "CreateTeamForm";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.GroupboxForMembers.ResumeLayout(false);
            this.GroupboxForMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.Label lblSelectMember;
        private System.Windows.Forms.ComboBox ddlSelectMembers;
        private System.Windows.Forms.Button btnAddSelectedTeams;
        private System.Windows.Forms.GroupBox GroupboxForMembers;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.ListBox listboxTeamMembers;
        private System.Windows.Forms.Button btnRemoveTeamMembers;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}