
namespace TournamentTrackerUI
{
    partial class TournamentDashboardForm
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
            this.lbCreatePrizes = new System.Windows.Forms.Label();
            this.ddlExistingtournament = new System.Windows.Forms.ComboBox();
            this.lblExistingTournament = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.btnCreateNewTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCreatePrizes
            // 
            this.lbCreatePrizes.AutoSize = true;
            this.lbCreatePrizes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatePrizes.Location = new System.Drawing.Point(136, 38);
            this.lbCreatePrizes.Name = "lbCreatePrizes";
            this.lbCreatePrizes.Size = new System.Drawing.Size(326, 32);
            this.lbCreatePrizes.TabIndex = 30;
            this.lbCreatePrizes.Text = "Tournament Dashboard";
            // 
            // ddlExistingtournament
            // 
            this.ddlExistingtournament.FormattingEnabled = true;
            this.ddlExistingtournament.Location = new System.Drawing.Point(179, 126);
            this.ddlExistingtournament.Name = "ddlExistingtournament";
            this.ddlExistingtournament.Size = new System.Drawing.Size(240, 21);
            this.ddlExistingtournament.TabIndex = 32;
            this.ddlExistingtournament.SelectedIndexChanged += new System.EventHandler(this.ddlRound_SelectedIndexChanged);
            // 
            // lblExistingTournament
            // 
            this.lblExistingTournament.AutoSize = true;
            this.lblExistingTournament.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingTournament.Location = new System.Drawing.Point(175, 92);
            this.lblExistingTournament.Name = "lblExistingTournament";
            this.lblExistingTournament.Size = new System.Drawing.Size(248, 22);
            this.lblExistingTournament.TabIndex = 31;
            this.lblExistingTournament.Text = "Load Existing Tournament";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePrize.Location = new System.Drawing.Point(189, 171);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(216, 38);
            this.btnCreatePrize.TabIndex = 33;
            this.btnCreatePrize.Text = "Load Tournament";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // btnCreateNewTournament
            // 
            this.btnCreateNewTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnCreateNewTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateNewTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNewTournament.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTournament.Location = new System.Drawing.Point(175, 230);
            this.btnCreateNewTournament.Name = "btnCreateNewTournament";
            this.btnCreateNewTournament.Size = new System.Drawing.Size(244, 71);
            this.btnCreateNewTournament.TabIndex = 34;
            this.btnCreateNewTournament.Text = "Create Tournament";
            this.btnCreateNewTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.btnCreateNewTournament);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.ddlExistingtournament);
            this.Controls.Add(this.lblExistingTournament);
            this.Controls.Add(this.lbCreatePrizes);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCreatePrizes;
        private System.Windows.Forms.ComboBox ddlExistingtournament;
        private System.Windows.Forms.Label lblExistingTournament;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.Button btnCreateNewTournament;
    }
}