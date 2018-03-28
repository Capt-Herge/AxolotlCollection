namespace Spielesammlung.Flappy_Bird
{
    partial class Flappy_Bird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy_Bird));
            this.Score = new System.Windows.Forms.Label();
            this.labelHighScores = new System.Windows.Forms.Label();
            this.applyScore = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelText1 = new System.Windows.Forms.Label();
            this.labelText2 = new System.Windows.Forms.Label();
            this.labelFinalScore = new System.Windows.Forms.Label();
            this.groupBestOfTen = new System.Windows.Forms.GroupBox();
            this.groupSubmitScore = new System.Windows.Forms.GroupBox();
            this.labelWarnTextLenght = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zumHauptmenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupHelp = new System.Windows.Forms.GroupBox();
            this.helpGetButton = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.groupBestOfTen.SuspendLayout();
            this.groupSubmitScore.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Enabled = false;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Coral;
            this.Score.Location = new System.Drawing.Point(871, 9);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(123, 69);
            this.Score.TabIndex = 0;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Score.UseCompatibleTextRendering = true;
            // 
            // labelHighScores
            // 
            this.labelHighScores.Location = new System.Drawing.Point(6, 27);
            this.labelHighScores.Name = "labelHighScores";
            this.labelHighScores.Size = new System.Drawing.Size(312, 471);
            this.labelHighScores.TabIndex = 2;
            this.labelHighScores.Visible = false;
            // 
            // applyScore
            // 
            this.applyScore.Location = new System.Drawing.Point(25, 118);
            this.applyScore.Name = "applyScore";
            this.applyScore.Size = new System.Drawing.Size(179, 60);
            this.applyScore.TabIndex = 3;
            this.applyScore.Text = "Highscore eintragen";
            this.applyScore.UseVisualStyleBackColor = true;
            this.applyScore.Visible = false;
            this.applyScore.Click += new System.EventHandler(this.applyScore_Click);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.labelPlayerName.Location = new System.Drawing.Point(116, 63);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(88, 24);
            this.labelPlayerName.TabIndex = 4;
            this.labelPlayerName.Visible = false;
            this.labelPlayerName.Click += new System.EventHandler(this.finalScore_Click);
            // 
            // labelText1
            // 
            this.labelText1.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.labelText1.Location = new System.Drawing.Point(22, 63);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(88, 24);
            this.labelText1.TabIndex = 5;
            this.labelText1.Text = "Namen eingeben:";
            this.labelText1.Visible = false;
            this.labelText1.Click += new System.EventHandler(this.textLabel_Click);
            // 
            // labelText2
            // 
            this.labelText2.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.labelText2.Location = new System.Drawing.Point(20, 39);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(88, 24);
            this.labelText2.TabIndex = 6;
            this.labelText2.Text = "Punkte";
            this.labelText2.Visible = false;
            // 
            // labelFinalScore
            // 
            this.labelFinalScore.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.labelFinalScore.Location = new System.Drawing.Point(116, 39);
            this.labelFinalScore.Name = "labelFinalScore";
            this.labelFinalScore.Size = new System.Drawing.Size(88, 24);
            this.labelFinalScore.TabIndex = 7;
            this.labelFinalScore.Visible = false;
            // 
            // groupBestOfTen
            // 
            this.groupBestOfTen.Controls.Add(this.labelHighScores);
            this.groupBestOfTen.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.groupBestOfTen.Location = new System.Drawing.Point(355, 202);
            this.groupBestOfTen.Name = "groupBestOfTen";
            this.groupBestOfTen.Size = new System.Drawing.Size(305, 311);
            this.groupBestOfTen.TabIndex = 8;
            this.groupBestOfTen.TabStop = false;
            this.groupBestOfTen.Text = "Beste 10 Spieler";
            this.groupBestOfTen.Visible = false;
            this.groupBestOfTen.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupSubmitScore
            // 
            this.groupSubmitScore.Controls.Add(this.labelWarnTextLenght);
            this.groupSubmitScore.Controls.Add(this.labelText2);
            this.groupSubmitScore.Controls.Add(this.applyScore);
            this.groupSubmitScore.Controls.Add(this.labelFinalScore);
            this.groupSubmitScore.Controls.Add(this.labelPlayerName);
            this.groupSubmitScore.Controls.Add(this.labelText1);
            this.groupSubmitScore.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSubmitScore.Location = new System.Drawing.Point(389, 314);
            this.groupSubmitScore.Name = "groupSubmitScore";
            this.groupSubmitScore.Size = new System.Drawing.Size(229, 199);
            this.groupSubmitScore.TabIndex = 9;
            this.groupSubmitScore.TabStop = false;
            this.groupSubmitScore.Text = "Namen eintragen";
            this.groupSubmitScore.Visible = false;
            // 
            // labelWarnTextLenght
            // 
            this.labelWarnTextLenght.Font = new System.Drawing.Font("Courier New", 7.25F);
            this.labelWarnTextLenght.Location = new System.Drawing.Point(15, 98);
            this.labelWarnTextLenght.Name = "labelWarnTextLenght";
            this.labelWarnTextLenght.Size = new System.Drawing.Size(198, 17);
            this.labelWarnTextLenght.TabIndex = 8;
            this.labelWarnTextLenght.Text = "Name muss aus 3 Zeichen bestehen";
            this.labelWarnTextLenght.Visible = false;
            this.labelWarnTextLenght.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.highscoreToolStripMenuItem,
            this.zumHauptmenüToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.menüToolStripMenuItem.Text = "Optionen";
            // 
            // highscoreToolStripMenuItem
            // 
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.highscoreToolStripMenuItem.Text = "Highscore";
            this.highscoreToolStripMenuItem.Click += new System.EventHandler(this.highscoreToolStripMenuItem_Click);
            // 
            // zumHauptmenüToolStripMenuItem
            // 
            this.zumHauptmenüToolStripMenuItem.Name = "zumHauptmenüToolStripMenuItem";
            this.zumHauptmenüToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zumHauptmenüToolStripMenuItem.Text = "zum Hauptmenü";
            this.zumHauptmenüToolStripMenuItem.Click += new System.EventHandler(this.zumHauptmenüToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // groupHelp
            // 
            this.groupHelp.Controls.Add(this.helpGetButton);
            this.groupHelp.Controls.Add(this.labelHelp);
            this.groupHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupHelp.Location = new System.Drawing.Point(335, 178);
            this.groupHelp.Margin = new System.Windows.Forms.Padding(2);
            this.groupHelp.Name = "groupHelp";
            this.groupHelp.Padding = new System.Windows.Forms.Padding(2);
            this.groupHelp.Size = new System.Drawing.Size(331, 350);
            this.groupHelp.TabIndex = 14;
            this.groupHelp.TabStop = false;
            this.groupHelp.Text = "Anleitung";
            // 
            // helpGetButton
            // 
            this.helpGetButton.Location = new System.Drawing.Point(64, 295);
            this.helpGetButton.Margin = new System.Windows.Forms.Padding(2);
            this.helpGetButton.Name = "helpGetButton";
            this.helpGetButton.Size = new System.Drawing.Size(167, 35);
            this.helpGetButton.TabIndex = 1;
            this.helpGetButton.Text = "Verstanden!";
            this.helpGetButton.UseVisualStyleBackColor = true;
            this.helpGetButton.Click += new System.EventHandler(this.helpGetButton_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.Location = new System.Drawing.Point(43, 44);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(224, 207);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.Text = resources.GetString("labelHelp.Text");
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupHelp);
            this.Controls.Add(this.groupSubmitScore);
            this.Controls.Add(this.groupBestOfTen);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Flappy_Bird";
            this.Text = "Flappy Bird";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Flappy_Bird_FormClosed);
            this.Load += new System.EventHandler(this.Flappy_Bird_Load);
            this.groupBestOfTen.ResumeLayout(false);
            this.groupSubmitScore.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupHelp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label labelHighScores;
        private System.Windows.Forms.Button applyScore;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Label labelText1;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelFinalScore;
        private System.Windows.Forms.GroupBox groupBestOfTen;
        private System.Windows.Forms.GroupBox groupSubmitScore;
        private System.Windows.Forms.Label labelWarnTextLenght;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zumHauptmenüToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupHelp;
        private System.Windows.Forms.Button helpGetButton;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
    }
}