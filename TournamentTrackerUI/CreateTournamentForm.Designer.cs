
namespace TournamentTrackerUI
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
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.ddlSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblLinkCreateNew = new System.Windows.Forms.LinkLabel();
            this.btnAddSelectedTeams = new System.Windows.Forms.Button();
            this.btnAddPrizes = new System.Windows.Forms.Button();
            this.ListBoxSelectedPlayers = new System.Windows.Forms.ListBox();
            this.lblPlayersAndTeams = new System.Windows.Forms.Label();
            this.btnRemovePlayers = new System.Windows.Forms.Button();
            this.btnRemovePrizes = new System.Windows.Forms.Button();
            this.lblListPrizes = new System.Windows.Forms.Label();
            this.ListBoxSelectedPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTournament.Location = new System.Drawing.Point(39, 30);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(271, 32);
            this.lblCreateTournament.TabIndex = 1;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.Location = new System.Drawing.Point(39, 92);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(178, 22);
            this.lblTournamentName.TabIndex = 3;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(43, 117);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(194, 20);
            this.txtTournamentName.TabIndex = 13;
            this.txtTournamentName.TextChanged += new System.EventHandler(this.txtTeamOneScore_TextChanged);
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(142, 166);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(75, 20);
            this.txtEntryFee.TabIndex = 15;
            this.txtEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryFee.Location = new System.Drawing.Point(39, 162);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(97, 22);
            this.lblEntryFee.TabIndex = 14;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.Location = new System.Drawing.Point(30, 223);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(124, 22);
            this.lblSelectTeam.TabIndex = 16;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // ddlSelectTeam
            // 
            this.ddlSelectTeam.FormattingEnabled = true;
            this.ddlSelectTeam.Location = new System.Drawing.Point(34, 248);
            this.ddlSelectTeam.Name = "ddlSelectTeam";
            this.ddlSelectTeam.Size = new System.Drawing.Size(203, 21);
            this.ddlSelectTeam.TabIndex = 17;
            // 
            // lblLinkCreateNew
            // 
            this.lblLinkCreateNew.AutoSize = true;
            this.lblLinkCreateNew.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkCreateNew.Location = new System.Drawing.Point(172, 229);
            this.lblLinkCreateNew.Name = "lblLinkCreateNew";
            this.lblLinkCreateNew.Size = new System.Drawing.Size(65, 16);
            this.lblLinkCreateNew.TabIndex = 18;
            this.lblLinkCreateNew.TabStop = true;
            this.lblLinkCreateNew.Text = "Create New";
            // 
            // btnAddSelectedTeams
            // 
            this.btnAddSelectedTeams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAddSelectedTeams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddSelectedTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSelectedTeams.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSelectedTeams.Location = new System.Drawing.Point(56, 284);
            this.btnAddSelectedTeams.Name = "btnAddSelectedTeams";
            this.btnAddSelectedTeams.Size = new System.Drawing.Size(147, 27);
            this.btnAddSelectedTeams.TabIndex = 19;
            this.btnAddSelectedTeams.Text = "Add Team";
            this.btnAddSelectedTeams.UseVisualStyleBackColor = true;
            // 
            // btnAddPrizes
            // 
            this.btnAddPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnAddPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrizes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPrizes.Location = new System.Drawing.Point(56, 332);
            this.btnAddPrizes.Name = "btnAddPrizes";
            this.btnAddPrizes.Size = new System.Drawing.Size(147, 27);
            this.btnAddPrizes.TabIndex = 20;
            this.btnAddPrizes.Text = "Create Prizes";
            this.btnAddPrizes.UseVisualStyleBackColor = true;
            // 
            // ListBoxSelectedPlayers
            // 
            this.ListBoxSelectedPlayers.FormattingEnabled = true;
            this.ListBoxSelectedPlayers.Location = new System.Drawing.Point(338, 106);
            this.ListBoxSelectedPlayers.Name = "ListBoxSelectedPlayers";
            this.ListBoxSelectedPlayers.Size = new System.Drawing.Size(305, 121);
            this.ListBoxSelectedPlayers.TabIndex = 21;
            // 
            // lblPlayersAndTeams
            // 
            this.lblPlayersAndTeams.AutoSize = true;
            this.lblPlayersAndTeams.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersAndTeams.Location = new System.Drawing.Point(334, 81);
            this.lblPlayersAndTeams.Name = "lblPlayersAndTeams";
            this.lblPlayersAndTeams.Size = new System.Drawing.Size(154, 22);
            this.lblPlayersAndTeams.TabIndex = 22;
            this.lblPlayersAndTeams.Text = "Players / Teams";
            // 
            // btnRemovePlayers
            // 
            this.btnRemovePlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRemovePlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemovePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePlayers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePlayers.Location = new System.Drawing.Point(649, 137);
            this.btnRemovePlayers.Name = "btnRemovePlayers";
            this.btnRemovePlayers.Size = new System.Drawing.Size(96, 49);
            this.btnRemovePlayers.TabIndex = 23;
            this.btnRemovePlayers.Text = "Remove Selection";
            this.btnRemovePlayers.UseVisualStyleBackColor = true;
            // 
            // btnRemovePrizes
            // 
            this.btnRemovePrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRemovePrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemovePrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrizes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrizes.Location = new System.Drawing.Point(649, 310);
            this.btnRemovePrizes.Name = "btnRemovePrizes";
            this.btnRemovePrizes.Size = new System.Drawing.Size(96, 49);
            this.btnRemovePrizes.TabIndex = 26;
            this.btnRemovePrizes.Text = "Remove Selection";
            this.btnRemovePrizes.UseVisualStyleBackColor = true;
            // 
            // lblListPrizes
            // 
            this.lblListPrizes.AutoSize = true;
            this.lblListPrizes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListPrizes.Location = new System.Drawing.Point(334, 247);
            this.lblListPrizes.Name = "lblListPrizes";
            this.lblListPrizes.Size = new System.Drawing.Size(67, 22);
            this.lblListPrizes.TabIndex = 25;
            this.lblListPrizes.Text = "Prizes";
            // 
            // ListBoxSelectedPrizes
            // 
            this.ListBoxSelectedPrizes.FormattingEnabled = true;
            this.ListBoxSelectedPrizes.Location = new System.Drawing.Point(338, 272);
            this.ListBoxSelectedPrizes.Name = "ListBoxSelectedPrizes";
            this.ListBoxSelectedPrizes.Size = new System.Drawing.Size(305, 121);
            this.ListBoxSelectedPrizes.TabIndex = 24;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.Location = new System.Drawing.Point(197, 421);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(240, 60);
            this.btnCreateTournament.TabIndex = 27;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 527);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnRemovePrizes);
            this.Controls.Add(this.lblListPrizes);
            this.Controls.Add(this.ListBoxSelectedPrizes);
            this.Controls.Add(this.btnRemovePlayers);
            this.Controls.Add(this.lblPlayersAndTeams);
            this.Controls.Add(this.ListBoxSelectedPlayers);
            this.Controls.Add(this.btnAddPrizes);
            this.Controls.Add(this.btnAddSelectedTeams);
            this.Controls.Add(this.lblLinkCreateNew);
            this.Controls.Add(this.ddlSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.ComboBox ddlSelectTeam;
        private System.Windows.Forms.LinkLabel lblLinkCreateNew;
        private System.Windows.Forms.Button btnAddSelectedTeams;
        private System.Windows.Forms.Button btnAddPrizes;
        private System.Windows.Forms.ListBox ListBoxSelectedPlayers;
        private System.Windows.Forms.Label lblPlayersAndTeams;
        private System.Windows.Forms.Button btnRemovePlayers;
        private System.Windows.Forms.Button btnRemovePrizes;
        private System.Windows.Forms.Label lblListPrizes;
        private System.Windows.Forms.ListBox ListBoxSelectedPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}