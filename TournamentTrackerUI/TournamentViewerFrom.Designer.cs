
namespace TournamentTrackerUI
{
    partial class TournamentViewerFrom
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
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.ddlRound = new System.Windows.Forms.ComboBox();
            this.cbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.ListboxMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblVerses = new System.Windows.Forms.Label();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournament.Location = new System.Drawing.Point(25, 24);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(141, 24);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament:";
            this.lblTournament.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(172, 24);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(90, 24);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<name>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(26, 71);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(80, 22);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round: ";
            // 
            // ddlRound
            // 
            this.ddlRound.FormattingEnabled = true;
            this.ddlRound.Location = new System.Drawing.Point(112, 71);
            this.ddlRound.Name = "ddlRound";
            this.ddlRound.Size = new System.Drawing.Size(177, 21);
            this.ddlRound.TabIndex = 3;
            // 
            // cbUnplayedOnly
            // 
            this.cbUnplayedOnly.AutoSize = true;
            this.cbUnplayedOnly.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnplayedOnly.Location = new System.Drawing.Point(112, 113);
            this.cbUnplayedOnly.Name = "cbUnplayedOnly";
            this.cbUnplayedOnly.Size = new System.Drawing.Size(142, 22);
            this.cbUnplayedOnly.TabIndex = 4;
            this.cbUnplayedOnly.Text = "Unplayed Only";
            this.cbUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // ListboxMatchup
            // 
            this.ListboxMatchup.FormattingEnabled = true;
            this.ListboxMatchup.Location = new System.Drawing.Point(29, 182);
            this.ListboxMatchup.Name = "ListboxMatchup";
            this.ListboxMatchup.Size = new System.Drawing.Size(260, 238);
            this.ListboxMatchup.TabIndex = 5;
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneName.Location = new System.Drawing.Point(354, 193);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(120, 22);
            this.lblTeamOneName.TabIndex = 6;
            this.lblTeamOneName.Text = "<team One>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamOneScore.Location = new System.Drawing.Point(333, 230);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(57, 17);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score:";
            this.lblTeamOneScore.Click += new System.EventHandler(this.lblTeamOneScore_Click);
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(333, 351);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(57, 17);
            this.lblTeamTwoScore.TabIndex = 8;
            this.lblTeamTwoScore.Text = "Score:";
            this.lblTeamTwoScore.Click += new System.EventHandler(this.lblTeamTwoScore_Click);
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamTwoName.Location = new System.Drawing.Point(353, 297);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(121, 22);
            this.lblTeamTwoName.TabIndex = 9;
            this.lblTeamTwoName.Text = "<team Two>";
            // 
            // lblVerses
            // 
            this.lblVerses.AutoSize = true;
            this.lblVerses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerses.Location = new System.Drawing.Point(392, 262);
            this.lblVerses.Name = "lblVerses";
            this.lblVerses.Size = new System.Drawing.Size(48, 22);
            this.lblVerses.TabIndex = 10;
            this.lblVerses.Text = "-VS-";
            this.lblVerses.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(397, 348);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(78, 20);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(396, 227);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(78, 20);
            this.txtTeamOneScore.TabIndex = 12;
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.Location = new System.Drawing.Point(516, 250);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(97, 45);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblVerses);
            this.Controls.Add(this.lblTeamTwoName);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOneName);
            this.Controls.Add(this.ListboxMatchup);
            this.Controls.Add(this.cbUnplayedOnly);
            this.Controls.Add(this.ddlRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblTournament);
            this.Name = "TournamentViewerFrom";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox ddlRound;
        private System.Windows.Forms.CheckBox cbUnplayedOnly;
        private System.Windows.Forms.ListBox ListboxMatchup;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblVerses;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.Button btnScore;
    }
}

