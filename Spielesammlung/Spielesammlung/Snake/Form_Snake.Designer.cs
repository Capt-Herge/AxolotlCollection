namespace Spielesammlung.Snake
{
    partial class Form_Snake
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSnake = new System.Windows.Forms.PictureBox();
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelScoreWert = new System.Windows.Forms.Label();
            this.timerSnake = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelSnake = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelAnleitung = new System.Windows.Forms.Label();
            this.buttonWeiter = new System.Windows.Forms.Button();
            this.textBoxSpieler = new System.Windows.Forms.TextBox();
            this.buttonNeustart = new System.Windows.Forms.Button();
            this.labelHighscore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zurückZumMenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neustartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highscoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSnake
            // 
            this.pictureBoxSnake.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBoxSnake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSnake.Image = global::Spielesammlung.Properties.Resources.Snake_grass_background;
            this.pictureBoxSnake.Location = new System.Drawing.Point(14, 35);
            this.pictureBoxSnake.Name = "pictureBoxSnake";
            this.pictureBoxSnake.Size = new System.Drawing.Size(900, 675);
            this.pictureBoxSnake.TabIndex = 0;
            this.pictureBoxSnake.TabStop = false;
            this.pictureBoxSnake.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSnake_Paint);
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreText.Location = new System.Drawing.Point(920, 142);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(82, 27);
            this.labelScoreText.TabIndex = 1;
            this.labelScoreText.Text = "Score";
            // 
            // labelScoreWert
            // 
            this.labelScoreWert.AutoSize = true;
            this.labelScoreWert.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreWert.Location = new System.Drawing.Point(920, 184);
            this.labelScoreWert.Name = "labelScoreWert";
            this.labelScoreWert.Size = new System.Drawing.Size(26, 27);
            this.labelScoreWert.TabIndex = 2;
            this.labelScoreWert.Text = "0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.LightGray;
            this.labelGameOver.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(220, 286);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(158, 31);
            this.labelGameOver.TabIndex = 3;
            this.labelGameOver.Text = "Game over";
            this.labelGameOver.Visible = false;
            // 
            // labelSnake
            // 
            this.labelSnake.AutoSize = true;
            this.labelSnake.BackColor = System.Drawing.Color.LightGray;
            this.labelSnake.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSnake.Location = new System.Drawing.Point(415, 215);
            this.labelSnake.Name = "labelSnake";
            this.labelSnake.Size = new System.Drawing.Size(94, 31);
            this.labelSnake.TabIndex = 17;
            this.labelSnake.Text = "Snake";
            this.labelSnake.Visible = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightGray;
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(420, 496);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(91, 37);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelAnleitung
            // 
            this.labelAnleitung.AutoSize = true;
            this.labelAnleitung.BackColor = System.Drawing.Color.LightGray;
            this.labelAnleitung.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnleitung.Location = new System.Drawing.Point(200, 245);
            this.labelAnleitung.Name = "labelAnleitung";
            this.labelAnleitung.Size = new System.Drawing.Size(118, 23);
            this.labelAnleitung.TabIndex = 15;
            this.labelAnleitung.Text = "Anleitung";
            this.labelAnleitung.Visible = false;
            // 
            // buttonWeiter
            // 
            this.buttonWeiter.BackColor = System.Drawing.Color.LightGray;
            this.buttonWeiter.Enabled = false;
            this.buttonWeiter.Font = new System.Drawing.Font("Courier New", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeiter.Location = new System.Drawing.Point(504, 434);
            this.buttonWeiter.Name = "buttonWeiter";
            this.buttonWeiter.Size = new System.Drawing.Size(91, 38);
            this.buttonWeiter.TabIndex = 14;
            this.buttonWeiter.Text = "Weiter";
            this.buttonWeiter.UseVisualStyleBackColor = false;
            this.buttonWeiter.Visible = false;
            this.buttonWeiter.Click += new System.EventHandler(this.buttonWeiter_Click);
            // 
            // textBoxSpieler
            // 
            this.textBoxSpieler.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSpieler.Enabled = false;
            this.textBoxSpieler.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpieler.Location = new System.Drawing.Point(371, 434);
            this.textBoxSpieler.MaxLength = 3;
            this.textBoxSpieler.Name = "textBoxSpieler";
            this.textBoxSpieler.Size = new System.Drawing.Size(91, 38);
            this.textBoxSpieler.TabIndex = 13;
            this.textBoxSpieler.Visible = false;
            // 
            // buttonNeustart
            // 
            this.buttonNeustart.Enabled = false;
            this.buttonNeustart.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNeustart.Location = new System.Drawing.Point(927, 374);
            this.buttonNeustart.Name = "buttonNeustart";
            this.buttonNeustart.Size = new System.Drawing.Size(75, 23);
            this.buttonNeustart.TabIndex = 12;
            this.buttonNeustart.Text = "Neustart";
            this.buttonNeustart.UseVisualStyleBackColor = true;
            this.buttonNeustart.Visible = false;
            this.buttonNeustart.Click += new System.EventHandler(this.buttonNeustart_Click);
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.BackColor = System.Drawing.Color.LightGray;
            this.labelHighscore.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighscore.Location = new System.Drawing.Point(331, 142);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(158, 31);
            this.labelHighscore.TabIndex = 11;
            this.labelHighscore.Text = "Highscore";
            this.labelHighscore.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem,
            this.highscoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neustartToolStripMenuItem,
            this.zurückZumMenüToolStripMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = "Optionen";
            // 
            // zurückZumMenüToolStripMenuItem
            // 
            this.zurückZumMenüToolStripMenuItem.Name = "zurückZumMenüToolStripMenuItem";
            this.zurückZumMenüToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.zurückZumMenüToolStripMenuItem.Text = "Zurück zum Menü";
            this.zurückZumMenüToolStripMenuItem.Click += new System.EventHandler(this.zurückZumMenüToolStripMenuItem_Click);
            // 
            // neustartToolStripMenuItem
            // 
            this.neustartToolStripMenuItem.Name = "neustartToolStripMenuItem";
            this.neustartToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.neustartToolStripMenuItem.Text = "Neustart";
            this.neustartToolStripMenuItem.Click += new System.EventHandler(this.neustartToolStripMenuItem_Click);
            // 
            // highscoreToolStripMenuItem
            // 
            this.highscoreToolStripMenuItem.Name = "highscoreToolStripMenuItem";
            this.highscoreToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.highscoreToolStripMenuItem.Text = "Highscore";
            this.highscoreToolStripMenuItem.Click += new System.EventHandler(this.highscoreToolStripMenuItem_Click);
            // 
            // Form_Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.labelSnake);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelAnleitung);
            this.Controls.Add(this.buttonWeiter);
            this.Controls.Add(this.textBoxSpieler);
            this.Controls.Add(this.buttonNeustart);
            this.Controls.Add(this.labelHighscore);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelScoreWert);
            this.Controls.Add(this.labelScoreText);
            this.Controls.Add(this.pictureBoxSnake);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Snake";
            this.Text = "Snake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Snake_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Snake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Snake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnake)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSnake;
        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelScoreWert;
        private System.Windows.Forms.Timer timerSnake;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelSnake;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelAnleitung;
        private System.Windows.Forms.Button buttonWeiter;
        private System.Windows.Forms.TextBox textBoxSpieler;
        private System.Windows.Forms.Button buttonNeustart;
        private System.Windows.Forms.Label labelHighscore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highscoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zurückZumMenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neustartToolStripMenuItem;
    }
}