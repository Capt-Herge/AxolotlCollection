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
            this.groupBestOfTen.SuspendLayout();
            this.groupSubmitScore.SuspendLayout();
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
            // Flappy_Bird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 723);
            this.Controls.Add(this.groupSubmitScore);
            this.Controls.Add(this.groupBestOfTen);
            this.Controls.Add(this.Score);
            this.MaximumSize = new System.Drawing.Size(1022, 762);
            this.MinimumSize = new System.Drawing.Size(1022, 762);
            this.Name = "Flappy_Bird";
            this.Text = "Flappy_Bird";
            this.groupBestOfTen.ResumeLayout(false);
            this.groupSubmitScore.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}